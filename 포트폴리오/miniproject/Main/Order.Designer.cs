namespace hansot_pos
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.tableNum = new System.Windows.Forms.Label();
            this.nowDateTIme = new System.Windows.Forms.Label();
            this.OrderedMenuListPanel = new System.Windows.Forms.Panel();
            this.OrderMenuListView = new System.Windows.Forms.ListView();
            this.SelectMenuImagePanel = new System.Windows.Forms.Panel();
            this.SelectedImage = new System.Windows.Forms.PictureBox();
            this.MenuNameTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.SideViewBtn = new System.Windows.Forms.Button();
            this.BowlViewBtn = new System.Windows.Forms.Button();
            this.SqaureViewBtn = new System.Windows.Forms.Button();
            this.PremiumGomeiViewBtn = new System.Windows.Forms.Button();
            this.AllViewBtn = new System.Windows.Forms.Button();
            this.DrinkViewBtn = new System.Windows.Forms.Button();
            this.ButtonTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.AllCancelBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.MinusBtn = new System.Windows.Forms.Button();
            this.PlusBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.PaymentBtn = new System.Windows.Forms.Button();
            this.MenuListTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.MenuTablePanel = new System.Windows.Forms.Panel();
            this.totalPrice = new System.Windows.Forms.Label();
            this.OrderBtn = new System.Windows.Forms.Button();
            this.OrderedMenuListPanel.SuspendLayout();
            this.SelectMenuImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedImage)).BeginInit();
            this.MenuNameTablePanel.SuspendLayout();
            this.ButtonTablePanel.SuspendLayout();
            this.MenuTablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableNum
            // 
            this.tableNum.AutoSize = true;
            this.tableNum.Font = new System.Drawing.Font("Gulim", 20F);
            this.tableNum.Location = new System.Drawing.Point(233, 35);
            this.tableNum.Name = "tableNum";
            this.tableNum.Size = new System.Drawing.Size(129, 27);
            this.tableNum.TabIndex = 0;
            this.tableNum.Text = "tableNum";
            // 
            // nowDateTIme
            // 
            this.nowDateTIme.AutoSize = true;
            this.nowDateTIme.Font = new System.Drawing.Font("Gulim", 20F);
            this.nowDateTIme.Location = new System.Drawing.Point(561, 35);
            this.nowDateTIme.Name = "nowDateTIme";
            this.nowDateTIme.Size = new System.Drawing.Size(182, 27);
            this.nowDateTIme.TabIndex = 1;
            this.nowDateTIme.Text = "nowDateTime";
            // 
            // OrderedMenuListPanel
            // 
            this.OrderedMenuListPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.OrderedMenuListPanel.Controls.Add(this.OrderMenuListView);
            this.OrderedMenuListPanel.Location = new System.Drawing.Point(12, 91);
            this.OrderedMenuListPanel.Name = "OrderedMenuListPanel";
            this.OrderedMenuListPanel.Size = new System.Drawing.Size(650, 350);
            this.OrderedMenuListPanel.TabIndex = 3;
            // 
            // OrderMenuListView
            // 
            this.OrderMenuListView.Font = new System.Drawing.Font("Gulim", 15F);
            this.OrderMenuListView.GridLines = true;
            this.OrderMenuListView.Location = new System.Drawing.Point(3, 3);
            this.OrderMenuListView.Name = "OrderMenuListView";
            this.OrderMenuListView.Size = new System.Drawing.Size(644, 344);
            this.OrderMenuListView.TabIndex = 0;
            this.OrderMenuListView.UseCompatibleStateImageBehavior = false;
            // 
            // SelectMenuImagePanel
            // 
            this.SelectMenuImagePanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SelectMenuImagePanel.Controls.Add(this.SelectedImage);
            this.SelectMenuImagePanel.Location = new System.Drawing.Point(12, 447);
            this.SelectMenuImagePanel.Name = "SelectMenuImagePanel";
            this.SelectMenuImagePanel.Size = new System.Drawing.Size(387, 302);
            this.SelectMenuImagePanel.TabIndex = 4;
            // 
            // SelectedImage
            // 
            this.SelectedImage.Location = new System.Drawing.Point(3, 3);
            this.SelectedImage.Name = "SelectedImage";
            this.SelectedImage.Size = new System.Drawing.Size(381, 296);
            this.SelectedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SelectedImage.TabIndex = 0;
            this.SelectedImage.TabStop = false;
            // 
            // MenuNameTablePanel
            // 
            this.MenuNameTablePanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MenuNameTablePanel.ColumnCount = 6;
            this.MenuNameTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.MenuNameTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.MenuNameTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.MenuNameTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.MenuNameTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.MenuNameTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.MenuNameTablePanel.Controls.Add(this.SideViewBtn, 4, 0);
            this.MenuNameTablePanel.Controls.Add(this.BowlViewBtn, 3, 0);
            this.MenuNameTablePanel.Controls.Add(this.SqaureViewBtn, 2, 0);
            this.MenuNameTablePanel.Controls.Add(this.PremiumGomeiViewBtn, 1, 0);
            this.MenuNameTablePanel.Controls.Add(this.AllViewBtn, 0, 0);
            this.MenuNameTablePanel.Controls.Add(this.DrinkViewBtn, 5, 0);
            this.MenuNameTablePanel.Location = new System.Drawing.Point(668, 91);
            this.MenuNameTablePanel.Name = "MenuNameTablePanel";
            this.MenuNameTablePanel.RowCount = 1;
            this.MenuNameTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MenuNameTablePanel.Size = new System.Drawing.Size(704, 70);
            this.MenuNameTablePanel.TabIndex = 5;
            // 
            // SideViewBtn
            // 
            this.SideViewBtn.Font = new System.Drawing.Font("Gulim", 14F);
            this.SideViewBtn.Location = new System.Drawing.Point(471, 3);
            this.SideViewBtn.Name = "SideViewBtn";
            this.SideViewBtn.Size = new System.Drawing.Size(111, 64);
            this.SideViewBtn.TabIndex = 5;
            this.SideViewBtn.Text = "반찬/\r\n사이드";
            this.SideViewBtn.UseVisualStyleBackColor = true;
            this.SideViewBtn.Click += new System.EventHandler(this.SideViewBtn_Click);
            // 
            // BowlViewBtn
            // 
            this.BowlViewBtn.Font = new System.Drawing.Font("Gulim", 13.5F);
            this.BowlViewBtn.Location = new System.Drawing.Point(354, 3);
            this.BowlViewBtn.Name = "BowlViewBtn";
            this.BowlViewBtn.Size = new System.Drawing.Size(111, 64);
            this.BowlViewBtn.TabIndex = 3;
            this.BowlViewBtn.Text = "보울도시락";
            this.BowlViewBtn.UseVisualStyleBackColor = true;
            this.BowlViewBtn.Click += new System.EventHandler(this.BowlViewBtn_Click);
            // 
            // SqaureViewBtn
            // 
            this.SqaureViewBtn.Font = new System.Drawing.Font("Gulim", 13.5F);
            this.SqaureViewBtn.Location = new System.Drawing.Point(237, 3);
            this.SqaureViewBtn.Name = "SqaureViewBtn";
            this.SqaureViewBtn.Size = new System.Drawing.Size(111, 64);
            this.SqaureViewBtn.TabIndex = 2;
            this.SqaureViewBtn.Text = "사각도시락";
            this.SqaureViewBtn.UseVisualStyleBackColor = true;
            this.SqaureViewBtn.Click += new System.EventHandler(this.SqaureViewBtn_Click);
            // 
            // PremiumGomeiViewBtn
            // 
            this.PremiumGomeiViewBtn.Font = new System.Drawing.Font("Gulim", 14F);
            this.PremiumGomeiViewBtn.Location = new System.Drawing.Point(120, 3);
            this.PremiumGomeiViewBtn.Name = "PremiumGomeiViewBtn";
            this.PremiumGomeiViewBtn.Size = new System.Drawing.Size(111, 64);
            this.PremiumGomeiViewBtn.TabIndex = 1;
            this.PremiumGomeiViewBtn.Text = "프리미엄/고메이";
            this.PremiumGomeiViewBtn.UseVisualStyleBackColor = true;
            this.PremiumGomeiViewBtn.Click += new System.EventHandler(this.PremiumGomeiViewBtn_Click);
            // 
            // AllViewBtn
            // 
            this.AllViewBtn.Font = new System.Drawing.Font("Gulim", 14F);
            this.AllViewBtn.Location = new System.Drawing.Point(3, 3);
            this.AllViewBtn.Name = "AllViewBtn";
            this.AllViewBtn.Size = new System.Drawing.Size(111, 64);
            this.AllViewBtn.TabIndex = 0;
            this.AllViewBtn.Text = "전체보기";
            this.AllViewBtn.UseVisualStyleBackColor = true;
            this.AllViewBtn.Click += new System.EventHandler(this.AllViewBtn_Click);
            // 
            // DrinkViewBtn
            // 
            this.DrinkViewBtn.Font = new System.Drawing.Font("Gulim", 14F);
            this.DrinkViewBtn.Location = new System.Drawing.Point(588, 3);
            this.DrinkViewBtn.Name = "DrinkViewBtn";
            this.DrinkViewBtn.Size = new System.Drawing.Size(113, 64);
            this.DrinkViewBtn.TabIndex = 4;
            this.DrinkViewBtn.Text = "음료";
            this.DrinkViewBtn.UseVisualStyleBackColor = true;
            this.DrinkViewBtn.Click += new System.EventHandler(this.DrinkViewBtn_Click);
            // 
            // ButtonTablePanel
            // 
            this.ButtonTablePanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonTablePanel.ColumnCount = 1;
            this.ButtonTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonTablePanel.Controls.Add(this.AllCancelBtn, 0, 4);
            this.ButtonTablePanel.Controls.Add(this.CancelBtn, 0, 3);
            this.ButtonTablePanel.Controls.Add(this.MinusBtn, 0, 2);
            this.ButtonTablePanel.Controls.Add(this.PlusBtn, 0, 1);
            this.ButtonTablePanel.Controls.Add(this.OrderBtn, 0, 0);
            this.ButtonTablePanel.Location = new System.Drawing.Point(402, 447);
            this.ButtonTablePanel.Name = "ButtonTablePanel";
            this.ButtonTablePanel.RowCount = 5;
            this.ButtonTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonTablePanel.Size = new System.Drawing.Size(260, 302);
            this.ButtonTablePanel.TabIndex = 8;
            // 
            // AllCancelBtn
            // 
            this.AllCancelBtn.Font = new System.Drawing.Font("Gulim", 20F);
            this.AllCancelBtn.Location = new System.Drawing.Point(3, 243);
            this.AllCancelBtn.Name = "AllCancelBtn";
            this.AllCancelBtn.Size = new System.Drawing.Size(254, 56);
            this.AllCancelBtn.TabIndex = 10;
            this.AllCancelBtn.Text = "전체취소";
            this.AllCancelBtn.UseVisualStyleBackColor = true;
            this.AllCancelBtn.Click += new System.EventHandler(this.AllCancelBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Gulim", 20F);
            this.CancelBtn.Location = new System.Drawing.Point(3, 183);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(254, 54);
            this.CancelBtn.TabIndex = 9;
            this.CancelBtn.Text = "취소";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // MinusBtn
            // 
            this.MinusBtn.Font = new System.Drawing.Font("Gulim", 20F);
            this.MinusBtn.Location = new System.Drawing.Point(3, 123);
            this.MinusBtn.Name = "MinusBtn";
            this.MinusBtn.Size = new System.Drawing.Size(254, 54);
            this.MinusBtn.TabIndex = 8;
            this.MinusBtn.Text = "-";
            this.MinusBtn.UseVisualStyleBackColor = true;
            this.MinusBtn.Click += new System.EventHandler(this.MinusBtn_Click);
            // 
            // PlusBtn
            // 
            this.PlusBtn.Font = new System.Drawing.Font("Gulim", 20F);
            this.PlusBtn.Location = new System.Drawing.Point(3, 63);
            this.PlusBtn.Name = "PlusBtn";
            this.PlusBtn.Size = new System.Drawing.Size(254, 54);
            this.PlusBtn.TabIndex = 7;
            this.PlusBtn.Text = "+";
            this.PlusBtn.UseVisualStyleBackColor = true;
            this.PlusBtn.Click += new System.EventHandler(this.PlusBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backBtn.Font = new System.Drawing.Font("Gulim", 20F);
            this.backBtn.Location = new System.Drawing.Point(12, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(215, 73);
            this.backBtn.TabIndex = 2;
            this.backBtn.Text = "뒤로가기";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // PaymentBtn
            // 
            this.PaymentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PaymentBtn.Font = new System.Drawing.Font("Gulim", 20F);
            this.PaymentBtn.Location = new System.Drawing.Point(1157, 12);
            this.PaymentBtn.Name = "PaymentBtn";
            this.PaymentBtn.Size = new System.Drawing.Size(215, 73);
            this.PaymentBtn.TabIndex = 9;
            this.PaymentBtn.Text = "결제하기";
            this.PaymentBtn.UseVisualStyleBackColor = true;
            this.PaymentBtn.Click += new System.EventHandler(this.PaymentBtn_Click);
            // 
            // MenuListTablePanel
            // 
            this.MenuListTablePanel.AutoSize = true;
            this.MenuListTablePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MenuListTablePanel.ColumnCount = 2;
            this.MenuListTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MenuListTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MenuListTablePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuListTablePanel.Location = new System.Drawing.Point(0, 0);
            this.MenuListTablePanel.Name = "MenuListTablePanel";
            this.MenuListTablePanel.RowCount = 2;
            this.MenuListTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MenuListTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MenuListTablePanel.Size = new System.Drawing.Size(701, 0);
            this.MenuListTablePanel.TabIndex = 10;
            // 
            // MenuTablePanel
            // 
            this.MenuTablePanel.AutoScroll = true;
            this.MenuTablePanel.Controls.Add(this.MenuListTablePanel);
            this.MenuTablePanel.Location = new System.Drawing.Point(668, 167);
            this.MenuTablePanel.Name = "MenuTablePanel";
            this.MenuTablePanel.Size = new System.Drawing.Size(701, 582);
            this.MenuTablePanel.TabIndex = 11;
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSize = true;
            this.totalPrice.Font = new System.Drawing.Font("Gulim", 20F);
            this.totalPrice.Location = new System.Drawing.Point(900, 35);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(128, 27);
            this.totalPrice.TabIndex = 12;
            this.totalPrice.Text = "totalPrice";
            // 
            // OrderBtn
            // 
            this.OrderBtn.Font = new System.Drawing.Font("Gulim", 20F);
            this.OrderBtn.Location = new System.Drawing.Point(3, 3);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.Size = new System.Drawing.Size(254, 54);
            this.OrderBtn.TabIndex = 11;
            this.OrderBtn.Text = "주문하기";
            this.OrderBtn.UseVisualStyleBackColor = true;
            this.OrderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.MenuTablePanel);
            this.Controls.Add(this.PaymentBtn);
            this.Controls.Add(this.ButtonTablePanel);
            this.Controls.Add(this.MenuNameTablePanel);
            this.Controls.Add(this.SelectMenuImagePanel);
            this.Controls.Add(this.OrderedMenuListPanel);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.nowDateTIme);
            this.Controls.Add(this.tableNum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.OrderedMenuListPanel.ResumeLayout(false);
            this.SelectMenuImagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SelectedImage)).EndInit();
            this.MenuNameTablePanel.ResumeLayout(false);
            this.ButtonTablePanel.ResumeLayout(false);
            this.MenuTablePanel.ResumeLayout(false);
            this.MenuTablePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tableNum;
        private System.Windows.Forms.Label nowDateTIme;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel OrderedMenuListPanel;
        private System.Windows.Forms.Panel SelectMenuImagePanel;
        private System.Windows.Forms.TableLayoutPanel MenuNameTablePanel;
        private System.Windows.Forms.Button PlusBtn;
        private System.Windows.Forms.TableLayoutPanel ButtonTablePanel;
        private System.Windows.Forms.Button AllCancelBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button MinusBtn;
        private System.Windows.Forms.ListView OrderMenuListView;
        private System.Windows.Forms.Button BowlViewBtn;
        private System.Windows.Forms.Button SqaureViewBtn;
        private System.Windows.Forms.Button PremiumGomeiViewBtn;
        private System.Windows.Forms.Button AllViewBtn;
        private System.Windows.Forms.Button DrinkViewBtn;
        private System.Windows.Forms.Button PaymentBtn;
        private System.Windows.Forms.TableLayoutPanel MenuListTablePanel;
        private System.Windows.Forms.Button SideViewBtn;
        private System.Windows.Forms.PictureBox SelectedImage;
        private System.Windows.Forms.Panel MenuTablePanel;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.Button OrderBtn;
    }
}