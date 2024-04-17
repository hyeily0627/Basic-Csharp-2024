namespace ex19_asyncs
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        #region �̺�Ʈ �ڵ鷯 ���� 
        // ������ ���� ���� ���� 
        private void BtbFindSourse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TxtSourse.Text = dlg.FileName;
            }
        }

        // �ٿ��ֱ��� Ÿ�� ���� ����
        private void BtbFindTarget_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TxtTarget.Text = dlg.FileName;
            }
        }

        // ����ȭ ����
        private async void BtnAsynCopy_Click(object sender, EventArgs e)
        {
            long result = CopySync(TxtSourse.Text, TxtTarget.Text);
        }

        // �񵿱�ȭ ����
        private async void BtnSyncCopy_Click(object sender, EventArgs e)
        {
            long result = await CopyAsync(TxtSourse.Text,TxtTarget.Text);
        }

        // ������� ó�� 
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UI�����׽�Ʈ ����!");
        }
        #endregion


        #region �߰� �޼��� (����� �޼��� ����)
        long CopySync(string srcPath, string destPath)
        {
            // ��ư��� ��Ȯ��ȭ 
            BtnSyncCopy.Enabled = BtnAsynCopy.Enabled = false;
            long totalCopied = 0;

            // ������ �����ϸ� �ݵ�� Ŭ���� �ؾ���
            using (FileStream fromStream = new FileStream(srcPath, FileMode.Open))
            {
                using (FileStream toStream = new FileStream(destPath, FileMode.Create))
                {
                    byte[] buffer = new byte[1024 * 1024];
                    int nRead = 0;
                    while((nRead=fromStream.Read(buffer, 0, buffer.Length)) != 0) 
                    {
                        toStream.Write(buffer, 0, nRead);
                        totalCopied += nRead;
                        // ���α׷����ٿ� ��������� ǥ�� 
                        PrgCancled.Value = (int)((double)(totalCopied / fromStream.Length) * 100);
                    }
                } 
            }
            BtnSyncCopy.Enabled = BtnAsynCopy.Enabled = true;
            return totalCopied;
        }
        async Task<long>CopyAsync(string srcPath, string destPath)
        {
            BtnSyncCopy.Enabled = false;
            BtnAsynCopy.Enabled = false;

            long totalCopied = 0;
            using(FileStream fromstream = new FileStream(srcPath,FileMode.Open))
            {
                using (FileStream tostream = new FileStream(destPath, FileMode.Create))
                {
                    byte[] buffer = new byte[1024 * 1024];
                    int nRead = 0;
                    while ((nRead = await fromstream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                    {
                        await tostream.WriteAsync(buffer, 0, nRead);
                        totalCopied += nRead;
                        PrgCancled.Value = (int)((double)(totalCopied/fromstream.Length)*100);
                    }
                }
            }
            BtnSyncCopy.Enabled = BtnAsynCopy.Enabled = true;
            return totalCopied;
        }

        #endregion
    }
}
