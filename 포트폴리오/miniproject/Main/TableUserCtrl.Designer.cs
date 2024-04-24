namespace hansot_pos
{
    partial class TableUserCtrl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.TableNumber = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.menuListBox = new System.Windows.Forms.ListBox();
            this.panel2.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.TableNumber);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 40);
            this.panel2.TabIndex = 0;
            this.panel2.Click += new System.EventHandler(this.Clicked);
            // 
            // TableNumber
            // 
            this.TableNumber.AutoSize = true;
            this.TableNumber.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TableNumber.Location = new System.Drawing.Point(185, 9);
            this.TableNumber.Name = "TableNumber";
            this.TableNumber.Size = new System.Drawing.Size(130, 21);
            this.TableNumber.TabIndex = 0;
            this.TableNumber.Text = "TableNumber";
            this.TableNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TableNumber.Click += new System.EventHandler(this.Clicked);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.menuListBox);
            this.panel.Controls.Add(this.panel2);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(470, 240);
            this.panel.TabIndex = 0;
            this.panel.Click += new System.EventHandler(this.Clicked);
            // 
            // menuListBox
            // 
            this.menuListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.menuListBox.Font = new System.Drawing.Font("Gulim", 12F);
            this.menuListBox.FormattingEnabled = true;
            this.menuListBox.ItemHeight = 16;
            this.menuListBox.Location = new System.Drawing.Point(14, 65);
            this.menuListBox.Name = "menuListBox";
            this.menuListBox.Size = new System.Drawing.Size(443, 160);
            this.menuListBox.TabIndex = 1;
            this.menuListBox.Click += new System.EventHandler(this.Clicked);
            // 
            // TableUserCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Name = "TableUserCtrl";
            this.Size = new System.Drawing.Size(470, 240);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TableNumber;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ListBox menuListBox;
    }
}
