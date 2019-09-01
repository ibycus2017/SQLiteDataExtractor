using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SQLiteDataExtractor
{
    public class ConnectionStringFetcher
    {
        #region メンバ変数
        /// <summary>
        /// メンバ変数
        /// </summary>
        private static readonly string DATA_SOURCE_XML = System.Environment.CurrentDirectory + @"\Configration\DataSource.xml";
        #endregion

        #region プロパティ
        /// <summary>
        /// プロパティ
        /// </summary>
        public string DataSource { get; set; } = System.String.Empty;
        #endregion

        #region メソッド（接続情報取得）
        /// <summary>
        /// メソッド（接続情報取得）
        /// </summary>
        /// <returns></returns>
        public string FetchConnectionString()
        {
            var connectionString = System.String.Empty;
            if (FilePathExists() == false) return connectionString;
            try
            {
                connectionString = (from item in XElement.Load(DATA_SOURCE_XML)
                                    .Elements("connectionString")
                                    select item)
                                    .Single().Value;

                var sqlConnectionStringBuilder = new SqlConnectionStringBuilder(connectionString);
                this.DataSource = sqlConnectionStringBuilder.DataSource;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return connectionString;
        }
        #endregion

        #region メソッド（ファイルパスが存在しているか）
        /// <summary>
        /// メソッド（ファイルパスが存在しているか）
        /// </summary>
        /// <returns></returns>
        private bool FilePathExists()
        {
            return System.IO.File.Exists(DATA_SOURCE_XML);
        }
        #endregion
    }
}