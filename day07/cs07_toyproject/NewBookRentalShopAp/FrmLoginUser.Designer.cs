namespace NewBookRentalShopApp
{
    partial class FrmLoginUser
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
            this.BtnDel = new MetroFramework.Controls.MetroButton();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.BtnNew = new MetroFramework.Controls.MetroButton();
            this.TxtPassword = new MetroFramework.Controls.MetroTextBox();
            this.TxtUserId = new MetroFramework.Controls.MetroTextBox();
            this.TxtUserNumber = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvResult)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.splitContainer1.Size = new System.Drawing.Size(715, 233);
            this.splitContainer1.SplitterDistance = 335;
            this.splitContainer1.TabIndex = 0;
            // 
            // DgvResult
            // 
            this.DgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvResult.Location = new System.Drawing.Point(0, 0);
            this.DgvResult.Name = "DgvResult";
            this.DgvResult.RowTemplate.Height = 23;
            this.DgvResult.Size = new System.Drawing.Size(335, 233);
            this.DgvResult.TabIndex = 0;
            this.DgvResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvResult_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnDel);
            this.groupBox1.Controls.Add(this.BtnSave);
            this.groupBox1.Controls.Add(this.BtnNew);
            this.groupBox1.Controls.Add(this.TxtPassword);
            this.groupBox1.Controls.Add(this.TxtUserId);
            this.groupBox1.Controls.Add(this.TxtUserNumber);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "로그인사용자 입력항목";
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(248, 152);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(91, 21);
            this.BtnDel.TabIndex = 6;
            this.BtnDel.Text = "삭제";
            this.BtnDel.UseSelectable = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(138, 152);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(91, 21);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseSelectable = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(27, 152);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(91, 21);
            this.BtnNew.TabIndex = 6;
            this.BtnNew.Text = "신규";
            this.BtnNew.UseSelectable = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // TxtPassword
            // 
            // 
            // 
            // 
            this.TxtPassword.CustomButton.Image = null;
            this.TxtPassword.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.TxtPassword.CustomButton.Name = "";
            this.TxtPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TxtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPassword.CustomButton.TabIndex = 1;
            this.TxtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPassword.CustomButton.UseSelectable = true;
            this.TxtPassword.CustomButton.Visible = false;
            this.TxtPassword.Lines = new string[0];
            this.TxtPassword.Location = new System.Drawing.Point(125, 116);
            this.TxtPassword.MaxLength = 32767;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '●';
            this.TxtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPassword.SelectedText = "";
            this.TxtPassword.SelectionLength = 0;
            this.TxtPassword.SelectionStart = 0;
            this.TxtPassword.ShortcutsEnabled = false;
            this.TxtPassword.Size = new System.Drawing.Size(214, 25);
            this.TxtPassword.TabIndex = 5;
            this.TxtPassword.UseSelectable = true;
            this.TxtPassword.WaterMark = "패스워드 입력";
            this.TxtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtUserId
            // 
            // 
            // 
            // 
            this.TxtUserId.CustomButton.Image = null;
            this.TxtUserId.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.TxtUserId.CustomButton.Name = "";
            this.TxtUserId.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TxtUserId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtUserId.CustomButton.TabIndex = 1;
            this.TxtUserId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtUserId.CustomButton.UseSelectable = true;
            this.TxtUserId.CustomButton.Visible = false;
            this.TxtUserId.Lines = new string[0];
            this.TxtUserId.Location = new System.Drawing.Point(125, 83);
            this.TxtUserId.MaxLength = 32767;
            this.TxtUserId.Name = "TxtUserId";
            this.TxtUserId.PasswordChar = '\0';
            this.TxtUserId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtUserId.SelectedText = "";
            this.TxtUserId.SelectionLength = 0;
            this.TxtUserId.SelectionStart = 0;
            this.TxtUserId.ShortcutsEnabled = true;
            this.TxtUserId.Size = new System.Drawing.Size(214, 25);
            this.TxtUserId.TabIndex = 4;
            this.TxtUserId.UseSelectable = true;
            this.TxtUserId.WaterMark = "사용자아이디 입력";
            this.TxtUserId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtUserId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtUserNumber
            // 
            // 
            // 
            // 
            this.TxtUserNumber.CustomButton.Image = null;
            this.TxtUserNumber.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.TxtUserNumber.CustomButton.Name = "";
            this.TxtUserNumber.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TxtUserNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtUserNumber.CustomButton.TabIndex = 1;
            this.TxtUserNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtUserNumber.CustomButton.UseSelectable = true;
            this.TxtUserNumber.CustomButton.Visible = false;
            this.TxtUserNumber.Lines = new string[0];
            this.TxtUserNumber.Location = new System.Drawing.Point(125, 52);
            this.TxtUserNumber.MaxLength = 32767;
            this.TxtUserNumber.Name = "TxtUserNumber";
            this.TxtUserNumber.PasswordChar = '\0';
            this.TxtUserNumber.ReadOnly = true;
            this.TxtUserNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtUserNumber.SelectedText = "";
            this.TxtUserNumber.SelectionLength = 0;
            this.TxtUserNumber.SelectionStart = 0;
            this.TxtUserNumber.ShortcutsEnabled = true;
            this.TxtUserNumber.Size = new System.Drawing.Size(214, 25);
            this.TxtUserNumber.TabIndex = 3;
            this.TxtUserNumber.UseSelectable = true;
            this.TxtUserNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtUserNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.Location = new System.Drawing.Point(45, 120);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(55, 15);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "패스워드";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.Location = new System.Drawing.Point(13, 87);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(82, 15);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "사용자 아이디";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(27, 56);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(70, 15);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "사용자 순번";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmLoginUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 320);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("나눔스퀘어_ac Bold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "FrmLoginUser";
            this.Padding = new System.Windows.Forms.Padding(20, 65, 20, 22);
            this.Text = "로그인사용자";
            this.Load += new System.EventHandler(this.FrmLoginUser_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvResult)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView DgvResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox TxtPassword;
        private MetroFramework.Controls.MetroTextBox TxtUserId;
        private MetroFramework.Controls.MetroTextBox TxtUserNumber;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton BtnDel;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroButton BtnNew;
    }
}