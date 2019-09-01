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
    public partial class FrmTableSelection : Form
    {
        #region メンバ変数
        /// <summary>
        /// メンバ変数
        /// </summary>
        private const int EXECUTION_ID_SELECTION = 3;
        private const int EXECUTION_ID_BACK = 4;
        private const int EXECUTION_ID_EXIT = 5;
        private const string EXECUTION_NAME_SELECTION = "選　択";
        private const string EXECUTION_NAME_BACK = "戻　る";
        private const string EXECUTION_NAME_EXIT = "終　了";
        private static readonly int COLUMN_INDEX_NAME = 0;
        private static readonly int COLUMN_INDEX_DESCRIPTION = 1;
        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FrmTableSelection()
        {
            InitializeComponent();
        }
        #endregion

        #region イベント（フォームロード)
        /// <summary>
        /// イベント（フォームロード）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTableSelection_Load(object sender, EventArgs e)
        {
            this.MakeScreen();
            this.Text = System.IO.Path.GetFileNameWithoutExtension(this.GetType().Assembly.Location);
            this.lblTitle.Text = new FormParametersFetcher().FetchCaption(this.Name);
            this.dgvTables.Focus();
        }
        #endregion

        #region イベント（フォームクロージング）
        /// <summary>
        /// イベント（フォームクロージング）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTableSelection_FormClosing(object sender, FormClosingEventArgs e)
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
            this.MakeDgvTables();
        }
        #endregion

        #region メソッド（実行ボタンを作成する）
        /// <summary>
        /// メソッド（実行ボタンを作成する）
        /// </summary>
        private void MakeBtnExecutions()
        {
            var executionTable = new Dictionary<int,string>();
            executionTable.Add(EXECUTION_ID_SELECTION, EXECUTION_NAME_SELECTION);
            executionTable.Add(EXECUTION_ID_EXIT, EXECUTION_NAME_EXIT);
            executionTable.Add(EXECUTION_ID_BACK, EXECUTION_NAME_BACK);

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
        /// メソッド（データグリッドビュー（テーブル一覧）を取得する）
        /// </summary>
        /// <returns></returns>
        private void MakeDgvTables()
        {
            var dataGridView = this.dgvTables;
            dataGridView.Rows.Clear();

            var fetchedTables = this.FetchTables();
            if (fetchedTables.Rows.Count == 0) return;
            foreach(DataRow dataRow in fetchedTables.Rows)
            {
                var tablesRecordDefine = new TablesRecordDefine();
                tablesRecordDefine.SubstituteRecordDefine(dataRow);

                dataGridView.Rows.Add();
                var dataGridViewRow = dataGridView.Rows[dataGridView.Rows.Count - 1];
                dataGridViewRow.Cells[COLUMN_INDEX_NAME].Value = tablesRecordDefine.Name;
                dataGridViewRow.Cells[COLUMN_INDEX_DESCRIPTION].Value = tablesRecordDefine.Name;
            }
            dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridView.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
        }
        #endregion

        #region メソッド（テーブル一覧を取得する）
        /// <summary>
        /// メソッド（テーブル一覧を取得する）
        /// </summary>
        /// <returns></returns>
        private DataTable FetchTables()
        {
            var tablesFetcher = new TablesFetcher();
            tablesFetcher.ConnectionString = new ConnectionStringFetcher().FetchConnectionString();
            return tablesFetcher.FetchTables();
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
                case EXECUTION_ID_BACK:
                    var frmLogin = new FrmLogin();
                    frmLogin.Show();
                    this.Hide();
                    this.Dispose();
                    break;
                case EXECUTION_ID_SELECTION:
                    this.SelectTable();
                    break;
                case EXECUTION_ID_EXIT:
                    this.Close();
                    break;
            }
        }
        #endregion

        #region メソッド（テーブルを選択する）
        /// <summary>
        /// メソッド（テーブルを選択する）
        /// </summary>
        private void SelectTable()
        {
            var dataGridView = this.dgvTables;
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show(new MessageFetcher().FetchMessage("ERR001"), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var frmConditionsSetting = new FrmConditionsSetting();
            frmConditionsSetting.TableName = Convert.ToString(dataGridView.Rows[dgvTables.CurrentCell.RowIndex].Cells[COLUMN_INDEX_NAME].Value);
            frmConditionsSetting.Show();
            this.Hide();
            this.Dispose();
        }
        #endregion
    }
}
