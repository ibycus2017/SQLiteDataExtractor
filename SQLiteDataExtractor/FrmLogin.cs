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
    public partial class FrmLogin : Form
    {
        #region メンバ変数
        /// <summary>
        /// メンバ変数
        /// </summary>
        private const int EXECUTION_ID_CHANGES = 4;
        private const int EXECUTION_ID_LOGIN = 3;
        private const int EXECUTION_ID_EXIT = 5;
        private const string EXECUTION_NAME_CHANGE = "接続変更";
        private const string EXECUTION_NAME_LOGIN = "ログイン";
        private const string EXECUTION_NAME_EXIT = "終　了";
        private string DataSource = System.String.Empty;
        private string IntialCatalog = System.String.Empty;
        private int ConnectTimeout = 0;
        private string UserID = System.String.Empty;
        private string Password = System.String.Empty;
        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FrmLogin()
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
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.MakeScreen();
            this.Text = System.IO.Path.GetFileNameWithoutExtension(this.GetType().Assembly.Location);
            this.lblTitle.Text = new FormParametersFetcher().FetchCaption(this.Name);
        }
        #endregion

        #region イベント（フォームクロージング）
        /// <summary>
        /// イベント（フォームクロージング）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
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
            var connectionStringFetcher = new ConnectionStringFetcher();
            connectionStringFetcher.FetchConnectionString();
            lblDataSource.Text = connectionStringFetcher.DataSource;
            this.DataSource = connectionStringFetcher.DataSource;
        }
        #endregion

        #region メソッド（実行ボタンを作成する）
        /// <summary>
        /// メソッド（実行ボタンを作成する）
        /// </summary>
        private void MakeBtnExecutions()
        {
            var executionTable = new Dictionary<int,string>();
            executionTable.Add(EXECUTION_ID_LOGIN, EXECUTION_NAME_LOGIN);
            executionTable.Add(EXECUTION_ID_EXIT, EXECUTION_NAME_EXIT);
            executionTable.Add(EXECUTION_ID_CHANGES, EXECUTION_NAME_CHANGE);

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

        #region メソッド（実行ボタンを作成する）
        /// <summary>
        /// メソッド（実行ボタンを作成する）
        /// </summary>
        private void MakeTxtContents()
        {
            var executionTable = new Dictionary<int, string>();
            executionTable.Add(EXECUTION_ID_LOGIN, EXECUTION_NAME_LOGIN);
            executionTable.Add(EXECUTION_ID_EXIT, EXECUTION_NAME_EXIT);
            executionTable.Add(EXECUTION_ID_CHANGES, EXECUTION_NAME_CHANGE);

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
                    var frmConnectionStringChanges = new FrmConnectionChanges();
                    frmConnectionStringChanges.Show();
                    this.Hide();
                    break;
                case EXECUTION_ID_LOGIN:
                    this.Login();
                    break;
                case EXECUTION_ID_EXIT:
                    this.Close();
                    break;
            }
        }
        #endregion

        #region メソッド（ログインする）
        /// <summary>
        /// メソッド（ログインする）
        /// </summary>
        private void Login()
        {
            if (this.IsSucessfullConnecion() == false)
            {
                MessageBox.Show(
                    new MessageFetcher().FetchMessage("ERR005"),
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            var frmTableSelection = new FrmTableSelection();
            frmTableSelection.Show();
            this.Hide();
        }
        #endregion

        #region メソッド（接続が成功したか？）
        /// <summary>
        /// メソッド（接続が成功したか？）
        /// </summary>
        private bool IsSucessfullConnecion()
        {
            var connectionConfirmer = new ConnectionConfirmer();
            connectionConfirmer.DataSource = this.DataSource;
            connectionConfirmer.ConnectTimeout = this.ConnectTimeout;
            connectionConfirmer.InitialCatalog = this.IntialCatalog;
            connectionConfirmer.Password = this.Password;
            connectionConfirmer.UserID = this.UserID;
            return connectionConfirmer.IsSucessfullConnecion();
        }
        #endregion
    }
}
