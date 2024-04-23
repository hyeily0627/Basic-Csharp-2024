namespace NewBookRentalShopApp
{
    partial class FrmBookInfo
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DgvResult = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NudPrice = new System.Windows.Forms.NumericUpDown();
            this.DtpReleaseDate = new MetroFramework.Controls.MetroDateTime();
            this.CboDivision = new MetroFramework.Controls.MetroComboBox();
            this.BtnDel = new MetroFramework.Controls.MetroButton();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.BtnNew = new MetroFramework.Controls.MetroButton();
            this.TxtIsbn = new MetroFramework.Controls.MetroTextBox();
            this.TxtNames = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.TxtAuthor = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.TxtBookIdx = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvResult)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 65);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DgvResult);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(715, 304);
            this.splitContainer1.SplitterDistance = 335;
            this.splitContainer1.TabIndex = 0;
            // 
            // DgvResult
            // 
            this.DgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvResult.Location = new System.Drawing.Point(0, 0);
            this.DgvResult.Name = "DgvResult";
            this.DgvResult.RowTemplate.Height = 23;
            this.DgvResult.Size = new System.Drawing.Size(335, 304);
            this.DgvResult.TabIndex = 0;
            this.DgvResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvResult_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NudPrice);
            this.groupBox1.Controls.Add(this.DtpReleaseDate);
            this.groupBox1.Controls.Add(this.CboDivision);
            this.groupBox1.Controls.Add(this.BtnDel);
            this.groupBox1.Controls.Add(this.BtnSave);
            this.groupBox1.Controls.Add(this.BtnNew);
            this.groupBox1.Controls.Add(this.TxtIsbn);
            this.groupBox1.Controls.Add(this.TxtNames);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.TxtAuthor);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.TxtBookIdx);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 304);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "책정보 입력";
            // 
            // NudPrice
            // 
            this.NudPrice.Location = new System.Drawing.Point(123, 232);
            this.NudPrice.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.NudPrice.Name = "NudPrice";
            this.NudPrice.Size = new System.Drawing.Size(214, 21);
            this.NudPrice.TabIndex = 7;
            // 
            // DtpReleaseDate
            // 
            this.DtpReleaseDate.Location = new System.Drawing.Point(123, 160);
            this.DtpReleaseDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.DtpReleaseDate.Name = "DtpReleaseDate";
            this.DtpReleaseDate.Size = new System.Drawing.Size(214, 29);
            this.DtpReleaseDate.TabIndex = 5;
            // 
            // CboDivision
            // 
            this.CboDivision.FormattingEnabled = true;
            this.CboDivision.ItemHeight = 23;
            this.CboDivision.Location = new System.Drawing.Point(123, 90);
            this.CboDivision.Name = "CboDivision";
            this.CboDivision.Size = new System.Drawing.Size(214, 29);
            this.CboDivision.TabIndex = 3;
            this.CboDivision.UseSelectable = true;
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(246, 265);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(91, 21);
            this.BtnDel.TabIndex = 10;
            this.BtnDel.Text = "삭제";
            this.BtnDel.UseSelectable = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(136, 265);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(91, 21);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseSelectable = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(25, 265);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(91, 21);
            this.BtnNew.TabIndex = 8;
            this.BtnNew.Text = "신규";
            this.BtnNew.UseSelectable = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // TxtIsbn
            // 
            // 
            // 
            // 
            this.TxtIsbn.CustomButton.Image = null;
            this.TxtIsbn.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.TxtIsbn.CustomButton.Name = "";
            this.TxtIsbn.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.TxtIsbn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtIsbn.CustomButton.TabIndex = 1;
            this.TxtIsbn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtIsbn.CustomButton.UseSelectable = true;
            this.TxtIsbn.CustomButton.Visible = false;
            this.TxtIsbn.Lines = new string[0];
            this.TxtIsbn.Location = new System.Drawing.Point(123, 195);
            this.TxtIsbn.MaxLength = 32767;
            this.TxtIsbn.Name = "TxtIsbn";
            this.TxtIsbn.PasswordChar = '\0';
            this.TxtIsbn.PromptText = "ISBN 입력";
            this.TxtIsbn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtIsbn.SelectedText = "";
            this.TxtIsbn.SelectionLength = 0;
            this.TxtIsbn.SelectionStart = 0;
            this.TxtIsbn.ShortcutsEnabled = false;
            this.TxtIsbn.Size = new System.Drawing.Size(214, 29);
            this.TxtIsbn.TabIndex = 6;
            this.TxtIsbn.UseSelectable = true;
            this.TxtIsbn.WaterMark = "ISBN 입력";
            this.TxtIsbn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtIsbn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtNames
            // 
            // 
            // 
            // 
            this.TxtNames.CustomButton.Image = null;
            this.TxtNames.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.TxtNames.CustomButton.Name = "";
            this.TxtNames.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.TxtNames.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtNames.CustomButton.TabIndex = 1;
            this.TxtNames.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtNames.CustomButton.UseSelectable = true;
            this.TxtNames.CustomButton.Visible = false;
            this.TxtNames.Lines = new string[0];
            this.TxtNames.Location = new System.Drawing.Point(123, 125);
            this.TxtNames.MaxLength = 32767;
            this.TxtNames.Name = "TxtNames";
            this.TxtNames.PasswordChar = '\0';
            this.TxtNames.PromptText = "구분명 입력";
            this.TxtNames.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtNames.SelectedText = "";
            this.TxtNames.SelectionLength = 0;
            this.TxtNames.SelectionStart = 0;
            this.TxtNames.ShortcutsEnabled = false;
            this.TxtNames.Size = new System.Drawing.Size(214, 29);
            this.TxtNames.TabIndex = 4;
            this.TxtNames.UseSelectable = true;
            this.TxtNames.WaterMark = "구분명 입력";
            this.TxtNames.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtNames.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(50, 232);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(51, 19);
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = "책가격";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(63, 200);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(38, 19);
            this.metroLabel6.TabIndex = 2;
            this.metroLabel6.Text = "ISBN";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtAuthor
            // 
            // 
            // 
            // 
            this.TxtAuthor.CustomButton.Image = null;
            this.TxtAuthor.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.TxtAuthor.CustomButton.Name = "";
            this.TxtAuthor.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.TxtAuthor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtAuthor.CustomButton.TabIndex = 1;
            this.TxtAuthor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtAuthor.CustomButton.UseSelectable = true;
            this.TxtAuthor.CustomButton.Visible = false;
            this.TxtAuthor.Lines = new string[0];
            this.TxtAuthor.Location = new System.Drawing.Point(123, 55);
            this.TxtAuthor.MaxLength = 32767;
            this.TxtAuthor.Name = "TxtAuthor";
            this.TxtAuthor.PasswordChar = '\0';
            this.TxtAuthor.PromptText = "저자명 입력";
            this.TxtAuthor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtAuthor.SelectedText = "";
            this.TxtAuthor.SelectionLength = 0;
            this.TxtAuthor.SelectionStart = 0;
            this.TxtAuthor.ShortcutsEnabled = false;
            this.TxtAuthor.Size = new System.Drawing.Size(214, 29);
            this.TxtAuthor.TabIndex = 2;
            this.TxtAuthor.UseSelectable = true;
            this.TxtAuthor.WaterMark = "저자명 입력";
            this.TxtAuthor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtAuthor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(50, 130);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(51, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "책제목";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(50, 165);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(51, 19);
            this.metroLabel5.TabIndex = 1;
            this.metroLabel5.Text = "출판일";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtBookIdx
            // 
            // 
            // 
            // 
            this.TxtBookIdx.CustomButton.Image = null;
            this.TxtBookIdx.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.TxtBookIdx.CustomButton.Name = "";
            this.TxtBookIdx.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.TxtBookIdx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBookIdx.CustomButton.TabIndex = 1;
            this.TxtBookIdx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBookIdx.CustomButton.UseSelectable = true;
            this.TxtBookIdx.CustomButton.Visible = false;
            this.TxtBookIdx.Lines = new string[0];
            this.TxtBookIdx.Location = new System.Drawing.Point(123, 22);
            this.TxtBookIdx.MaxLength = 32767;
            this.TxtBookIdx.Name = "TxtBookIdx";
            this.TxtBookIdx.PasswordChar = '\0';
            this.TxtBookIdx.ReadOnly = true;
            this.TxtBookIdx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBookIdx.SelectedText = "";
            this.TxtBookIdx.SelectionLength = 0;
            this.TxtBookIdx.SelectionStart = 0;
            this.TxtBookIdx.ShortcutsEnabled = true;
            this.TxtBookIdx.Size = new System.Drawing.Size(214, 29);
            this.TxtBookIdx.TabIndex = 1;
            this.TxtBookIdx.UseSelectable = true;
            this.TxtBookIdx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBookIdx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(50, 95);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "구분명";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(50, 60);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(51, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "저자명";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(50, 27);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "책순번";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmBookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 391);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("나눔스퀘어_ac Bold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "FrmBookInfo";
            this.Padding = new System.Windows.Forms.Padding(20, 65, 20, 22);
            this.Text = "책정보";
            this.Load += new System.EventHandler(this.FrmLoginUser_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvResult)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView DgvResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox TxtAuthor;
        private MetroFramework.Controls.MetroTextBox TxtBookIdx;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton BtnDel;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroButton BtnNew;
        private MetroFramework.Controls.MetroTextBox TxtIsbn;
        private MetroFramework.Controls.MetroTextBox TxtNames;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox CboDivision;
        private MetroFramework.Controls.MetroDateTime DtpReleaseDate;
        private System.Windows.Forms.NumericUpDown NudPrice;
    }
}