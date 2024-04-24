namespace hansot_pos
{
    partial class Payment
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
            this.OrderedMenuListBox = new System.Windows.Forms.ListBox();
            this.PayBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.CashRadioBtn = new System.Windows.Forms.RadioButton();
            this.CardRadioBtn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // OrderedMenuListBox
            // 
            this.OrderedMenuListBox.FormattingEnabled = true;
            this.OrderedMenuListBox.ItemHeight = 12;
            this.OrderedMenuListBox.Location = new System.Drawing.Point(12, 12);
            this.OrderedMenuListBox.Name = "OrderedMenuListBox";
            this.OrderedMenuListBox.Size = new System.Drawing.Size(450, 424);
            this.OrderedMenuListBox.TabIndex = 0;
            // 
            // PayBtn
            // 
            this.PayBtn.Font = new System.Drawing.Font("굴림", 20F);
            this.PayBtn.Location = new System.Drawing.Point(468, 376);
            this.PayBtn.Name = "PayBtn";
            this.PayBtn.Size = new System.Drawing.Size(157, 60);
            this.PayBtn.TabIndex = 1;
            this.PayBtn.Text = "결제";
            this.PayBtn.UseVisualStyleBackColor = true;
            this.PayBtn.Click += new System.EventHandler(this.PayBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("굴림", 20F);
            this.CancelBtn.Location = new System.Drawing.Point(631, 376);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(157, 60);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "취소";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // CashRadioBtn
            // 
            this.CashRadioBtn.AutoSize = true;
            this.CashRadioBtn.Font = new System.Drawing.Font("굴림", 20F);
            this.CashRadioBtn.Location = new System.Drawing.Point(585, 243);
            this.CashRadioBtn.Name = "CashRadioBtn";
            this.CashRadioBtn.Size = new System.Drawing.Size(84, 31);
            this.CashRadioBtn.TabIndex = 3;
            this.CashRadioBtn.TabStop = true;
            this.CashRadioBtn.Text = "현금";
            this.CashRadioBtn.UseVisualStyleBackColor = true;
            // 
            // CardRadioBtn
            // 
            this.CardRadioBtn.AutoSize = true;
            this.CardRadioBtn.Font = new System.Drawing.Font("굴림", 20F);
            this.CardRadioBtn.Location = new System.Drawing.Point(585, 299);
            this.CardRadioBtn.Name = "CardRadioBtn";
            this.CardRadioBtn.Size = new System.Drawing.Size(84, 31);
            this.CardRadioBtn.TabIndex = 4;
            this.CardRadioBtn.TabStop = true;
            this.CardRadioBtn.Text = "카드";
            this.CardRadioBtn.UseVisualStyleBackColor = true;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CardRadioBtn);
            this.Controls.Add(this.CashRadioBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.PayBtn);
            this.Controls.Add(this.OrderedMenuListBox);
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox OrderedMenuListBox;
        private System.Windows.Forms.Button PayBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.RadioButton CashRadioBtn;
        private System.Windows.Forms.RadioButton CardRadioBtn;
    }
}