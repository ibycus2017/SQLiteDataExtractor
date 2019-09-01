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
    public class DataFetcher
    {
        #region メンバ変数
        /// <summary>
        /// メンバ変数
        /// </summary>
        public string ConnectionString { get; set; } = System.String.Empty;
        public string TableName { get; set; } = System.String.Empty;
        public List<ConditionsRecordDefine> Conditions { get; set; } = new List<ConditionsRecordDefine>();
        #endregion

        #region メソッド（データ取得）
        /// <summary>
        /// メソッド（データ取得）
        /// </summary>
        /// <returns></returns>
        public DataTable FetchData()
        {
            var dataTable = new DataTable();
            using (var sqlConnection = new SQLiteConnection(this.ConnectionString))
            using (var sqlCommand = sqlConnection.CreateCommand())
            {
                try
                {
                    sqlConnection.Open();
                    sqlCommand.CommandText = this.BuildSqlCommandText(sqlCommand);
                    var sqlDataAdapter = new SQLiteDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(dataTable);
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
            return dataTable;
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
            stringBuilder.Append("* ");
            stringBuilder.Append("from " + this.TableName);
            if(this.Conditions.Count > 0)
            {
                for (var i = 0; i <= this.Conditions.Count - 1;i++){
                    var recordDefine = new ConditionsRecordDefine();
                    recordDefine = this.Conditions[i];
                    stringBuilder.Append((i == 0) ? " where ": " and ");
                    stringBuilder.Append(recordDefine.ColumnName + " " + recordDefine.Operator + "@" + Convert.ToString(i));
                    sqlCommand.Parameters.Add(new SQLiteParameter("@" + Convert.ToString(i), recordDefine.SearchValue));
                }
            }
            return Convert.ToString(stringBuilder);
        }
        #endregion
    }
}
