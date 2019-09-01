using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SQLiteDataExtractor
{
    class ConnectionConfirmer
    {
        #region プロパティ
        /// <summary>
        /// プロパティ
        /// </summary>
        public string DataSource { get; set; } = System.String.Empty;
        public string InitialCatalog { get; set; } = System.String.Empty;
        public int ConnectTimeout { get; set; } = 0;
        public bool PersistSecurityInfo { get; } = true;
        public string UserID { get; set; } = System.String.Empty;
        public string Password { get; set; } = System.String.Empty;
        #endregion

        #region メソッド（接続が成功したか？）
        /// <summary>
        /// メソッド（接続が成功したか？）
        /// </summary>
        /// <returns></returns>
        public bool IsSucessfullConnecion()
        {
            var sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
            sqlConnectionStringBuilder.DataSource = this.DataSource;
            var isSuccessfull = false;
            using (var sqlConnection = new SQLiteConnection(sqlConnectionStringBuilder.ConnectionString))
            {
                try
                {
                    sqlConnection.Open();
                    isSuccessfull = true;
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
            return isSuccessfull;
        }
        #endregion
    }
}
