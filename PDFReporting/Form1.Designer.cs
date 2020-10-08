namespace PDFReporting
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtNoOfResultScan = new System.Windows.Forms.TextBox();
            this.txtNoOfRRScan = new System.Windows.Forms.TextBox();
            this.txtApplSacn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cobRegion = new System.Windows.Forms.ComboBox();
            this.txtNoOfCandidates = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSavePDF = new System.Windows.Forms.Button();
            this.btnPDFGenerate = new System.Windows.Forms.Button();
            this.txtExamYear = new System.Windows.Forms.TextBox();
            this.txtSemester = new System.Windows.Forms.TextBox();
            this.pdfViewer = new AxAcroPDFLib.AxAcroPDF();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdfViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pdfViewer);
            this.splitContainer1.Size = new System.Drawing.Size(849, 480);
            this.splitContainer1.SplitterDistance = 340;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtNoOfResultScan, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtNoOfRRScan, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtApplSacn, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.cobRegion, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNoOfCandidates, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtExamYear, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtSemester, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(340, 480);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtNoOfResultScan
            // 
            this.txtNoOfResultScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoOfResultScan.Location = new System.Drawing.Point(174, 375);
            this.txtNoOfResultScan.Name = "txtNoOfResultScan";
            this.txtNoOfResultScan.Size = new System.Drawing.Size(160, 20);
            this.txtNoOfResultScan.TabIndex = 6;
            this.txtNoOfResultScan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoOfResultScan_KeyPress);
            // 
            // txtNoOfRRScan
            // 
            this.txtNoOfRRScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoOfRRScan.Location = new System.Drawing.Point(174, 316);
            this.txtNoOfRRScan.Name = "txtNoOfRRScan";
            this.txtNoOfRRScan.Size = new System.Drawing.Size(160, 20);
            this.txtNoOfRRScan.TabIndex = 5;
            this.txtNoOfRRScan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoOfRRScan_KeyPress);
            // 
            // txtApplSacn
            // 
            this.txtApplSacn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApplSacn.Location = new System.Drawing.Point(174, 257);
            this.txtApplSacn.Name = "txtApplSacn";
            this.txtApplSacn.Size = new System.Drawing.Size(160, 20);
            this.txtApplSacn.TabIndex = 4;
            this.txtApplSacn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApplSacn_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Region";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Year Of Exam";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Semester";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "No of Candidate";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "No of Register Scan Appl/Exam Form";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "No of Register Scan in RR Registers";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "No of Register Scan in Result Sheet";
            // 
            // cobRegion
            // 
            this.cobRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cobRegion.FormattingEnabled = true;
            this.cobRegion.Items.AddRange(new object[] {
            "Srinagar",
            "Jammu",
            "ladhak"});
            this.cobRegion.Location = new System.Drawing.Point(174, 20);
            this.cobRegion.Name = "cobRegion";
            this.cobRegion.Size = new System.Drawing.Size(160, 21);
            this.cobRegion.TabIndex = 0;
            // 
            // txtNoOfCandidates
            // 
            this.txtNoOfCandidates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoOfCandidates.Location = new System.Drawing.Point(174, 198);
            this.txtNoOfCandidates.Name = "txtNoOfCandidates";
            this.txtNoOfCandidates.Size = new System.Drawing.Size(160, 20);
            this.txtNoOfCandidates.TabIndex = 3;
            this.txtNoOfCandidates.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoOfCandidates_KeyPress);
            // 
            // flowLayoutPanel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.btnClose);
            this.flowLayoutPanel1.Controls.Add(this.btnSavePDF);
            this.flowLayoutPanel1.Controls.Add(this.btnPDFGenerate);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 419);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(328, 55);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Firebrick;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(239, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 39);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSavePDF
            // 
            this.btnSavePDF.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSavePDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePDF.ForeColor = System.Drawing.Color.White;
            this.btnSavePDF.Location = new System.Drawing.Point(147, 3);
            this.btnSavePDF.Name = "btnSavePDF";
            this.btnSavePDF.Size = new System.Drawing.Size(86, 39);
            this.btnSavePDF.TabIndex = 8;
            this.btnSavePDF.Text = "Save As";
            this.btnSavePDF.UseVisualStyleBackColor = false;
            this.btnSavePDF.Click += new System.EventHandler(this.btnSavePDF_Click);
            // 
            // btnPDFGenerate
            // 
            this.btnPDFGenerate.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPDFGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDFGenerate.ForeColor = System.Drawing.Color.White;
            this.btnPDFGenerate.Location = new System.Drawing.Point(55, 3);
            this.btnPDFGenerate.Name = "btnPDFGenerate";
            this.btnPDFGenerate.Size = new System.Drawing.Size(86, 39);
            this.btnPDFGenerate.TabIndex = 7;
            this.btnPDFGenerate.Text = "PDF Generate";
            this.btnPDFGenerate.UseVisualStyleBackColor = false;
            this.btnPDFGenerate.Click += new System.EventHandler(this.btnPDFGenerate_Click);
            // 
            // txtExamYear
            // 
            this.txtExamYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExamYear.Location = new System.Drawing.Point(174, 80);
            this.txtExamYear.MaxLength = 4;
            this.txtExamYear.Name = "txtExamYear";
            this.txtExamYear.Size = new System.Drawing.Size(160, 20);
            this.txtExamYear.TabIndex = 1;
            this.txtExamYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExamYear_KeyPress);
            // 
            // txtSemester
            // 
            this.txtSemester.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSemester.Location = new System.Drawing.Point(174, 139);
            this.txtSemester.Name = "txtSemester";
            this.txtSemester.Size = new System.Drawing.Size(160, 20);
            this.txtSemester.TabIndex = 2;
            this.txtSemester.TextChanged += new System.EventHandler(this.txtSemester_TextChanged);
            // 
            // pdfViewer
            // 
            this.pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer.Enabled = true;
            this.pdfViewer.Location = new System.Drawing.Point(0, 0);
            this.pdfViewer.Name = "pdfViewer";
            this.pdfViewer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdfViewer.OcxState")));
            this.pdfViewer.Size = new System.Drawing.Size(505, 480);
            this.pdfViewer.TabIndex = 0;
            // 
            // sfd
            // 
            this.sfd.Filter = "PDF|.pdf";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 480);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF Reporting";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pdfViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtNoOfResultScan;
        private System.Windows.Forms.TextBox txtNoOfRRScan;
        private System.Windows.Forms.TextBox txtApplSacn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cobRegion;
        private System.Windows.Forms.TextBox txtNoOfCandidates;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPDFGenerate;
        private System.Windows.Forms.TextBox txtExamYear;
        private System.Windows.Forms.TextBox txtSemester;
        private AxAcroPDFLib.AxAcroPDF pdfViewer;
        private System.Windows.Forms.Button btnSavePDF;
        private System.Windows.Forms.SaveFileDialog sfd;
    }
}

