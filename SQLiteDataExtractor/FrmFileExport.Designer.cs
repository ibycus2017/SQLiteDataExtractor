namespace SQLiteDataExtractor
{
    partial class FrmFileExport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpBody = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tlpFooter = new System.Windows.Forms.TableLayoutPanel();
            this.tlpExecutions = new System.Windows.Forms.TableLayoutPanel();
            this.btnExecution6 = new System.Windows.Forms.Button();
            this.btnExecution5 = new System.Windows.Forms.Button();
            this.btnExecution4 = new System.Windows.Forms.Button();
            this.btnExecution3 = new System.Windows.Forms.Button();
            this.btnExecution2 = new System.Windows.Forms.Button();
            this.btnExecution1 = new System.Windows.Forms.Button();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.dgvColumns = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDelimiter = new System.Windows.Forms.ComboBox();
            this.cboQuotedField = new System.Windows.Forms.ComboBox();
            this.cboUseHeaderLine = new System.Windows.Forms.ComboBox();
            this.tlpBody.SuspendLayout();
            this.tlpFooter.SuspendLayout();
            this.tlpExecutions.SuspendLayout();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumns)).BeginInit();
            this.tlpContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpBody
            // 
            this.tlpBody.AutoScroll = true;
            this.tlpBody.ColumnCount = 1;
            this.tlpBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBody.Controls.Add(this.lblTitle, 0, 0);
            this.tlpBody.Controls.Add(this.tlpFooter, 0, 2);
            this.tlpBody.Controls.Add(this.tlpMain, 0, 1);
            this.tlpBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBody.Location = new System.Drawing.Point(0, 0);
            this.tlpBody.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBody.Name = "tlpBody";
            this.tlpBody.RowCount = 3;
            this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpBody.Size = new System.Drawing.Size(784, 561);
            this.tlpBody.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Meiryo UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(784, 56);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "label1";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpFooter
            // 
            this.tlpFooter.AutoScroll = true;
            this.tlpFooter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tlpFooter.ColumnCount = 3;
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFooter.Controls.Add(this.tlpExecutions, 1, 0);
            this.tlpFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFooter.Location = new System.Drawing.Point(0, 504);
            this.tlpFooter.Margin = new System.Windows.Forms.Padding(0);
            this.tlpFooter.Name = "tlpFooter";
            this.tlpFooter.RowCount = 1;
            this.tlpFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFooter.Size = new System.Drawing.Size(784, 57);
            this.tlpFooter.TabIndex = 1;
            // 
            // tlpExecutions
            // 
            this.tlpExecutions.AutoScroll = true;
            this.tlpExecutions.ColumnCount = 6;
            this.tlpExecutions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpExecutions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpExecutions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpExecutions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpExecutions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpExecutions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpExecutions.Controls.Add(this.btnExecution6, 5, 0);
            this.tlpExecutions.Controls.Add(this.btnExecution5, 4, 0);
            this.tlpExecutions.Controls.Add(this.btnExecution4, 3, 0);
            this.tlpExecutions.Controls.Add(this.btnExecution3, 2, 0);
            this.tlpExecutions.Controls.Add(this.btnExecution2, 1, 0);
            this.tlpExecutions.Controls.Add(this.btnExecution1, 0, 0);
            this.tlpExecutions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpExecutions.Location = new System.Drawing.Point(39, 0);
            this.tlpExecutions.Margin = new System.Windows.Forms.Padding(0);
            this.tlpExecutions.Name = "tlpExecutions";
            this.tlpExecutions.RowCount = 1;
            this.tlpExecutions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpExecutions.Size = new System.Drawing.Size(705, 57);
            this.tlpExecutions.TabIndex = 0;
            // 
            // btnExecution6
            // 
            this.btnExecution6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExecution6.Location = new System.Drawing.Point(588, 3);
            this.btnExecution6.Name = "btnExecution6";
            this.btnExecution6.Size = new System.Drawing.Size(114, 51);
            this.btnExecution6.TabIndex = 5;
            this.btnExecution6.Text = "button6";
            this.btnExecution6.UseVisualStyleBackColor = true;
            this.btnExecution6.Visible = false;
            this.btnExecution6.Click += new System.EventHandler(this.btnExecutions_Click);
            // 
            // btnExecution5
            // 
            this.btnExecution5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExecution5.Location = new System.Drawing.Point(471, 3);
            this.btnExecution5.Name = "btnExecution5";
            this.btnExecution5.Size = new System.Drawing.Size(111, 51);
            this.btnExecution5.TabIndex = 4;
            this.btnExecution5.Text = "button5";
            this.btnExecution5.UseVisualStyleBackColor = true;
            this.btnExecution5.Visible = false;
            this.btnExecution5.Click += new System.EventHandler(this.btnExecutions_Click);
            // 
            // btnExecution4
            // 
            this.btnExecution4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExecution4.Location = new System.Drawing.Point(354, 3);
            this.btnExecution4.Name = "btnExecution4";
            this.btnExecution4.Size = new System.Drawing.Size(111, 51);
            this.btnExecution4.TabIndex = 3;
            this.btnExecution4.Text = "button4";
            this.btnExecution4.UseVisualStyleBackColor = true;
            this.btnExecution4.Visible = false;
            this.btnExecution4.Click += new System.EventHandler(this.btnExecutions_Click);
            // 
            // btnExecution3
            // 
            this.btnExecution3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExecution3.Location = new System.Drawing.Point(237, 3);
            this.btnExecution3.Name = "btnExecution3";
            this.btnExecution3.Size = new System.Drawing.Size(111, 51);
            this.btnExecution3.TabIndex = 2;
            this.btnExecution3.Text = "button3";
            this.btnExecution3.UseVisualStyleBackColor = true;
            this.btnExecution3.Visible = false;
            this.btnExecution3.Click += new System.EventHandler(this.btnExecutions_Click);
            // 
            // btnExecution2
            // 
            this.btnExecution2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExecution2.Location = new System.Drawing.Point(120, 3);
            this.btnExecution2.Name = "btnExecution2";
            this.btnExecution2.Size = new System.Drawing.Size(111, 51);
            this.btnExecution2.TabIndex = 1;
            this.btnExecution2.Text = "button2";
            this.btnExecution2.UseVisualStyleBackColor = true;
            this.btnExecution2.Visible = false;
            this.btnExecution2.Click += new System.EventHandler(this.btnExecutions_Click);
            // 
            // btnExecution1
            // 
            this.btnExecution1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExecution1.Location = new System.Drawing.Point(3, 3);
            this.btnExecution1.Name = "btnExecution1";
            this.btnExecution1.Size = new System.Drawing.Size(111, 51);
            this.btnExecution1.TabIndex = 0;
            this.btnExecution1.Text = "button1";
            this.btnExecution1.UseVisualStyleBackColor = true;
            this.btnExecution1.Visible = false;
            this.btnExecution1.Click += new System.EventHandler(this.btnExecutions_Click);
            // 
            // tlpMain
            // 
            this.tlpMain.AutoScroll = true;
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Controls.Add(this.tlpContainer, 1, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 56);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpMain.Size = new System.Drawing.Size(784, 448);
            this.tlpMain.TabIndex = 2;
            // 
            // dgvColumns
            // 
            this.dgvColumns.AllowUserToAddRows = false;
            this.dgvColumns.AllowUserToDeleteRows = false;
            this.dgvColumns.AllowUserToResizeColumns = false;
            this.dgvColumns.AllowUserToResizeRows = false;
            this.dgvColumns.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColumns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column3});
            this.dgvColumns.EnableHeadersVisualStyles = false;
            this.dgvColumns.Location = new System.Drawing.Point(3, 3);
            this.dgvColumns.MultiSelect = false;
            this.dgvColumns.Name = "dgvColumns";
            this.dgvColumns.RowHeadersVisible = false;
            this.dgvColumns.RowTemplate.Height = 21;
            this.dgvColumns.Size = new System.Drawing.Size(699, 235);
            this.dgvColumns.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "出力対象";
            this.Column1.Name = "Column1";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "列名（論理名）";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "列名";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tlpContainer
            // 
            this.tlpContainer.ColumnCount = 1;
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContainer.Controls.Add(this.dgvColumns, 0, 0);
            this.tlpContainer.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tlpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContainer.Location = new System.Drawing.Point(39, 22);
            this.tlpContainer.Margin = new System.Windows.Forms.Padding(0);
            this.tlpContainer.Name = "tlpContainer";
            this.tlpContainer.RowCount = 2;
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpContainer.Size = new System.Drawing.Size(705, 403);
            this.tlpContainer.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.cboUseHeaderLine, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cboQuotedField, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cboDelimiter, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 241);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(705, 162);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "区切り文字";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "引用符";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "ヘッダー行";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboDelimiter
            // 
            this.cboDelimiter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboDelimiter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDelimiter.FormattingEnabled = true;
            this.cboDelimiter.Location = new System.Drawing.Point(214, 3);
            this.cboDelimiter.Name = "cboDelimiter";
            this.cboDelimiter.Size = new System.Drawing.Size(488, 28);
            this.cboDelimiter.TabIndex = 3;
            // 
            // cboQuotedField
            // 
            this.cboQuotedField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboQuotedField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuotedField.FormattingEnabled = true;
            this.cboQuotedField.Location = new System.Drawing.Point(214, 43);
            this.cboQuotedField.Name = "cboQuotedField";
            this.cboQuotedField.Size = new System.Drawing.Size(488, 28);
            this.cboQuotedField.TabIndex = 4;
            // 
            // cboUseHeaderLine
            // 
            this.cboUseHeaderLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboUseHeaderLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUseHeaderLine.FormattingEnabled = true;
            this.cboUseHeaderLine.Location = new System.Drawing.Point(214, 83);
            this.cboUseHeaderLine.Name = "cboUseHeaderLine";
            this.cboUseHeaderLine.Size = new System.Drawing.Size(488, 28);
            this.cboUseHeaderLine.TabIndex = 5;
            // 
            // FrmFileExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tlpBody);
            this.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmFileExport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFileExport";
            this.Load += new System.EventHandler(this.FrmFileExport_Load);
            this.tlpBody.ResumeLayout(false);
            this.tlpBody.PerformLayout();
            this.tlpFooter.ResumeLayout(false);
            this.tlpExecutions.ResumeLayout(false);
            this.tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumns)).EndInit();
            this.tlpContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBody;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tlpFooter;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpExecutions;
        private System.Windows.Forms.Button btnExecution6;
        private System.Windows.Forms.Button btnExecution5;
        private System.Windows.Forms.Button btnExecution4;
        private System.Windows.Forms.Button btnExecution3;
        private System.Windows.Forms.Button btnExecution2;
        private System.Windows.Forms.Button btnExecution1;
        private System.Windows.Forms.DataGridView dgvColumns;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TableLayoutPanel tlpContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboUseHeaderLine;
        private System.Windows.Forms.ComboBox cboQuotedField;
        private System.Windows.Forms.ComboBox cboDelimiter;
    }
}