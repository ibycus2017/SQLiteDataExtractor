using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLiteDataExtractor
{
    public partial class FrmFileExport : Form
    {
        #region メンバ変数
        /// <summary>
        /// メンバ変数
        /// </summary>
        private const int EXECUTION_ID_EXPORT = 4;
        private const int EXECUTION_ID_CLOSE = 5;
        private const string EXECUTION_NAME_EXPORT = "出　力";
        private const string EXECUTION_NAME_EXIT = "閉じる";
        private static readonly int COLUMN_INDEX_CHECK_BOX = 0;
        private static readonly int COLUMN_INDEX_VALUE_NAME = 1;
        private static readonly int COLUMN_INDEX_DISPLAY_NAME = 2;
        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FrmFileExport()
        {
            InitializeComponent();
        }
        #endregion

        #region プロパティ（データソース）
        /// <summary>
        /// プロパティ（データソース）
        /// </summary>
        public DataTable DataSource { get; set; } = new DataTable();
        #endregion

        #region イベント（フォームロード)
        /// <summary>
        /// イベント（フォームロード）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmFileExport_Load(object sender, EventArgs e)
        {
            this.MakeScreen();
            this.Text = System.IO.Path.GetFileNameWithoutExtension(this.GetType().Assembly.Location);
            this.lblTitle.Text = new FormParametersFetcher().FetchCaption(this.Name);
            this.dgvColumns.Focus();
        }
        #endregion

        #region イベント（フォームクロージング）
        /// <summary>
        /// イベント（フォームクロージング）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmFileExport_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        #endregion

        #region イベント（実行ボタンクリック時）
        /// <summary>
        /// イベント（実行ボタンクリック時）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExecutions_Click(object sender, EventArgs e)
        {
            if (sender is Button){
                var buttonTabIndex = ((Button)sender).TabIndex;
                this.ExecuteProcess(buttonTabIndex);
            }
        }
        #endregion

        #region メソッド（画面を作成する）
        /// <summary>
        /// メソッド（画面を作成する）
        /// </summary>
        private void MakeScreen()
        {
            this.MakeBtnExecutions();
            this.MakeDgvColumns();
            this.MakeCboDelimiter();
            this.MakeCboQuotedField();
            this.MakeCboUseHeaderLine();
        }
        #endregion

        #region メソッド（実行ボタンを作成する）
        /// <summary>
        /// メソッド（実行ボタンを作成する）
        /// </summary>
        private void MakeBtnExecutions()
        {
            var executionTable = new Dictionary<int,string>();
            executionTable.Add(EXECUTION_ID_EXPORT, EXECUTION_NAME_EXPORT);
            executionTable.Add(EXECUTION_ID_CLOSE, EXECUTION_NAME_EXIT);

            var targetTabLayOutPanel = this.tlpExecutions;
            foreach (var targetControl in targetTabLayOutPanel.Controls)
            {
                if (targetControl is Button)
                {
                    var targetButton = (Button)targetControl;
                    if (executionTable.ContainsKey(targetButton.TabIndex) == true)
                    {
                        targetButton.Text = Convert.ToString(executionTable[targetButton.TabIndex]);
                        targetButton.Visible = true;
                    }
                }
            }
        }
        #endregion

        #region メソッド（データグリッドビューを作成する）
        /// <summary>
        /// メソッド（データグリッドビューを作成る）
        /// </summary>
        /// <returns></returns>
        private void MakeDgvColumns()
        {
            var dataSource = this.DataSource;
            var destionationDataGridView = this.dgvColumns;
            foreach(DataColumn dataColumn in dataSource.Columns)
            {
                destionationDataGridView.Rows.Add();
                destionationDataGridView.Rows[destionationDataGridView.Rows.Count - 1].Cells[COLUMN_INDEX_CHECK_BOX].Value = true;
                destionationDataGridView.Rows[destionationDataGridView.Rows.Count - 1].Cells[COLUMN_INDEX_VALUE_NAME].Value = dataColumn.ColumnName;
                destionationDataGridView.Rows[destionationDataGridView.Rows.Count - 1].Cells[COLUMN_INDEX_DISPLAY_NAME].Value = dataColumn.Caption;
            }
        }
        #endregion

        #region メソッド（コンボボックス作成（区切り文字））
        /// <summary>
        /// メソッド（コンボボックス作成（区切り文字））
        /// </summary>
        /// <returns></returns>
        private void MakeCboDelimiter()
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("value");
            dataTable.Columns.Add("display");

            var dataRow = dataTable.NewRow();
            dataRow["value"] = System.String.Empty;
            dataRow["display"] = "使用しない";
            dataTable.Rows.Add(dataRow);

            dataRow = dataTable.NewRow();
            dataRow["value"] = ",";
            dataRow["display"] = "カンマ（,）";
            dataTable.Rows.Add(dataRow);

            dataRow = dataTable.NewRow();
            dataRow["value"] = "\t";
            dataRow["display"] = "タブ";
            dataTable.Rows.Add(dataRow);

            var comboBox = this.cboDelimiter;
            comboBox.DataSource = dataTable;
            comboBox.ValueMember = "value";
            comboBox.DisplayMember = "display";
            comboBox.SelectedIndex = 1;
        }
        #endregion

        #region メソッド（コンボボックス作成（引用符））
        /// <summary>
        /// メソッド（コンボボックス作成（引用符））
        /// </summary>
        /// <returns></returns>
        private void MakeCboQuotedField()
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("value");
            dataTable.Columns.Add("display");

            var dataRow = dataTable.NewRow();
            dataRow["value"] = System.String.Empty;
            dataRow["display"] = "使用しない";
            dataTable.Rows.Add(dataRow);

            dataRow = dataTable.NewRow();
            dataRow["value"] = "\'";
            dataRow["display"] = "シングルクォーテーション（" + "\'" + "）";
            dataTable.Rows.Add(dataRow);

            dataRow = dataTable.NewRow();
            dataRow["value"] = "\"";
            dataRow["display"] = "ダブルクォーテーション（" + "\"" + "）";
            dataTable.Rows.Add(dataRow);

            var comboBox = this.cboQuotedField;
            comboBox.DataSource = dataTable;
            comboBox.ValueMember = "value";
            comboBox.DisplayMember = "display";
            comboBox.SelectedIndex = 2;
        }
        #endregion

        #region メソッド（コンボボックス作成（ヘッダー行））
        /// <summary>
        /// メソッド（コンボボックス作成（ヘッダー行））
        /// </summary>
        /// <returns></returns>
        private void MakeCboUseHeaderLine()
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("value");
            dataTable.Columns.Add("display");

            var dataRow = dataTable.NewRow();
            dataRow["value"] = true;
            dataRow["display"] = "使用する";
            dataTable.Rows.Add(dataRow);

            dataRow = dataTable.NewRow();
            dataRow["value"] = false;
            dataRow["display"] = "使用しない";
            dataTable.Rows.Add(dataRow);

            var comboBox = this.cboUseHeaderLine;
            comboBox.DataSource = dataTable;
            comboBox.ValueMember = "value";
            comboBox.DisplayMember = "display";
            comboBox.SelectedIndex = 0;
        }
        #endregion

        #region メソッド（列取得）
        /// <summary>
        /// メソッド（列取得）
        /// </summary>
        /// <returns></returns>
        private DataTable FetchColumns()
        {
            var columnsFetcher = new ColumnsFetcher();
            columnsFetcher.ConnectionString = new ConnectionStringFetcher().FetchConnectionString();
            return columnsFetcher.FetchColumns();
        }
        #endregion

        #region メソッド（処理を実行する）
        /// <summary>
        /// メソッド（処理を実行する）
        /// </summary>
        private void ExecuteProcess(int executionId)
        {
            switch (executionId)
            {
                case EXECUTION_ID_EXPORT:
                    this.ExportFile();
                    break;
                case EXECUTION_ID_CLOSE:
                    this.Close();
                    break;
            }
        }
        #endregion

        #region メソッド（ファイル出力）
        /// <summary>
        /// メソッド（ファイル出力）
        /// </summary>
        /// <param name="e"></param>
        private void ExportFile()
        {
            var fileExporter = new FileExporter();
            fileExporter.Delimiter = Convert.ToString(this.cboDelimiter.SelectedValue);
            fileExporter.QuotedField = Convert.ToString(this.cboQuotedField.SelectedValue);
            fileExporter.UseHeaderLine = Convert.ToBoolean(this.cboUseHeaderLine.SelectedValue);
            fileExporter.SelectedColumns = FetchSelectedColumns();
            fileExporter.DataSource = this.DataSource;
            fileExporter.ExportFile();
        }
        #endregion

        #region メソッド（選択列取得）
        /// <summary>
        /// メソッド（選択列取得）
        /// </summary>
        /// <returns></returns>
        private List<string> FetchSelectedColumns()
        {
            var selectedColumns = new List<string>();
            var dataGridView = this.dgvColumns;
            foreach(DataGridViewRow dataGridViewRow in dataGridView.Rows)
                if (Convert.ToBoolean(dataGridViewRow.Cells[COLUMN_INDEX_CHECK_BOX].Value) == true)
                    selectedColumns.Add(Convert.ToString(dataGridViewRow.Cells[COLUMN_INDEX_VALUE_NAME].Value));

            return selectedColumns;
        }
        #endregion
    }
}
