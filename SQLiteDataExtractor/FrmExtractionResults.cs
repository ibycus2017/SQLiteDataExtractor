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
    public partial class FrmExtractionResults : Form
    {
        #region メンバ変数
        /// <summary>
        /// メンバ変数
        /// </summary>
        private const int EXECUTION_ID_EXPORT = 3;
        private const int EXECUTION_ID_BACK = 4;
        private const int EXECUTION_ID_EXIT = 5;
        private const string EXECUTION_NAME_EXPORT = "出　力";
        private const string EXECUTION_NAME_BACK = "戻　る";
        private const string EXECUTION_NAME_EXIT = "終　了";
        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FrmExtractionResults()
        {
            InitializeComponent();
        }
        #endregion

        #region プロパティ
        /// <summary>
        /// プロパティ
        /// </summary>
        public string AndOr { get; set; } = " and ";
        public string TableName { get; set; } = System.String.Empty;
        public List<ConditionsRecordDefine> Conditions { get; set; } = new List<ConditionsRecordDefine>();
        #endregion

        #region イベント（フォームロード)
        /// <summary>
        /// イベント（フォームロード）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmExtractionResults_Load(object sender, EventArgs e)
        {
            this.MakeScreen();
            this.Text = System.IO.Path.GetFileNameWithoutExtension(this.GetType().Assembly.Location);
            this.lblTitle.Text = new FormParametersFetcher().FetchCaption(this.Name);
            this.dgvResults.Focus();
        }
        #endregion

        #region イベント（フォームクロージング）
        /// <summary>
        /// イベント（フォームクロージング）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmExtractionResults_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(
                new MessageFetcher().FetchMessage("MSG001"),
                this.Text,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                e.Cancel = false;
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
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
            this.MakeDgvResults();
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
            executionTable.Add(EXECUTION_ID_BACK, EXECUTION_NAME_BACK);
            executionTable.Add(EXECUTION_ID_EXIT, EXECUTION_NAME_EXIT);

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
        private void MakeDgvResults()
        {
            var dataGridView = this.dgvResults;
            dataGridView.DataSource = null;
            dataGridView.Rows.Clear();

            var fetchedDataTable = this.FetchData();
            if (fetchedDataTable.Rows.Count == 0) return;
            dataGridView.DataSource = fetchedDataTable;

            var fetchedColumns = this.FetchColumns();
            if (fetchedColumns.Rows.Count > 0)
            {
                foreach (DataGridViewColumn dataGridViewColumn in dataGridView.Columns)
                {
                    var headerText = dataGridViewColumn.HeaderText;
                    var columnDescription = headerText;
                    try
                    {
                        columnDescription = Convert.ToString(fetchedColumns.AsEnumerable()
                            .Where(dataRow => dataRow.Field<string>("name") == headerText).Single()["description"]);
                    }
                    catch(Exception exception)
                    {
                        Console.WriteLine(exception.Message);
                    }
                    finally
                    {
                        dataGridViewColumn.HeaderText = columnDescription;
                        ((DataTable)dataGridView.DataSource).Columns[dataGridViewColumn.Index].Caption = columnDescription;
                    }
                }
            }
            dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridView.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
        }
        #endregion

        #region メソッド（データ取得）
        /// <summary>
        /// メソッド（データ取得）
        /// </summary>
        /// <returns></returns>
        private DataTable FetchData()
        {
            var dataFetcher = new DataFetcher();
            dataFetcher.ConnectionString = new ConnectionStringFetcher().FetchConnectionString();
            dataFetcher.TableName = this.TableName;
            dataFetcher.Conditions = this.Conditions;
            dataFetcher.AndOr = this.AndOr;
            return dataFetcher.FetchData();
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
            columnsFetcher.TableName = this.TableName;
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
                    this.ExportFile(this.dgvResults);
                    break;
                case EXECUTION_ID_BACK:
                    var frmConditionsSetting = new FrmConditionsSetting();
                    frmConditionsSetting.TableName = this.TableName;
                    frmConditionsSetting.Show();
                    this.Hide();
                    this.Dispose();
                    break;
                case EXECUTION_ID_EXIT:
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
        private void ExportFile(DataGridView dataGridView)
        {
            var frmFileExport = new FrmFileExport();
            frmFileExport.DataSource = (DataTable)dataGridView.DataSource;
            frmFileExport.ShowDialog();
            frmFileExport.Dispose();
        }
        #endregion
    }
}
