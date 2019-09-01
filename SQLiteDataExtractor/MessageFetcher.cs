using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SQLiteDataExtractor
{
    class MessageFetcher
    {
        #region メンバ変数
        /// <summary>
        /// メンバ変数
        /// </summary>
        private static readonly string MESSAGE_XML = System.Environment.CurrentDirectory + @"\Configration\Message.xml";
        #endregion

        #region メソッド（メッセージ取得）
        /// <summary>
        /// メソッド（メッセージ取得）
        /// </summary>
        /// <returns></returns>
        public string FetchMessage(string findTag)
        {
            var fetchedFormName = System.String.Empty;
            if (FilePathExists() == false) return fetchedFormName;
            try
            {
                var xmlDocument = XElement.Load(MESSAGE_XML);
                fetchedFormName = (from item in xmlDocument.Elements(findTag) select item).Single().Value;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return fetchedFormName;
        }
        #endregion

        #region メソッド（ファイルパスが存在しているか）
        /// <summary>
        /// メソッド（ファイルパスが存在しているか）
        /// </summary>
        /// <returns></returns>
        private bool FilePathExists()
        {
            return System.IO.File.Exists(MESSAGE_XML);
        }
        #endregion
    }
}
