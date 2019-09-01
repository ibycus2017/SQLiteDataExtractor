using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace SQLiteDataExtractor
{
    public class ColumnsFetcher
    {
        #region プロパティ
        /// <summary>
        /// プロパティ
        /// </summary>
        public string ConnectionString { get; set; } = System.String.Empty;
        public string TableName { get; set; } = System.String.Empty;
        #endregion

        #region メソッド（データ列取得）
        /// <summary>
        /// メソッド（データ列取得）
        /// </summary>
        /// <returns></returns>
        public DataTable FetchColumns()
        {
            var fetchedColumns = new DataTable();
            if (this.ConnectionString == System.String.Empty) return fetchedColumns;
            if (this.TableName == System.String.Empty) return fetchedColumns;

            using (var sqlConnection = new SQLiteConnection(this.ConnectionString))
            using (var sqlCommand = sqlConnection.CreateCommand())
            {
                try
                {
                    sqlConnection.Open();
                    sqlCommand.CommandText = BuildSqlCommandText(sqlCommand);
                    var sqlDataAdapter = new SQLiteDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(fetchedColumns);
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
            return fetchedColumns;
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
            stringBuilder.AppendFormat("PRAGMA TABLE_INFO({0});", this.TableName);
            stringBuilder.Append("order by cid ");
            return Convert.ToString(stringBuilder);
        }
        #endregion
    }
}
