namespace SQLiteDataExtractor
{
    partial class FrmExtractionResults
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
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.tlpBody.SuspendLayout();
            this.tlpFooter.SuspendLayout();
            this.tlpExecutions.SuspendLayout();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
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
            this.tlpMain.Controls.Add(this.dgvResults, 1, 1);
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
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.AllowUserToResizeColumns = false;
            this.dgvResults.AllowUserToResizeRows = false;
            this.dgvResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResults.EnableHeadersVisualStyles = false;
            this.dgvResults.Location = new System.Drawing.Point(42, 25);
            this.dgvResults.MultiSelect = false;
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.RowTemplate.Height = 21;
            this.dgvResults.Size = new System.Drawing.Size(699, 397);
            this.dgvResults.TabIndex = 1;
            // 
            // FrmExtractionResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tlpBody);
            this.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmExtractionResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmExtractionResults";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmExtractionResults_FormClosing);
            this.Load += new System.EventHandler(this.FrmExtractionResults_Load);
            this.tlpBody.ResumeLayout(false);
            this.tlpBody.PerformLayout();
            this.tlpFooter.ResumeLayout(false);
            this.tlpExecutions.ResumeLayout(false);
            this.tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvResults;
    }
}