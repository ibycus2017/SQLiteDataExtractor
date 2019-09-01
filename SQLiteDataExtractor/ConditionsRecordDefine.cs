using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteDataExtractor
{
    public class ConditionsRecordDefine
    {
        #region プロパティ
        /// <summary>
        /// プロパティ
        /// </summary>
        public string ColumnName { get; set; } = System.String.Empty;
        public string Operator { get; set; } = System.String.Empty;
        public string SearchValue { get; set; } = System.String.Empty;
        #endregion
    }
}
