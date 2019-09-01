using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SQLiteDataExtractor
{
    class ConnectionStringRegistant
    {
        #region メンバ変数
        /// <summary>
        /// メンバ変数
        /// </summary>
        private static readonly string CONFIGRATION_DIRECTORY = System.Environment.CurrentDirectory + @"\Configration";
        private static readonly string DATA_SOURCE_XML = System.Environment.CurrentDirectory + @"\Configration\DataSource.xml";
        #endregion

        #region プロパティ
        /// <summary>
        /// プロパティ
        /// </summary>
        public string DataSource { get; set; } = System.String.Empty;
        #endregion

        #region メソッド（接続情報を変更する）
        /// <summary>
        /// メソッド（接続情報を変更する）
        /// </summary>
        /// <returns></returns>
        public bool ChangeConnectionString()
        {
            var isSuccessfull = false;
            var connectionString = System.String.Empty;
            this.MakeXmlDocumentIfFilePathNotExists();
            try
            {
                var sqlConnectionStringBuilder = new SqlConnectionStringBuilder(connectionString);
                sqlConnectionStringBuilder.DataSource = this.DataSource;
                var xmlStream = new XElement("configration", 
                    new XElement("connectionString", 
                    sqlConnectionStringBuilder.ConnectionString));
                var fileStream = new FileStream(DATA_SOURCE_XML, FileMode.Create);
                xmlStream.Save(fileStream);
                fileStream.Close();
                fileStream.Dispose();
                isSuccessfull = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return isSuccessfull;
        }
        #endregion

        #region メソッド（ファイルパスが存在しているか）
        /// <summary>
        /// メソッド（ファイルパスが存在しているか）
        /// </summary>
        /// <returns></returns>
        private void MakeXmlDocumentIfFilePathNotExists()
        {
            if (System.IO.Directory.Exists(CONFIGRATION_DIRECTORY) == false) System.IO.Directory.CreateDirectory(CONFIGRATION_DIRECTORY);
            if (System.IO.File.Exists(DATA_SOURCE_XML) == false) System.IO.File.Create(DATA_SOURCE_XML);
        }
        #endregion
    }
}
