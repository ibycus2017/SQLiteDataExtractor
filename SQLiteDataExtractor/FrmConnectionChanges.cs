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
    public partial class FrmConnectionChanges : Form
    {
        #region メンバ変数
        /// <summary>
        /// メンバ変数
        /// </summary>
        private const int EXECUTION_ID_CHANGES = 3;
        private const int EXECUTION_ID_BACK = 4;
        private const int EXECUTION_ID_EXIT = 5;
        private const string EXECUTION_NAME_CHANGES = "変　更";
        private const string EXECUTION_NAME_BACK = "戻　る";
        private const string EXECUTION_NAME_EXIT = "終　了";
        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FrmConnectionChanges()
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
        private void FrmConnectionChanges_Load(object sender, EventArgs e)
        {
            this.MakeScreen();
            this.Text = System.IO.Path.GetFileNameWithoutExtension(this.GetType().Assembly.Location);
            this.lblTitle.Text = new FormParametersFetcher().FetchCaption(this.Name);
            this.txtDataSource.Focus();
        }
        #endregion

        #region イベント（フォームクロージング）
        /// <summary>
        /// イベント（フォームクロージング）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmConnectionChanges_FormClosing(object sender, FormClosingEventArgs e)
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
            this.FetchConnectionString();
        }
        #endregion

        #region メソッド（接続情報を取得する）
        /// <summary>
        /// メソッド（接続情報を取得する）
        /// </summary>
        private void FetchConnectionString()
        {
            var connectionStringFetcher = new ConnectionStringFetcher();
            connectionStringFetcher.FetchConnectionString();
            this.txtDataSource.Text = connectionStringFetcher.DataSource;
            this.txtDataSource.Tag = this.lblDataSource.Text;
        }
        #endregion

        #region メソッド（実行ボタンを作成する）
        /// <summary>
        /// メソッド（実行ボタンを作成する）
        /// </summary>
        private void MakeBtnExecutions()
        {
            var executionTable = new Dictionary<int,string>();
            executionTable.Add(EXECUTION_ID_BACK, EXECUTION_NAME_BACK);
            executionTable.Add(EXECUTION_ID_EXIT, EXECUTION_NAME_EXIT);
            executionTable.Add(EXECUTION_ID_CHANGES, EXECUTION_NAME_CHANGES);

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

        #region メソッド（処理を実行する）
        /// <summary>
        /// メソッド（処理を実行する）
        /// </summary>
        private void ExecuteProcess(int executionId)
        {
            switch (executionId)
            {
                case EXECUTION_ID_CHANGES:
                    this.ChangeConnectionChange();
                    break;
                case EXECUTION_ID_BACK:
                    var frmLogin = new FrmLogin();
                    frmLogin.Show();
                    this.Hide();
                    this.Dispose();
                    break;
                case EXECUTION_ID_EXIT:
                    this.Close();
                    break;
            }
        }
        #endregion

        #region メソッド（接続情報を変更する）
        /// <summary>
        /// メソッド（接続情報を変更する）
        /// </summary>
        private void ChangeConnectionChange()
        {
            var targetTabLayOutPanel = this.tlpContainer;
            foreach (var targetControl in targetTabLayOutPanel.Controls)
            {
                if (targetControl is TextBox)
                {
                    var targetTextBox = (TextBox)targetControl;
                    if (targetTextBox.Text == System.String.Empty)
                    {
                        var stringBuilder = new StringBuilder();
                        stringBuilder.AppendFormat(new MessageFetcher().FetchMessage("ERR003"), targetTextBox.Tag);
                        MessageBox.Show(
                            Convert.ToString(stringBuilder),
                            this.Text,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        targetTextBox.Focus();
                        return;
                    }
                }
            }
            if (this.IsSucessfullConnecion() == false)
            {
                MessageBox.Show(
                    new MessageFetcher().FetchMessage("ERR005"),
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            var connectionStringRegistatnt = new ConnectionStringRegistant();
            connectionStringRegistatnt.DataSource = Convert.ToString(this.txtDataSource.Text);
            if (connectionStringRegistatnt.ChangeConnectionString() == true)
            {
                MessageBox.Show(
                new MessageFetcher().FetchMessage("MSG002"),
                this.Text,
                MessageBoxButtons.OK,
                MessageBoxIcon.None);
                this.FetchConnectionString();
            }
        }
        #endregion

        #region メソッド（接続が成功したか？）
        /// <summary>
        /// メソッド（接続が成功したか？）
        /// </summary>
        private bool IsSucessfullConnecion()
        {
            var connectionConfirmer = new ConnectionConfirmer();
            connectionConfirmer.DataSource = Convert.ToString(this.txtDataSource.Text);
            return connectionConfirmer.IsSucessfullConnecion();
        }
        #endregion

        #region メソッド（数値に変換する）
        /// <summary>
        /// メソッド（数値に変換する）
        /// </summary>
        /// <param name="sourceString"></param>
        /// <returns></returns>
        private int ConvertToInt32(string sourceString)
        {
            var result = 0;
            var isSuccessfull = Int32.TryParse(sourceString, out result);
            if (isSuccessfull == true)
                return Convert.ToInt32(sourceString);

            return 0;
        }
        #endregion

    }
}
