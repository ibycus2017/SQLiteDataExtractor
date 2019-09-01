using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SQLiteDataExtractor
{
    class FormParametersFetcher
    {
        #region メンバ変数
        /// <summary>
        /// メンバ変数
        /// </summary>
        private static readonly string FORM_NAMES_XML = System.Environment.CurrentDirectory + @"\Configration\FormParameters.xml";
        #endregion

        #region メソッド（画面名称取得）
        /// <summary>
        /// メソッド（画面名称取得）
        /// </summary>
        /// <returns></returns>
        public string FetchCaption(string formName)
        {
            var fetchedCaption = System.String.Empty;
            if (FilePathExists() == false) return fetchedCaption;
            try
            {
                var xmlDocument = XElement.Load(FORM_NAMES_XML);
                fetchedCaption = (from xmlElemnt in xmlDocument.Elements("form")
                                  where xmlElemnt.Attribute("name").Value == formName
                                  select xmlElemnt).Single().Element("caption").Value;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return fetchedCaption;
        }
        #endregion

        #region メソッド（ファイルパスが存在しているか）
        /// <summary>
        /// メソッド（ファイルパスが存在しているか）
        /// </summary>
        /// <returns></returns>
        private bool FilePathExists()
        {
            return System.IO.File.Exists(FORM_NAMES_XML);
        }
        #endregion
    }
}
