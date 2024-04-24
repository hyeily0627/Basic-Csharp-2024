namespace hansot_pos
{
    partial class MenuListCtrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuImage = new System.Windows.Forms.PictureBox();
            this.MenuNamePanel = new System.Windows.Forms.Panel();
            this.MenuNameLabel = new System.Windows.Forms.Label();
            this.MenuPricePanel = new System.Windows.Forms.Panel();
            this.MenuPriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MenuImage)).BeginInit();
            this.MenuNamePanel.SuspendLayout();
            this.MenuPricePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuImage
            // 
            this.MenuImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuImage.Location = new System.Drawing.Point(0, 0);
            this.MenuImage.Name = "MenuImage";
            this.MenuImage.Size = new System.Drawing.Size(338, 187);
            this.MenuImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuImage.TabIndex = 0;
            this.MenuImage.TabStop = false;
            this.MenuImage.Click += new System.EventHandler(this.MenuImage_Click);
            // 
            // MenuNamePanel
            // 
            this.MenuNamePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MenuNamePanel.Controls.Add(this.MenuNameLabel);
            this.MenuNamePanel.Location = new System.Drawing.Point(3, 3);
            this.MenuNamePanel.Name = "MenuNamePanel";
            this.MenuNamePanel.Size = new System.Drawing.Size(215, 40);
            this.MenuNamePanel.TabIndex = 1;
            // 
            // MenuNameLabel
            // 
            this.MenuNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuNameLabel.Font = new System.Drawing.Font("Gulim", 11F);
            this.MenuNameLabel.Location = new System.Drawing.Point(0, 0);
            this.MenuNameLabel.Name = "MenuNameLabel";
            this.MenuNameLabel.Size = new System.Drawing.Size(215, 40);
            this.MenuNameLabel.TabIndex = 0;
            this.MenuNameLabel.Text = "MenuName";
            this.MenuNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuPricePanel
            // 
            this.MenuPricePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MenuPricePanel.Controls.Add(this.MenuPriceLabel);
            this.MenuPricePanel.Location = new System.Drawing.Point(230, 144);
            this.MenuPricePanel.Name = "MenuPricePanel";
            this.MenuPricePanel.Size = new System.Drawing.Size(105, 40);
            this.MenuPricePanel.TabIndex = 2;
            // 
            // MenuPriceLabel
            // 
            this.MenuPriceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuPriceLabel.Font = new System.Drawing.Font("Gulim", 13F);
            this.MenuPriceLabel.Location = new System.Drawing.Point(0, 0);
            this.MenuPriceLabel.Name = "MenuPriceLabel";
            this.MenuPriceLabel.Size = new System.Drawing.Size(105, 40);
            this.MenuPriceLabel.TabIndex = 0;
            this.MenuPriceLabel.Text = "MenuPrice";
            this.MenuPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuListCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.MenuPricePanel);
            this.Controls.Add(this.MenuNamePanel);
            this.Controls.Add(this.MenuImage);
            this.Name = "MenuListCtrl";
            this.Size = new System.Drawing.Size(338, 187);
            ((System.ComponentModel.ISupportInitialize)(this.MenuImage)).EndInit();
            this.MenuNamePanel.ResumeLayout(false);
            this.MenuPricePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MenuImage;
        private System.Windows.Forms.Panel MenuNamePanel;
        private System.Windows.Forms.Label MenuNameLabel;
        private System.Windows.Forms.Panel MenuPricePanel;
        private System.Windows.Forms.Label MenuPriceLabel;
    }
}
