namespace CopyAndPaste
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
            this.components = new System.ComponentModel.Container();
            this.lboxTextSave = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.공백제거ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.저장하기ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.불러오기ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.모두삭제ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.프로그램정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblactivation = new System.Windows.Forms.Label();
            this.cboxactivation = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnlbtextadd = new System.Windows.Forms.Button();
            this.txtlbtextadd = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.불러오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.공백제거ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.모두삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정보StripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lboxTextSave
            // 
            this.lboxTextSave.ContextMenuStrip = this.contextMenuStrip1;
            this.lboxTextSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboxTextSave.FormattingEnabled = true;
            this.lboxTextSave.ItemHeight = 12;
            this.lboxTextSave.Location = new System.Drawing.Point(3, 43);
            this.lboxTextSave.Name = "lboxTextSave";
            this.lboxTextSave.Size = new System.Drawing.Size(200, 158);
            this.lboxTextSave.TabIndex = 0;
            this.lboxTextSave.SelectedIndexChanged += new System.EventHandler(this.lboxTextSave_SelectedIndexChanged);
            this.lboxTextSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lboxTextSave_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.공백제거ToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.모두삭제ToolStripMenuItem1,
            this.toolStripSeparator2,
            this.프로그램정보ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(151, 98);
            // 
            // 공백제거ToolStripMenuItem1
            // 
            this.공백제거ToolStripMenuItem1.Name = "공백제거ToolStripMenuItem1";
            this.공백제거ToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.공백제거ToolStripMenuItem1.Text = "공백 제거";
            this.공백제거ToolStripMenuItem1.Click += new System.EventHandler(this.공백제거ToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.저장하기ToolStripMenuItem1,
            this.불러오기ToolStripMenuItem1});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(150, 22);
            this.toolStripMenuItem2.Text = "클립보드";
            // 
            // 저장하기ToolStripMenuItem1
            // 
            this.저장하기ToolStripMenuItem1.Name = "저장하기ToolStripMenuItem1";
            this.저장하기ToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.저장하기ToolStripMenuItem1.Text = "저장하기";
            this.저장하기ToolStripMenuItem1.Click += new System.EventHandler(this.저장하기ToolStripMenuItem1_Click);
            // 
            // 불러오기ToolStripMenuItem1
            // 
            this.불러오기ToolStripMenuItem1.Name = "불러오기ToolStripMenuItem1";
            this.불러오기ToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.불러오기ToolStripMenuItem1.Text = "불러오기";
            this.불러오기ToolStripMenuItem1.Click += new System.EventHandler(this.불러오기ToolStripMenuItem1_Click);
            // 
            // 모두삭제ToolStripMenuItem1
            // 
            this.모두삭제ToolStripMenuItem1.Name = "모두삭제ToolStripMenuItem1";
            this.모두삭제ToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.모두삭제ToolStripMenuItem1.Text = "모두 삭제";
            this.모두삭제ToolStripMenuItem1.Click += new System.EventHandler(this.모두삭제ToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(147, 6);
            // 
            // 프로그램정보ToolStripMenuItem
            // 
            this.프로그램정보ToolStripMenuItem.Name = "프로그램정보ToolStripMenuItem";
            this.프로그램정보ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.프로그램정보ToolStripMenuItem.Text = "프로그램 정보";
            this.프로그램정보ToolStripMenuItem.Click += new System.EventHandler(this.프로그램정보ToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lboxTextSave, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(206, 244);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblactivation);
            this.panel1.Controls.Add(this.cboxactivation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 34);
            this.panel1.TabIndex = 1;
            // 
            // lblactivation
            // 
            this.lblactivation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblactivation.Location = new System.Drawing.Point(114, 10);
            this.lblactivation.Name = "lblactivation";
            this.lblactivation.Size = new System.Drawing.Size(83, 15);
            this.lblactivation.TabIndex = 1;
            this.lblactivation.Text = "활성화 상태";
            this.lblactivation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblactivation.Click += new System.EventHandler(this.lblactivation_Click);
            // 
            // cboxactivation
            // 
            this.cboxactivation.AutoSize = true;
            this.cboxactivation.Checked = true;
            this.cboxactivation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxactivation.Location = new System.Drawing.Point(9, 9);
            this.cboxactivation.Name = "cboxactivation";
            this.cboxactivation.Size = new System.Drawing.Size(78, 16);
            this.cboxactivation.TabIndex = 0;
            this.cboxactivation.Text = "Activation";
            this.cboxactivation.UseVisualStyleBackColor = true;
            this.cboxactivation.CheckedChanged += new System.EventHandler(this.cboxactivation_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Controls.Add(this.btnlbtextadd);
            this.panel2.Controls.Add(this.txtlbtextadd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 34);
            this.panel2.TabIndex = 2;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(141, 2);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(57, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll_Change);
            // 
            // btnlbtextadd
            // 
            this.btnlbtextadd.Location = new System.Drawing.Point(86, 5);
            this.btnlbtextadd.Name = "btnlbtextadd";
            this.btnlbtextadd.Size = new System.Drawing.Size(55, 23);
            this.btnlbtextadd.TabIndex = 1;
            this.btnlbtextadd.Text = "등록";
            this.btnlbtextadd.UseVisualStyleBackColor = true;
            this.btnlbtextadd.Click += new System.EventHandler(this.btnlbtextadd_Click);
            // 
            // txtlbtextadd
            // 
            this.txtlbtextadd.Location = new System.Drawing.Point(5, 6);
            this.txtlbtextadd.Name = "txtlbtextadd";
            this.txtlbtextadd.Size = new System.Drawing.Size(75, 21);
            this.txtlbtextadd.TabIndex = 0;
            this.txtlbtextadd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtlbtextadd_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.편집ToolStripMenuItem,
            this.정보StripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(206, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.저장하기ToolStripMenuItem,
            this.불러오기ToolStripMenuItem,
            this.toolStripSeparator1,
            this.종료ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 저장하기ToolStripMenuItem
            // 
            this.저장하기ToolStripMenuItem.Name = "저장하기ToolStripMenuItem";
            this.저장하기ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.저장하기ToolStripMenuItem.Text = "저장하기";
            // 
            // 불러오기ToolStripMenuItem
            // 
            this.불러오기ToolStripMenuItem.Name = "불러오기ToolStripMenuItem";
            this.불러오기ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.불러오기ToolStripMenuItem.Text = "불러오기";
            this.불러오기ToolStripMenuItem.Click += new System.EventHandler(this.불러오기ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(119, 6);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.공백제거ToolStripMenuItem,
            this.모두삭제ToolStripMenuItem});
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.편집ToolStripMenuItem.Text = "편집";
            // 
            // 공백제거ToolStripMenuItem
            // 
            this.공백제거ToolStripMenuItem.Name = "공백제거ToolStripMenuItem";
            this.공백제거ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.공백제거ToolStripMenuItem.Text = "공백 제거";
            this.공백제거ToolStripMenuItem.Click += new System.EventHandler(this.공백제거ToolStripMenuItem_Click);
            // 
            // 모두삭제ToolStripMenuItem
            // 
            this.모두삭제ToolStripMenuItem.Name = "모두삭제ToolStripMenuItem";
            this.모두삭제ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.모두삭제ToolStripMenuItem.Text = "모두 삭제";
            this.모두삭제ToolStripMenuItem.Click += new System.EventHandler(this.모두삭제ToolStripMenuItem_Click);
            // 
            // 정보StripMenuItem1
            // 
            this.정보StripMenuItem1.Name = "정보StripMenuItem1";
            this.정보StripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.정보StripMenuItem1.Text = "정보";
            this.정보StripMenuItem1.Click += new System.EventHandler(this.정보StripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 268);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "copys";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxTextSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblactivation;
        private System.Windows.Forms.CheckBox cboxactivation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btnlbtextadd;
        private System.Windows.Forms.TextBox txtlbtextadd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장하기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 불러오기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 공백제거ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 모두삭제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 정보StripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 공백제거ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 모두삭제ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 프로그램정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장하기ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 불러오기ToolStripMenuItem1;
    }
}

