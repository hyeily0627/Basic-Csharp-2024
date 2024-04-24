namespace hansot_pos
{
    partial class Stat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stat));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CgTotalPrice = new System.Windows.Forms.Label();
            this.CgTotalSales = new System.Windows.Forms.Label();
            this.lbCgTotalSales = new System.Windows.Forms.Label();
            this.lbCgTotalPrice = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MnTotalSales = new System.Windows.Forms.Label();
            this.MnTotalPrice = new System.Windows.Forms.Label();
            this.lbMnTotalSales = new System.Windows.Forms.Label();
            this.lbMnTotalPrice = new System.Windows.Forms.Label();
            this.lbMenu = new System.Windows.Forms.Label();
            this.menuComboBox = new System.Windows.Forms.ComboBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.CgTotalPrice);
            this.panel1.Controls.Add(this.CgTotalSales);
            this.panel1.Controls.Add(this.lbCgTotalSales);
            this.panel1.Controls.Add(this.lbCgTotalPrice);
            this.panel1.Controls.Add(this.lbCategory);
            this.panel1.Controls.Add(this.categoryComboBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 550);
            this.panel1.TabIndex = 0;
            // 
            // CgTotalPrice
            // 
            this.CgTotalPrice.AutoSize = true;
            this.CgTotalPrice.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.CgTotalPrice.Location = new System.Drawing.Point(292, 423);
            this.CgTotalPrice.Name = "CgTotalPrice";
            this.CgTotalPrice.Size = new System.Drawing.Size(77, 27);
            this.CgTotalPrice.TabIndex = 5;
            this.CgTotalPrice.Text = " 0 원";
            this.CgTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CgTotalSales
            // 
            this.CgTotalSales.AutoSize = true;
            this.CgTotalSales.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.CgTotalSales.Location = new System.Drawing.Point(292, 289);
            this.CgTotalSales.Name = "CgTotalSales";
            this.CgTotalSales.Size = new System.Drawing.Size(77, 27);
            this.CgTotalSales.TabIndex = 7;
            this.CgTotalSales.Text = " 0 개";
            // 
            // lbCgTotalSales
            // 
            this.lbCgTotalSales.AutoSize = true;
            this.lbCgTotalSales.Font = new System.Drawing.Font("굴림", 16F);
            this.lbCgTotalSales.Location = new System.Drawing.Point(42, 216);
            this.lbCgTotalSales.Name = "lbCgTotalSales";
            this.lbCgTotalSales.Size = new System.Drawing.Size(76, 22);
            this.lbCgTotalSales.TabIndex = 4;
            this.lbCgTotalSales.Text = "판매량";
            // 
            // lbCgTotalPrice
            // 
            this.lbCgTotalPrice.AutoSize = true;
            this.lbCgTotalPrice.Font = new System.Drawing.Font("굴림", 16F);
            this.lbCgTotalPrice.Location = new System.Drawing.Point(42, 367);
            this.lbCgTotalPrice.Name = "lbCgTotalPrice";
            this.lbCgTotalPrice.Size = new System.Drawing.Size(76, 22);
            this.lbCgTotalPrice.TabIndex = 3;
            this.lbCgTotalPrice.Text = "매출액";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.lbCategory.Location = new System.Drawing.Point(170, 30);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(93, 20);
            this.lbCategory.TabIndex = 2;
            this.lbCategory.Text = "Category";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Font = new System.Drawing.Font("굴림", 12F);
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(147, 83);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(140, 24);
            this.categoryComboBox.TabIndex = 1;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryCB_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.MnTotalSales);
            this.panel2.Controls.Add(this.MnTotalPrice);
            this.panel2.Controls.Add(this.lbMnTotalSales);
            this.panel2.Controls.Add(this.lbMnTotalPrice);
            this.panel2.Controls.Add(this.lbMenu);
            this.panel2.Controls.Add(this.menuComboBox);
            this.panel2.Location = new System.Drawing.Point(468, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 550);
            this.panel2.TabIndex = 1;
            // 
            // MnTotalSales
            // 
            this.MnTotalSales.AutoSize = true;
            this.MnTotalSales.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.MnTotalSales.Location = new System.Drawing.Point(302, 289);
            this.MnTotalSales.Name = "MnTotalSales";
            this.MnTotalSales.Size = new System.Drawing.Size(77, 27);
            this.MnTotalSales.TabIndex = 7;
            this.MnTotalSales.Text = " 0 개";
            // 
            // MnTotalPrice
            // 
            this.MnTotalPrice.AutoSize = true;
            this.MnTotalPrice.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.MnTotalPrice.Location = new System.Drawing.Point(302, 423);
            this.MnTotalPrice.Name = "MnTotalPrice";
            this.MnTotalPrice.Size = new System.Drawing.Size(77, 27);
            this.MnTotalPrice.TabIndex = 6;
            this.MnTotalPrice.Text = " 0 원";
            this.MnTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMnTotalSales
            // 
            this.lbMnTotalSales.AutoSize = true;
            this.lbMnTotalSales.Font = new System.Drawing.Font("굴림", 16F);
            this.lbMnTotalSales.Location = new System.Drawing.Point(42, 216);
            this.lbMnTotalSales.Name = "lbMnTotalSales";
            this.lbMnTotalSales.Size = new System.Drawing.Size(76, 22);
            this.lbMnTotalSales.TabIndex = 6;
            this.lbMnTotalSales.Text = "판매량";
            // 
            // lbMnTotalPrice
            // 
            this.lbMnTotalPrice.AutoSize = true;
            this.lbMnTotalPrice.Font = new System.Drawing.Font("굴림", 16F);
            this.lbMnTotalPrice.Location = new System.Drawing.Point(51, 367);
            this.lbMnTotalPrice.Name = "lbMnTotalPrice";
            this.lbMnTotalPrice.Size = new System.Drawing.Size(76, 22);
            this.lbMnTotalPrice.TabIndex = 5;
            this.lbMnTotalPrice.Text = "매출액";
            // 
            // lbMenu
            // 
            this.lbMenu.AutoSize = true;
            this.lbMenu.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.lbMenu.Location = new System.Drawing.Point(201, 30);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(59, 20);
            this.lbMenu.TabIndex = 3;
            this.lbMenu.Text = "Menu";
            // 
            // menuComboBox
            // 
            this.menuComboBox.Font = new System.Drawing.Font("굴림", 12F);
            this.menuComboBox.FormattingEnabled = true;
            this.menuComboBox.Location = new System.Drawing.Point(144, 83);
            this.menuComboBox.Name = "menuComboBox";
            this.menuComboBox.Size = new System.Drawing.Size(180, 24);
            this.menuComboBox.TabIndex = 2;
            this.menuComboBox.SelectedIndexChanged += new System.EventHandler(this.menuCB_SelectedIndexChanged);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("굴림", 20F);
            this.backBtn.Location = new System.Drawing.Point(924, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(220, 550);
            this.backBtn.TabIndex = 2;
            this.backBtn.Text = "뒤로가기";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Stat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1156, 574);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "statistics";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox menuComboBox;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label lbMenu;
        private System.Windows.Forms.Label lbCgTotalPrice;
        private System.Windows.Forms.Label lbCgTotalSales;
        private System.Windows.Forms.Label lbMnTotalSales;
        private System.Windows.Forms.Label lbMnTotalPrice;
        private System.Windows.Forms.Label CgTotalPrice;
        private System.Windows.Forms.Label CgTotalSales;
        private System.Windows.Forms.Label MnTotalSales;
        private System.Windows.Forms.Label MnTotalPrice;
    }
}