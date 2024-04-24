using System;

namespace hansot_pos
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.NowDate = new System.Windows.Forms.Label();
            this.NowTime = new System.Windows.Forms.Label();
            this.StatBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tablePanel
            // 
            this.tablePanel.ColumnCount = 2;
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanel.Location = new System.Drawing.Point(14, 15);
            this.tablePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.RowCount = 3;
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tablePanel.Size = new System.Drawing.Size(1086, 921);
            this.tablePanel.TabIndex = 0;
            // 
            // NowDate
            // 
            this.NowDate.AutoSize = true;
            this.NowDate.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NowDate.Location = new System.Drawing.Point(1123, 42);
            this.NowDate.Name = "NowDate";
            this.NowDate.Size = new System.Drawing.Size(281, 60);
            this.NowDate.TabIndex = 1;
            this.NowDate.Text = "NowDate";
            // 
            // NowTime
            // 
            this.NowTime.AutoSize = true;
            this.NowTime.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NowTime.Location = new System.Drawing.Point(1123, 111);
            this.NowTime.Name = "NowTime";
            this.NowTime.Size = new System.Drawing.Size(285, 60);
            this.NowTime.TabIndex = 2;
            this.NowTime.Text = "NowTime";
            // 
            // StatBtn
            // 
            this.StatBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.StatBtn.Font = new System.Drawing.Font("굴림", 18F);
            this.StatBtn.Location = new System.Drawing.Point(1115, 554);
            this.StatBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StatBtn.Name = "StatBtn";
            this.StatBtn.Size = new System.Drawing.Size(453, 188);
            this.StatBtn.TabIndex = 4;
            this.StatBtn.Text = "통계";
            this.StatBtn.UseVisualStyleBackColor = false;
            this.StatBtn.Click += new System.EventHandler(this.StatBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ExitBtn.Font = new System.Drawing.Font("굴림", 18F);
            this.ExitBtn.Location = new System.Drawing.Point(1115, 749);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(453, 188);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "종료";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1582, 951);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.StatBtn);
            this.Controls.Add(this.NowTime);
            this.Controls.Add(this.NowDate);
            this.Controls.Add(this.tablePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tablePanel;
        private System.Windows.Forms.Label NowDate;
        private System.Windows.Forms.Label NowTime;
        private System.Windows.Forms.Button StatBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}