using System.ComponentModel;
using System.Threading;  // ������ Ŭ���� �����

namespace ex18_wincontrolApp
{
    public partial class FrmMain : Form
    {

        #region �޺��ڽ�) ��� ��Ʈ �ҷ����� 
        private void FrmMain_Load(object sender, EventArgs e)
        {
            var Fonts = FontFamily.Families;    // ���� os���� ��ġ�� ��Ʈ�� �� �����Ͷ�
            foreach (var font in Fonts)
            {
                CboFont.Items.Add(font.Name);
            }
        }
        #endregion

        #region üũ�ڽ�) ����ü, ���Ÿ�ü�� �����ϴ� �޼���
        void ChangeFont()
        {
            if (CboFont.SelectedIndex < 0)
                return;

            FontStyle style = FontStyle.Regular;   // ����� ���Ÿ��� �ƴ� ǥ�ر��ڷ� �ʱ�ȭ

            if (ChkBold.Checked)
                style |= FontStyle.Bold;

            if (ChkItalic.Checked)
                style |= FontStyle.Italic;

            TxtSampleText.Font = new Font((string)CboFont.SelectedItem, 12, style);
        }

        private void CboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }
        private void ChkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void ChkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        #endregion

        #region Ʈ����,��ũ��) �ΰ� �����ϴ� �̺�Ʈ �ڵ鷯

        private void TrbDummy_Scroll(object sender, EventArgs e)
        {
            PrgDummy.Value = TrbDummy.Value;
        }
        #endregion

        #region ��ư) �̺�Ʈ �ڵ鷯
        private void BtnModal_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Modal";
            frm.Width = 300;
            frm.Height = 100;
            frm.BackColor = Color.IndianRed;
            frm.Show();   // Modalâ�� ���ϴ�. 
            //����� â ��� �� �ٸ� UI ���� �Ұ� 
        }

        private void BtnModaless_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Modaless";
            frm.Width = 300;
            frm.Height = 300;
            frm.BackColor = Color.BlueViolet;
            frm.ShowDialog();   // Modalessâ�� ���ϴ�.
            //��޸����� â ��� �� �ٸ� UI ���� ���� 
        }

        private void BtnMsgBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TxtSampleText.Text,
                "MessageBox Test", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // OK��ſ� YesNo�� �Ẹ��! 
        }

        private void BtnQuestion_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("�ش����α׷��� ������������?", "����", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // �˾��� ������ ��, �˾�Ÿ��Ʋ�� ��

            if (res == DialogResult.Yes)
            {
                MessageBox.Show("��. �����������ϴ�!");
            }
            else if (res == DialogResult.No)
            {
                MessageBox.Show("�ƴϿ�. �����Դϴ�.");
            }
        }
        #endregion

        #region X�� �ݱ�) ������ �����ư�� Ŭ�������� �߻��ϴ� �̺�Ʈ �ڵ鷯 
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show("�����Ͻðڽ��ϱ�?", "���Ῡ��", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion

        #region Ʈ����,����Ʈ��) �����޴� ����? 
        /*
        public partial class MainForm : Form 
        {   
            Random random = new Random();   
        }
        */
        public FrmMain()
        {
            InitializeComponent();    // �����̳ʿ��� ������ ȭ�鱸�� �ʱ�ȭ 

            LsvDummy.Columns.Add("Name");  // ����Ʈ�� �÷� ���� 
            LsvDummy.Columns.Add("Depth");

        }

        Random rand = new Random();   // Ʈ���� ����̸����� ����� ���� �� 

        void TreeToList()
        {
            LsvDummy.Items.Clear();
            foreach (TreeNode node in TrvDummy.Nodes)
            {
                TreeToList(node);
            }
        }

        private void TreeToList(TreeNode node)
        {
            //throw new NotImplementedException();
            LsvDummy.Items.Add(new ListViewItem(new string[]
            {
                node.Text, node.FullPath.Count(f=> f == '\\').ToString()
            }));

            foreach (TreeNode subnode in node.Nodes)
            {
                TreeToList(subnode);
            }
        }

        private void BtnAddRoot_Click(object sender, EventArgs e)
        {
            TrvDummy.Nodes.Add(rand.Next().ToString());
            TreeToList();
        }

        private void BtnAddChild_Click(object sender, EventArgs e)
        {
            if (TrvDummy.SelectedNode == null)
            {
                MessageBox.Show("���õ� ��尡 �����ϴ�.",
                    "TreeView Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TrvDummy.SelectedNode.Nodes.Add(rand.Next().ToString());
            TrvDummy.SelectedNode.Expand();
            TreeToList();
        }
        #endregion

        #region ����
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            DlgOpenImage.Title = "Open Image";
            DlgOpenImage.Filter = "Image Files(*.bmp;*.jpg;*.png;*.jpeg)|*.bmp;*.jpg;*.png;*.jpeg"; // Filter�� Ȯ���ڸ� �̹����θ� ���� 
            var res = DlgOpenImage.ShowDialog();
            if (res == DialogResult.OK)
            {
                //MessageBox.Show(DlgOpenImage.FileName.ToString());
                PicNormal.Image = Bitmap.FromFile(DlgOpenImage.FileName);
            }
        }
        private void PicNormal_Click(object sender, EventArgs e)
        {
            if (PicNormal.SizeMode == PictureBoxSizeMode.Normal)
            {
                PicNormal.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                PicNormal.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
        #endregion

        #region ������
        /* ���� �ε� �̺�Ʈ �ڵ鷯 */
        private void BtnFileLoad_Click(object sender, EventArgs e)
        {
            // OpenFileDialog ��Ʈ���� �����ο��� �������� �ʰ� �����ϴ� ���
            OpenFileDialog dialog = new OpenFileDialog(); // �����ο��� OpenFileDialog ���� ���ص� OK

            // ������ ������ �����ϴ� �۾� ����!
            // ������ �Ӽ����� Multiselect ����� ������ ���
            dialog.Multiselect = false;
            dialog.Filter = "Text Files(*.txt; *.cs; *.py) | *.txt; *.cs; *.py";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // UTF-8�� ���ڵ� �� ������ �ε��ϸ� �ѱ��� ����
                // EUC-KR(Window 949), UTF-8(BOM)�� ������ ����
                RtxEditor.LoadFile(dialog.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        /* ��ġ �ؽ�Ʈ ���Ϸ� �����ϴ� �̺�Ʈ �ڵ鷯 */
        private void BtnFileSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();

            // rtf�� MS ���忡�� ������ Ȯ����
            dialog.Filter = "RichText Files(*.rtf) | *.rtf";

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                RtxEditor.SaveFile(dialog.FileName, RichTextBoxStreamType.RichNoOleObjs);
            }
        }


        #endregion
        private void BtnNoThread_Click(object sender, EventArgs e)
        {
            // ���α׷����� ����
            var maxValue = 100;
            var currValue = 0;
            PrgProcess.Value = 0; // ���α׷��� ����� 0���� �ʱ�ȭ
            PrgProcess.Minimum = 0;
            PrgProcess.Maximum = maxValue;

            BtnNoThread.Enabled = false;
            BtnNoThread.Enabled = false;
            BtnStop.Enabled = true;

            // �ݺ�����
            for (var i = 0; i <= maxValue; i++)
            {
                // ���������� �����ϰ� �ð��� ���� �ʿ��� �۾�
                currValue = i;
                PrgProcess.Value = currValue;

                // �ؽ�Ʈ �ڽ��� ������ ������� ǥ��
                TxtLog.AppendText($"������ : {currValue}\r\n");
                Thread.Sleep(500); // 1000ms = 1��, 500ms = 0.5��
            }

            // �۾��� �������� ��ư ���� ����
            BtnNoThread.Enabled = BtnNoThread.Enabled = true;
            BtnStop.Enabled = false;

        }

        private void BtnThread_Click(object sender, EventArgs e)
        {
            var maxValue = 100;
            PrgProcess.Value = 0; // ���α׷��� ����� 0���� �ʱ�ȭ
            PrgProcess.Minimum = 0;
            PrgProcess.Maximum = maxValue;

            BtnThread.Enabled = BtnNoThread.Enabled = false;
            BtnStop.Enabled = true;

            BgwProgress.WorkerReportsProgress = true; // ������� ����Ʈ Ȱ��ȭ
            BgwProgress.WorkerSupportsCancellation = true; // ��׶����Ŀ ��� Ȱ��ȭ
            BgwProgress.RunWorkerAsync(null); // ��׶����Ŀ ����!

        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            BgwProgress.CancelAsync(); // �񵿱�� ��ҽ���!
        }

        #region '��׶����Ŀ �̺�Ʈ �ڵ鷯'

        /* ��� �ϸ� ���������� ������� ������ ���α׷� ���� ����� �� */

        private void DoRealWork(BackgroundWorker worker, DoWorkEventArgs e)
        {
            var MaxValue = 100;
            double currValue = 0;

            for (var i = 0; i <= MaxValue; i++)
            {
                if (worker.CancellationPending) // �߰��� ����Ұ��� ����� ����
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    currValue = i;
                    // �ð��� ���� �ɸ��� �۾� ó��
                    Thread.Sleep(500);

                    // ���� ���� ���� �� BgwProgress_ProgressChanged �̺�Ʈ�ڵ鷯����
                    // ProgressChangedEventArgs ���� ProgressPercentage �Ӽ����� ���� ��
                    worker.ReportProgress((int)((currValue / MaxValue) * 100));
                }
            }
        }

        /* ���� ���� */
        private void BgwProgress_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            DoRealWork((BackgroundWorker)sender, e);
            e.Result = null;
        }

        /* ���� ���� ���� ǥ�� */
        private void BgwProgress_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            PrgProcess.Value = e.ProgressPercentage;

            // �ؽ�Ʈ �ڽ��� ������ ������� ǥ��
            TxtLog.AppendText($"����� : {PrgProcess.Value}%\r\n");
        }

        /* ���� ���� �� ó�� */
        private void BgwProgress_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                TxtLog.AppendText("�۾��� ��ҵǾ����ϴ�.\r\n");
            }
            else
            {
                TxtLog.AppendText("�۾��� �Ϸ�Ǿ����ϴ�.\r\n");
            }

            // �۾��� �������� ��ư ���� ����
            BtnNoThread.Enabled = BtnThread.Enabled = true;
            BtnStop.Enabled = false;
        }
        #endregion
    }
}
        #region

        #endregion
