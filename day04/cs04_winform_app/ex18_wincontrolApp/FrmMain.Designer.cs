﻿namespace ex18_wincontrolApp
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
            grpFont = new GroupBox();
            TxtSampleText = new TextBox();
            ChkItalic = new CheckBox();
            ChkBold = new CheckBox();
            CboFont = new ComboBox();
            LblFont = new Label();
            GrpBar = new GroupBox();
            PrgDummy = new ProgressBar();
            TrbDummy = new TrackBar();
            GrpForm = new GroupBox();
            BtnQuestion = new Button();
            BtnMsgBox = new Button();
            BtnModaless = new Button();
            BtnModal = new Button();
            GrpTreeList = new GroupBox();
            LsvDummy = new ListView();
            BtnAddChild = new Button();
            BtnAddRoot = new Button();
            TrvDummy = new TreeView();
            groupBox1 = new GroupBox();
            BtnLoad = new Button();
            PicNormal = new PictureBox();
            DlgOpenImage = new OpenFileDialog();
            grpFont.SuspendLayout();
            GrpBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrbDummy).BeginInit();
            GrpForm.SuspendLayout();
            GrpTreeList.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicNormal).BeginInit();
            SuspendLayout();
            // 
            // grpFont
            // 
            grpFont.Controls.Add(TxtSampleText);
            grpFont.Controls.Add(ChkItalic);
            grpFont.Controls.Add(ChkBold);
            grpFont.Controls.Add(CboFont);
            grpFont.Controls.Add(LblFont);
            grpFont.Font = new Font("나눔고딕", 8.999999F);
            grpFont.Location = new Point(10, 10);
            grpFont.Name = "grpFont";
            grpFont.Size = new Size(351, 103);
            grpFont.TabIndex = 0;
            grpFont.TabStop = false;
            grpFont.Text = "ComboBox,CheckBox,TextBox";
            // 
            // TxtSampleText
            // 
            TxtSampleText.Font = new Font("나눔고딕", 8.999999F);
            TxtSampleText.Location = new Point(21, 71);
            TxtSampleText.Name = "TxtSampleText";
            TxtSampleText.Size = new Size(310, 21);
            TxtSampleText.TabIndex = 4;
            TxtSampleText.Text = "Hello C# !";
            // 
            // ChkItalic
            // 
            ChkItalic.AutoSize = true;
            ChkItalic.Font = new Font("맑은 고딕 Semilight", 9F, FontStyle.Italic, GraphicsUnit.Point, 129);
            ChkItalic.Location = new Point(264, 39);
            ChkItalic.Name = "ChkItalic";
            ChkItalic.Size = new Size(62, 19);
            ChkItalic.TabIndex = 3;
            ChkItalic.Text = "이탤릭";
            ChkItalic.UseVisualStyleBackColor = true;
            ChkItalic.CheckedChanged += ChkItalic_CheckedChanged;
            // 
            // ChkBold
            // 
            ChkBold.AutoSize = true;
            ChkBold.Font = new Font("나눔고딕", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 129);
            ChkBold.Location = new Point(206, 39);
            ChkBold.Name = "ChkBold";
            ChkBold.Size = new Size(48, 18);
            ChkBold.TabIndex = 2;
            ChkBold.Text = "굵게";
            ChkBold.TextAlign = ContentAlignment.TopCenter;
            ChkBold.TextImageRelation = TextImageRelation.TextBeforeImage;
            ChkBold.UseVisualStyleBackColor = true;
            ChkBold.CheckedChanged += ChkBold_CheckedChanged;
            // 
            // CboFont
            // 
            CboFont.Font = new Font("나눔고딕", 8.999999F);
            CboFont.FormattingEnabled = true;
            CboFont.Location = new Point(57, 36);
            CboFont.Name = "CboFont";
            CboFont.Size = new Size(143, 22);
            CboFont.TabIndex = 1;
            CboFont.SelectedIndexChanged += CboFont_SelectedIndexChanged;
            // 
            // LblFont
            // 
            LblFont.AutoSize = true;
            LblFont.Font = new Font("나눔고딕", 8.999999F);
            LblFont.Location = new Point(19, 39);
            LblFont.Name = "LblFont";
            LblFont.Size = new Size(31, 14);
            LblFont.TabIndex = 0;
            LblFont.Text = "Font";
            // 
            // GrpBar
            // 
            GrpBar.Controls.Add(PrgDummy);
            GrpBar.Controls.Add(TrbDummy);
            GrpBar.Location = new Point(10, 119);
            GrpBar.Name = "GrpBar";
            GrpBar.Size = new Size(351, 120);
            GrpBar.TabIndex = 1;
            GrpBar.TabStop = false;
            GrpBar.Text = "TrackBar&&ProgressBar";
            // 
            // PrgDummy
            // 
            PrgDummy.Location = new Point(14, 80);
            PrgDummy.Maximum = 20;
            PrgDummy.Name = "PrgDummy";
            PrgDummy.Size = new Size(317, 27);
            PrgDummy.TabIndex = 1;
            // 
            // TrbDummy
            // 
            TrbDummy.Location = new Point(14, 28);
            TrbDummy.Maximum = 20;
            TrbDummy.Name = "TrbDummy";
            TrbDummy.Size = new Size(317, 45);
            TrbDummy.TabIndex = 0;
            TrbDummy.Scroll += TrbDummy_Scroll;
            // 
            // GrpForm
            // 
            GrpForm.Controls.Add(BtnQuestion);
            GrpForm.Controls.Add(BtnMsgBox);
            GrpForm.Controls.Add(BtnModaless);
            GrpForm.Controls.Add(BtnModal);
            GrpForm.Location = new Point(10, 245);
            GrpForm.Name = "GrpForm";
            GrpForm.Size = new Size(351, 73);
            GrpForm.TabIndex = 2;
            GrpForm.TabStop = false;
            GrpForm.Text = "Moda&&Modaless";
            // 
            // BtnQuestion
            // 
            BtnQuestion.Location = new Point(268, 19);
            BtnQuestion.Name = "BtnQuestion";
            BtnQuestion.Size = new Size(75, 36);
            BtnQuestion.TabIndex = 1;
            BtnQuestion.Text = "Question";
            BtnQuestion.UseVisualStyleBackColor = true;
            BtnQuestion.Click += BtnQuestion_Click;
            // 
            // BtnMsgBox
            // 
            BtnMsgBox.Location = new Point(167, 19);
            BtnMsgBox.Name = "BtnMsgBox";
            BtnMsgBox.Size = new Size(94, 36);
            BtnMsgBox.TabIndex = 0;
            BtnMsgBox.Text = "MassageBox";
            BtnMsgBox.UseVisualStyleBackColor = true;
            BtnMsgBox.Click += BtnMsgBox_Click;
            // 
            // BtnModaless
            // 
            BtnModaless.Location = new Point(81, 19);
            BtnModaless.Name = "BtnModaless";
            BtnModaless.Size = new Size(80, 36);
            BtnModaless.TabIndex = 0;
            BtnModaless.Text = "Modaless";
            BtnModaless.UseVisualStyleBackColor = true;
            BtnModaless.Click += BtnModaless_Click;
            // 
            // BtnModal
            // 
            BtnModal.Location = new Point(6, 19);
            BtnModal.Name = "BtnModal";
            BtnModal.Size = new Size(69, 36);
            BtnModal.TabIndex = 0;
            BtnModal.Text = "Modal";
            BtnModal.UseVisualStyleBackColor = true;
            BtnModal.Click += BtnModal_Click;
            // 
            // GrpTreeList
            // 
            GrpTreeList.Controls.Add(LsvDummy);
            GrpTreeList.Controls.Add(BtnAddChild);
            GrpTreeList.Controls.Add(BtnAddRoot);
            GrpTreeList.Controls.Add(TrvDummy);
            GrpTreeList.Location = new Point(8, 319);
            GrpTreeList.Name = "GrpTreeList";
            GrpTreeList.Size = new Size(353, 259);
            GrpTreeList.TabIndex = 3;
            GrpTreeList.TabStop = false;
            GrpTreeList.Text = "TreeView&&ListView";
            // 
            // LsvDummy
            // 
            LsvDummy.Location = new Point(177, 24);
            LsvDummy.Name = "LsvDummy";
            LsvDummy.Size = new Size(168, 195);
            LsvDummy.TabIndex = 2;
            LsvDummy.UseCompatibleStateImageBehavior = false;
            LsvDummy.View = View.Details;
            // 
            // BtnAddChild
            // 
            BtnAddChild.Location = new Point(83, 225);
            BtnAddChild.Name = "BtnAddChild";
            BtnAddChild.Size = new Size(79, 28);
            BtnAddChild.TabIndex = 1;
            BtnAddChild.Text = "Add Child";
            BtnAddChild.UseVisualStyleBackColor = true;
            BtnAddChild.Click += BtnAddChild_Click;
            // 
            // BtnAddRoot
            // 
            BtnAddRoot.Location = new Point(6, 225);
            BtnAddRoot.Name = "BtnAddRoot";
            BtnAddRoot.Size = new Size(71, 28);
            BtnAddRoot.TabIndex = 1;
            BtnAddRoot.Text = "Add Root";
            BtnAddRoot.UseVisualStyleBackColor = true;
            BtnAddRoot.Click += BtnAddRoot_Click;
            // 
            // TrvDummy
            // 
            TrvDummy.Location = new Point(7, 24);
            TrvDummy.Name = "TrvDummy";
            TrvDummy.Size = new Size(168, 195);
            TrvDummy.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnLoad);
            groupBox1.Controls.Add(PicNormal);
            groupBox1.Location = new Point(366, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(470, 568);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "PictureBox";
            // 
            // BtnLoad
            // 
            BtnLoad.Location = new Point(386, 278);
            BtnLoad.Name = "BtnLoad";
            BtnLoad.Size = new Size(78, 30);
            BtnLoad.TabIndex = 1;
            BtnLoad.Text = "Load";
            BtnLoad.UseVisualStyleBackColor = true;
            BtnLoad.Click += BtnLoad_Click;
            // 
            // PicNormal
            // 
            PicNormal.BackColor = Color.FromArgb(255, 192, 255);
            PicNormal.Location = new Point(6, 19);
            PicNormal.Name = "PicNormal";
            PicNormal.Size = new Size(458, 253);
            PicNormal.TabIndex = 0;
            PicNormal.TabStop = false;
            PicNormal.Click += PicNormal_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1300, 584);
            Controls.Add(groupBox1);
            Controls.Add(GrpTreeList);
            Controls.Add(GrpForm);
            Controls.Add(GrpBar);
            Controls.Add(grpFont);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMain";
            Text = "컨트롤 예제";
            FormClosing += FrmMain_FormClosing;
            Load += FrmMain_Load;
            grpFont.ResumeLayout(false);
            grpFont.PerformLayout();
            GrpBar.ResumeLayout(false);
            GrpBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TrbDummy).EndInit();
            GrpForm.ResumeLayout(false);
            GrpTreeList.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicNormal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpFont;
        private TextBox TxtSampleText;
        private CheckBox ChkItalic;
        private CheckBox ChkBold;
        private ComboBox CboFont;
        private Label LblFont;
        private GroupBox GrpBar;
        private ProgressBar PrgDummy;
        private TrackBar TrbDummy;
        private GroupBox GrpForm;
        private Button BtnMsgBox;
        private Button BtnModaless;
        private Button BtnModal;
        private Button BtnQuestion;
        private GroupBox GrpTreeList;
        private ListView LsvDummy;
        private Button BtnAddChild;
        private Button BtnAddRoot;
        private TreeView TrvDummy;
        private GroupBox groupBox1;
        private Button BtnLoad;
        private PictureBox PicNormal;
        private OpenFileDialog DlgOpenImage;
    }
}
