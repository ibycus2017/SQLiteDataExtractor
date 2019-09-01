using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace SQLiteDataExtractor
{
    public class TablesFetcher
    {
        #region プロパティ
        /// <summary>
        /// プロパティ
        /// </summary>
        public string ConnectionString { get; set; } = System.String.Empty;
        #endregion

        #region メソッド（テーブル一覧取得）
        /// <summary>
        /// メソッド（テーブル一覧取得）
        /// </summary>
        /// <returns></returns>
        public DataTable FetchTables()
        {
            var fetchTables = new DataTable();
            if (this.ConnectionString == System.String.Empty) return fetchTables;

            using (var sqlConnection = new SQLiteConnection(this.ConnectionString))
            using (var sqlCommand = sqlConnection.CreateCommand())
            {
                try
                {
                    sqlConnection.Open();
                    sqlCommand.CommandText = this.BuildSqlCommandText(sqlCommand);
                    var sqlDataAdapter = new SQLiteDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(fetchTables);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    throw;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
            return fetchTables;
        }
        #endregion

        #region メソッド（SQLコマンドテキスト作成）
        /// <summary>
        /// メソッド（SQLコマンドテキスト作成）
        /// </summary>
        /// <param name="sqlCommand"></param>
        /// <returns></returns>
        private string BuildSqlCommandText(SQLiteCommand sqlCommand)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("select ");
            stringBuilder.Append("name ,");
            stringBuilder.Append("type ");
            stringBuilder.Append("from sqlite_master ");
            stringBuilder.Append("where (type='table' or type='view') ");
            stringBuilder.Append("and name <> 'sqlite_sequence'  ");
            stringBuilder.Append("order by type, name ");
            return Convert.ToString(stringBuilder);
        }
        #endregion
    }
}
