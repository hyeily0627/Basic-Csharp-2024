namespace ex19_asyncs
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            groupBox1 = new GroupBox();
            PrgCancled = new ProgressBar();
            BtnCancel = new Button();
            BtnSyncCopy = new Button();
            BtnAsynCopy = new Button();
            BtbFindTarget = new Button();
            BtbFindSourse = new Button();
            TxtTarget = new TextBox();
            TxtSourse = new TextBox();
            LblTarget = new Label();
            LblSourse = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(PrgCancled);
            groupBox1.Controls.Add(BtnCancel);
            groupBox1.Controls.Add(BtnSyncCopy);
            groupBox1.Controls.Add(BtnAsynCopy);
            groupBox1.Controls.Add(BtbFindTarget);
            groupBox1.Controls.Add(BtbFindSourse);
            groupBox1.Controls.Add(TxtTarget);
            groupBox1.Controls.Add(TxtSourse);
            groupBox1.Controls.Add(LblTarget);
            groupBox1.Controls.Add(LblSourse);
            groupBox1.Location = new Point(6, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(363, 193);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // PrgCancled
            // 
            PrgCancled.Location = new Point(10, 157);
            PrgCancled.Name = "PrgCancled";
            PrgCancled.Size = new Size(345, 23);
            PrgCancled.TabIndex = 5;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(247, 116);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(108, 35);
            BtnCancel.TabIndex = 4;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnSyncCopy
            // 
            BtnSyncCopy.Location = new Point(133, 116);
            BtnSyncCopy.Name = "BtnSyncCopy";
            BtnSyncCopy.Size = new Size(108, 35);
            BtnSyncCopy.TabIndex = 4;
            BtnSyncCopy.Text = "SyncCopy";
            BtnSyncCopy.UseVisualStyleBackColor = true;
            BtnSyncCopy.Click += BtnSyncCopy_Click;
            // 
            // BtnAsynCopy
            // 
            BtnAsynCopy.Location = new Point(10, 116);
            BtnAsynCopy.Name = "BtnAsynCopy";
            BtnAsynCopy.Size = new Size(108, 35);
            BtnAsynCopy.TabIndex = 4;
            BtnAsynCopy.Text = "AsynCopy";
            BtnAsynCopy.UseVisualStyleBackColor = true;
            BtnAsynCopy.Click += BtnAsynCopy_Click;
            // 
            // BtbFindTarget
            // 
            BtbFindTarget.Location = new Point(301, 74);
            BtbFindTarget.Name = "BtbFindTarget";
            BtbFindTarget.Size = new Size(54, 27);
            BtbFindTarget.TabIndex = 3;
            BtbFindTarget.Text = "...";
            BtbFindTarget.UseVisualStyleBackColor = true;
            BtbFindTarget.Click += BtbFindTarget_Click;
            // 
            // BtbFindSourse
            // 
            BtbFindSourse.Location = new Point(301, 28);
            BtbFindSourse.Name = "BtbFindSourse";
            BtbFindSourse.Size = new Size(54, 27);
            BtbFindSourse.TabIndex = 3;
            BtbFindSourse.Text = "...";
            BtbFindSourse.UseVisualStyleBackColor = true;
            BtbFindSourse.Click += BtbFindSourse_Click;
            // 
            // TxtTarget
            // 
            TxtTarget.Enabled = false;
            TxtTarget.Location = new Point(54, 77);
            TxtTarget.Name = "TxtTarget";
            TxtTarget.ReadOnly = true;
            TxtTarget.Size = new Size(241, 21);
            TxtTarget.TabIndex = 2;
            // 
            // TxtSourse
            // 
            TxtSourse.Enabled = false;
            TxtSourse.Location = new Point(54, 32);
            TxtSourse.Name = "TxtSourse";
            TxtSourse.Size = new Size(241, 21);
            TxtSourse.TabIndex = 2;
            // 
            // LblTarget
            // 
            LblTarget.AutoSize = true;
            LblTarget.Location = new Point(10, 77);
            LblTarget.Name = "LblTarget";
            LblTarget.Size = new Size(43, 14);
            LblTarget.TabIndex = 1;
            LblTarget.Text = "Target";
            // 
            // LblSourse
            // 
            LblSourse.AutoSize = true;
            LblSourse.Location = new Point(10, 32);
            LblSourse.Name = "LblSourse";
            LblSourse.Size = new Size(44, 14);
            LblSourse.TabIndex = 0;
            LblSourse.Text = "Sourse";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 195);
            Controls.Add(groupBox1);
            Font = new Font("나눔고딕", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMain";
            Text = "비동기파일복사";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ProgressBar PrgCancled;
        private Button BtnCancel;
        private Button BtnSyncCopy;
        private Button BtnAsynCopy;
        private Button BtbFindTarget;
        private Button BtbFindSourse;
        private TextBox TxtTarget;
        private TextBox TxtSourse;
        private Label LblTarget;
        private Label LblSourse;
    }
}
