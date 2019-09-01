using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLiteDataExtractor
{
    public class FileExporter
    {
        #region プロパティ
        /// <summary>
        /// プロパティ
        /// </summary>
        public string Delimiter { get; set; } = System.String.Empty;
        public string QuotedField { get; set; } = System.String.Empty;
        public bool UseHeaderLine { get; set; } = false;
        public DataTable DataSource { get; set; } = new DataTable();
        public List<string> SelectedColumns { get; set; } = new List<string>();
        #endregion

        #region メソッド（データグリッドビューからファイル出力する）
        /// <summary>
        /// メソッド（データグリッドビューからファイル出力する）
        /// </summary>
        /// <returns></returns>
        public bool ExportFile()
        {
            var dataSource = this.DataSource;
            if (dataSource == null) return false;
            if (dataSource.Rows.Count == 0) return false;
            var saveFileName = this.FetchSaveFileName();
            if (saveFileName == System.String.Empty) return false;

            using (var streamWriter = new StreamWriter(saveFileName, false))
            {
                var columnItems = new List<object>();
                if (this.UseHeaderLine == true)
                {
                    foreach (DataColumn dataColumn in dataSource.Columns)
                        if (SelectedColumns.Contains(dataColumn.ColumnName) == true)
                            columnItems.Add(this.QuotedField + dataColumn.Caption + this.QuotedField);

                    streamWriter.WriteLine(string.Join(this.Delimiter, columnItems));
                }

                foreach (DataRow dataRow in dataSource.Rows)
                {
                    columnItems = new List<object>();
                    foreach (DataColumn dataColumn in dataSource.Columns)
                    {
                        if (SelectedColumns.Contains(dataColumn.ColumnName) == true)
                        {
                            var columnValue = Convert.ToString(dataRow[dataColumn.ColumnName]);
                            columnItems.Add(this.QuotedField + columnValue + this.QuotedField);
                        }
                    }
                    streamWriter.WriteLine(string.Join(this.Delimiter, columnItems));
                }
            }
            System.Diagnostics.Process.Start(saveFileName);
            return true;
        }
        #endregion

        #region メソッド（ファイル保存名取得）
        /// <summary>
        /// メソッド（ファイル保存名取得）
        /// </summary>
        /// <returns></returns>
        private string FetchSaveFileName()
        {
            var saveFileName = System.String.Empty;
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "新しいファイル.txt";
            saveFileDialog.InitialDirectory = System.Environment.CurrentDirectory;
            saveFileDialog.Filter = "TextFile(*.txt)|*.txt|すべてのファイル(*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.Title = "保存先のファイルを選択してください";
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK) saveFileName = saveFileDialog.FileName;
            return saveFileName;
        }
        #endregion
    }
}
