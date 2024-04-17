namespace ex19_asyncs
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        #region 이벤트 핸들러 영역 
        // 복사할 원본 파일 선택 
        private void BtbFindSourse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TxtSourse.Text = dlg.FileName;
            }
        }

        // 붙여넣기할 타겟 파일 지정
        private void BtbFindTarget_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TxtTarget.Text = dlg.FileName;
            }
        }

        // 동기화 복사
        private async void BtnAsynCopy_Click(object sender, EventArgs e)
        {
            long result = CopySync(TxtSourse.Text, TxtTarget.Text);
        }

        // 비동기화 복사
        private async void BtnSyncCopy_Click(object sender, EventArgs e)
        {
            long result = await CopyAsync(TxtSourse.Text,TxtTarget.Text);
        }

        // 복사취소 처리 
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UI반응테스트 성공!");
        }
        #endregion


        #region 추가 메서드 (사용자 메서드 영역)
        long CopySync(string srcPath, string destPath)
        {
            // 버튼사용 비확성화 
            BtnSyncCopy.Enabled = BtnAsynCopy.Enabled = false;
            long totalCopied = 0;

            // 파일은 오픈하면 반드시 클로즈 해야함
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
                        // 프로그레스바에 진행사항을 표시 
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
