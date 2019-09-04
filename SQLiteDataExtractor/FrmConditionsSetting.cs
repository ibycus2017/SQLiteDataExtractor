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
    public partial class FrmConditionsSetting : Form
    {
        #region メンバ変数
        /// <summary>
        /// メンバ変数
        /// </summary>
        private const int EXECUTION_ID_SETTING = 3;
        private const int EXECUTION_ID_BACK = 4;
        private const int EXECUTION_ID_EXIT = 5;
        private const string EXECUTION_NAME_SETTING = "設　定";
        private const string EXECUTION_NAME_BACK = "戻　る";
        private const string EXECUTION_NAME_EXIT = "終　了";
        private static readonly int COLUMN_INDEX_NAME = 0;
        private static readonly int COLUMN_INDEX_DESCRIPTION = 1;
        private static readonly int COLUMN_INDEX_TYPE_ID = 2;
        private static readonly int COLUMN_INDEX_TYPE_NAME = 3;
        private static readonly int COLUMN_INDEX_VALUE = 4;
        private static readonly int COLUMN_INDEX_OPERATOR = 5;
        private static readonly string FUZZY_SEACH_OPERATOR = "like";
        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FrmConditionsSetting()
        {
            InitializeComponent();
        }
        #endregion

        #region プロパティ
        /// <summary>
        /// プロパティ
        /// </summary>
        public string TableName { get; set; } = System.String.Empty;
        #endregion

        #region イベント（フォームロード)
        /// <summary>
        /// イベント（フォームロード）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmConditionsSetting_Load(object sender, EventArgs e)
        {
            this.MakeScreen();
            this.Text = System.IO.Path.GetFileNameWithoutExtension(this.GetType().Assembly.Location);
            this.lblTitle.Text = new FormParametersFetcher().FetchCaption(this.Name);
            this.dgvConditions.Focus();
        }
        #endregion

        #region イベント（フォームクロージング）
        /// <summary>
        /// イベント（フォームクロージング）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmConditionsSetting_FormClosing(object sender, FormClosingEventArgs e)
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
            this.MakeDgvConditions();
            this.MakeCboAndOr();
        }
        #endregion

        #region メソッド（実行ボタンを作成する）
        /// <summary>
        /// メソッド（実行ボタンを作成する）
        /// </summary>
        private void MakeBtnExecutions()
        {
            var executionTable = new Dictionary<int,string>();
            executionTable.Add(EXECUTION_ID_SETTING, EXECUTION_NAME_SETTING);
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

        #region メソッド（データグリッドビュー（検索条件）を取得する）
        /// <summary>
        /// メソッド（データグリッドビュー（検索条件）を取得する）
        /// </summary>
        /// <returns></returns>
        private void MakeDgvConditions()
        {
            var dataGridView = this.dgvConditions;
            dataGridView.Rows.Clear();

            var dataGridViewComboBoxColumn = (DataGridViewComboBoxColumn)dataGridView.Columns[5];
            dataGridViewComboBoxColumn.ValueMember = "code";
            dataGridViewComboBoxColumn.DisplayMember = "name";
            dataGridViewComboBoxColumn.DataSource = FetchRelationShipParameter();


            var fetchedColumns = this.FetchColumns();
            if (fetchedColumns.Rows.Count == 0) return;
            foreach (DataRow dataRow in fetchedColumns.Rows)
            {
                for(var i = 0; i <= 1; i++)
                {
                    var recordDeifne = new ColumnsRecordDefine();
                    recordDeifne.SubstituteRecordDefine(dataRow);

                    dataGridView.Rows.Add();
                    var dataGridViewRow = dataGridView.Rows[dataGridView.Rows.Count - 1];
                    dataGridViewRow.Cells[COLUMN_INDEX_NAME].Value = recordDeifne.Name;
                    dataGridViewRow.Cells[COLUMN_INDEX_DESCRIPTION].Value = recordDeifne.Name;
                    dataGridViewRow.Cells[COLUMN_INDEX_TYPE_ID].Value = recordDeifne.TypeName;
                    dataGridViewRow.Cells[COLUMN_INDEX_TYPE_NAME].Value = recordDeifne.TypeName;
                    dataGridViewRow.Cells[COLUMN_INDEX_VALUE].ReadOnly = false;
                    dataGridViewRow.Cells[COLUMN_INDEX_VALUE].Value = System.String.Empty;
                    dataGridViewRow.Cells[COLUMN_INDEX_OPERATOR].ReadOnly = false;
                    dataGridViewRow.Cells[COLUMN_INDEX_OPERATOR].Value = System.String.Empty;
                }
            }
            dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridView.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
        }
        #endregion

        #region メソッド（演算子取得）
        /// <summary>
        /// メソッド（演算子取得）
        /// </summary>
        /// <returns></returns>
        private DataTable FetchRelationShipParameter()
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("code", typeof(string));
            dataTable.Columns.Add("name", typeof(string));

            var dataRow = dataTable.NewRow();
            dataRow["code"] = System.String.Empty;
            dataRow["name"] = "未選択";
            dataTable.Rows.Add(dataRow);

            dataRow = dataTable.NewRow();
            dataRow["code"] = "=";
            dataRow["name"] = "等しい";
            dataTable.Rows.Add(dataRow);

            dataRow = dataTable.NewRow();
            dataRow["code"] = ">=";
            dataRow["name"] = "以上";
            dataTable.Rows.Add(dataRow);

            dataRow = dataTable.NewRow();
            dataRow["code"] = "<=";
            dataRow["name"] = "以下";
            dataTable.Rows.Add(dataRow);

            dataRow = dataTable.NewRow();
            dataRow["code"] = ">";
            dataRow["name"] = "より大きい";
            dataTable.Rows.Add(dataRow);

            dataRow = dataTable.NewRow();
            dataRow["code"] = "<";
            dataRow["name"] = "より小さい";
            dataTable.Rows.Add(dataRow);

            dataRow = dataTable.NewRow();
            dataRow["code"] = "<>";
            dataRow["name"] = "以外";
            dataTable.Rows.Add(dataRow);

            dataRow = dataTable.NewRow();
            dataRow["code"] = FUZZY_SEACH_OPERATOR;
            dataRow["name"] = "を含む";
            dataTable.Rows.Add(dataRow);

            return dataTable;
        }
        #endregion

        #region メソッド（テーブル列を取得する）
        /// <summary>
        /// メソッド（テーブル列を取得する）
        /// </summary>
        /// <returns></returns>
        private DataTable FetchColumns()
        {
            var dataTableFetcher = new ColumnsFetcher();
            dataTableFetcher.ConnectionString = new ConnectionStringFetcher().FetchConnectionString();
            dataTableFetcher.TableName = this.TableName;
            return dataTableFetcher.FetchColumns();
        }
        #endregion

        #region メソッド（コンボボックス作成「AND」「OR」）
        /// <summary>
        /// メソッド（コンボボックス作成「AND」「OR」）
        /// </summary>
        private void MakeCboAndOr()
        {
            var comboBox = this.cboAndOr;
            comboBox.ValueMember = "code";
            comboBox.DisplayMember = "name";
            comboBox.DataSource = FetchAndOrMember();
        }
        #endregion

        #region メソッド（AND/OR取得）
        /// <summary>
        /// メソッド（AND/OR取得）
        /// </summary>
        /// <returns></returns>
        private DataTable FetchAndOrMember()
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("code", typeof(string));
            dataTable.Columns.Add("name", typeof(string));

            var dataRow = dataTable.NewRow();
            dataRow["code"] = " and ";
            dataRow["name"] = "上記の設定条件すべてを満たす";
            dataTable.Rows.Add(dataRow);

            dataRow = dataTable.NewRow();
            dataRow["code"] = " or ";
            dataRow["name"] = "上記の設定条件のいずれかを満たす";
            dataTable.Rows.Add(dataRow);

            return dataTable;
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
                case EXECUTION_ID_SETTING:
                    this.SetConditions();
                    break;
                case EXECUTION_ID_BACK:
                    var targetForm = new FrmTableSelection();
                    targetForm.Show();
                    this.Hide();
                    this.Dispose();
                    break;
                case EXECUTION_ID_EXIT:
                    this.Close();
                    break;
            }
        }
        #endregion

        #region メソッド（検索条件を設定する）
        /// <summary>
        /// メソッド（検索条件を設定する）
        /// </summary>
        private void SetConditions()
        {
            var dataGridView = this.dgvConditions;
            var fetchedConditions = FetchConditions();
            var frmExtractionResults = new FrmExtractionResults();
            frmExtractionResults.TableName = this.TableName;
            frmExtractionResults.Conditions = fetchedConditions;
            frmExtractionResults.AndOr = Convert.ToString(this.cboAndOr.SelectedValue);
            frmExtractionResults.Show();
            this.Hide();
            this.Dispose();
        }
        #endregion

        #region メソッド（検索条件を取得する）
        /// <summary>
        /// メソッド（検索条件を取得する）
        /// </summary>
        /// <returns></returns>
        private List<ConditionsRecordDefine> FetchConditions()
        {
            var conditions = new List<ConditionsRecordDefine>();
            var dataGridView = this.dgvConditions;
            if (dataGridView.Rows.Count == 0)
                return conditions;

            foreach (DataGridViewRow dataGridViewRow in dataGridView.Rows)
            {
                var recordDefine = new ConditionsRecordDefine();
                recordDefine.ColumnName = Convert.ToString(dataGridViewRow.Cells[COLUMN_INDEX_NAME].Value);
                recordDefine.Operator  = Convert.ToString(dataGridViewRow.Cells[COLUMN_INDEX_OPERATOR].Value);
                recordDefine.SearchValue = Convert.ToString(dataGridViewRow.Cells[COLUMN_INDEX_VALUE].Value);
                if (recordDefine.Operator == FUZZY_SEACH_OPERATOR) recordDefine.SearchValue = "%" + recordDefine.SearchValue + "%";
                if (recordDefine.Operator != System.String.Empty && 
                    recordDefine.SearchValue != System.String.Empty)
                    conditions.Add(recordDefine);
            }
            return conditions;
        }
        #endregion
    }
}
