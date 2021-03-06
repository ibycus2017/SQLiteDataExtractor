﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteDataExtractor
{
    class ColumnsRecordDefine
    {
        #region プロパティ
        /// <summary>
        /// プロパティ
        /// </summary>
        public int Id { get; set; } = 0;
        public string Name { get; set; } = System.String.Empty;
        public string TypeName { get; set; } = System.String.Empty;
        #endregion

        #region メソッド（レコード定義体に代入する）
        /// <summary>
        /// メソッド（レコード定義体に代入する）
        /// </summary>
        /// <param name="dataRow"></param>
        public void SubstituteRecordDefine(DataRow dataRow)
        {
            var columnName = System.String.Empty;

            columnName = "cid";
            if (dataRow.Table.Columns.Contains(columnName)==true)
                this.Id = Convert.ToInt32(dataRow[columnName]);

            columnName = "name";
            if (dataRow.Table.Columns.Contains(columnName) == true)
                this.Name = Convert.ToString(dataRow[columnName]);

            columnName = "type";
            if (dataRow.Table.Columns.Contains(columnName) == true)
                this.TypeName = Convert.ToString(dataRow[columnName]);
        }
        #endregion
    }
}
