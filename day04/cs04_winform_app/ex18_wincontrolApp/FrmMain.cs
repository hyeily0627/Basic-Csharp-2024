using System.ComponentModel;
using System.Threading;  // 스레드 클래스 사용등록

namespace ex18_wincontrolApp
{
    public partial class FrmMain : Form
    {

        #region 콤보박스) 모든 폰트 불러오기 
        private void FrmMain_Load(object sender, EventArgs e)
        {
            var Fonts = FontFamily.Families;    // 현재 os내에 설치된 폰트를 다 가져와라
            foreach (var font in Fonts)
            {
                CboFont.Items.Add(font.Name);
            }
        }
        #endregion

        #region 체크박스) 볼드체, 이탤릭체로 변경하는 메서드
        void ChangeFont()
        {
            if (CboFont.SelectedIndex < 0)
                return;

            FontStyle style = FontStyle.Regular;   // 볼드와 이탤릭이 아닌 표준글자로 초기화

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

        #region 트랙바,스크롤) 두개 연동하는 이벤트 핸들러

        private void TrbDummy_Scroll(object sender, EventArgs e)
        {
            PrgDummy.Value = TrbDummy.Value;
        }
        #endregion

        #region 버튼) 이벤트 핸들러
        private void BtnModal_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Modal";
            frm.Width = 300;
            frm.Height = 100;
            frm.BackColor = Color.IndianRed;
            frm.Show();   // Modal창을 띄웁니다. 
            //모달은 창 띄운 후 다른 UI 선택 불가 
        }

        private void BtnModaless_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Modaless";
            frm.Width = 300;
            frm.Height = 300;
            frm.BackColor = Color.BlueViolet;
            frm.ShowDialog();   // Modaless창을 띄웁니다.
            //모달리스는 창 띄운 후 다른 UI 선택 가능 
        }

        private void BtnMsgBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TxtSampleText.Text,
                "MessageBox Test", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // OK대신에 YesNo도 써보기! 
        }

        private void BtnQuestion_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("해당프로그램이 만족스럽나요?", "질문", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // 팝업의 내용이 앞, 팝업타이틀이 뒤

            if (res == DialogResult.Yes)
            {
                MessageBox.Show("네. 만족스럽습니다!");
            }
            else if (res == DialogResult.No)
            {
                MessageBox.Show("아니요. 별로입니다.");
            }
        }
        #endregion

        #region X로 닫기) 윈도우 종료버튼을 클릭했을때 발생하는 이벤트 핸들러 
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show("종료하시겠습니까?", "종료여부", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion

        #region 트리뷰,리스트뷰) 하위메뉴 생성? 
        /*
        public partial class MainForm : Form 
        {   
            Random random = new Random();   
        }
        */
        public FrmMain()
        {
            InitializeComponent();    // 디자이너에서 정의한 화면구성 초기화 

            LsvDummy.Columns.Add("Name");  // 리스트뷰 컬럼 설정 
            LsvDummy.Columns.Add("Depth");

        }

        Random rand = new Random();   // 트리뷰 노드이름으로 사용할 랜덤 값 

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
                MessageBox.Show("선택된 노드가 없습니다.",
                    "TreeView Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TrvDummy.SelectedNode.Nodes.Add(rand.Next().ToString());
            TrvDummy.SelectedNode.Expand();
            TreeToList();
        }
        #endregion

        #region 사진
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            DlgOpenImage.Title = "Open Image";
            DlgOpenImage.Filter = "Image Files(*.bmp;*.jpg;*.png;*.jpeg)|*.bmp;*.jpg;*.png;*.jpeg"; // Filter는 확장자를 이미지로만 한정 
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

        #region ㅇㅇㅇ
        /* 파일 로드 이벤트 핸들러 */
        private void BtnFileLoad_Click(object sender, EventArgs e)
        {
            // OpenFileDialog 컨트롤을 디자인에서 구성하지 않고 생성하는 방법
            OpenFileDialog dialog = new OpenFileDialog(); // 디자인에서 OpenFileDialog 생성 안해도 OK

            // 파일을 여러개 선택하는 작업 금지!
            // 디자인 속성에서 Multiselect 변경과 동일한 방법
            dialog.Multiselect = false;
            dialog.Filter = "Text Files(*.txt; *.cs; *.py) | *.txt; *.cs; *.py";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // UTF-8로 인코딩 된 파일을 로드하면 한글이 깨짐
                // EUC-KR(Window 949), UTF-8(BOM)은 깨지지 않음
                RtxEditor.LoadFile(dialog.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        /* 리치 텍스트 파일로 저장하는 이벤트 핸들러 */
        private void BtnFileSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();

            // rtf는 MS 워드에서 열리는 확장자
            dialog.Filter = "RichText Files(*.rtf) | *.rtf";

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                RtxEditor.SaveFile(dialog.FileName, RichTextBoxStreamType.RichNoOleObjs);
            }
        }


        #endregion
        private void BtnNoThread_Click(object sender, EventArgs e)
        {
            // 프로그래스바 설정
            var maxValue = 100;
            var currValue = 0;
            PrgProcess.Value = 0; // 프로그래스 밸류를 0으로 초기화
            PrgProcess.Minimum = 0;
            PrgProcess.Maximum = maxValue;

            BtnNoThread.Enabled = false;
            BtnNoThread.Enabled = false;
            BtnStop.Enabled = true;

            // 반복시작
            for (var i = 0; i <= maxValue; i++)
            {
                // 내부적으로 복잡하고 시간이 많이 필요한 작업
                currValue = i;
                PrgProcess.Value = currValue;

                // 텍스트 박스에 스레드 진행상태 표시
                TxtLog.AppendText($"진행중 : {currValue}\r\n");
                Thread.Sleep(500); // 1000ms = 1초, 500ms = 0.5초
            }

            // 작업이 끝났으니 버튼 상태 변경
            BtnNoThread.Enabled = BtnNoThread.Enabled = true;
            BtnStop.Enabled = false;

        }

        private void BtnThread_Click(object sender, EventArgs e)
        {
            var maxValue = 100;
            PrgProcess.Value = 0; // 프로그래스 밸류를 0으로 초기화
            PrgProcess.Minimum = 0;
            PrgProcess.Maximum = maxValue;

            BtnThread.Enabled = BtnNoThread.Enabled = false;
            BtnStop.Enabled = true;

            BgwProgress.WorkerReportsProgress = true; // 진행사항 리포트 활성화
            BgwProgress.WorkerSupportsCancellation = true; // 백그라운드워커 취소 활성화
            BgwProgress.RunWorkerAsync(null); // 백그라운드워커 실행!

        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            BgwProgress.CancelAsync(); // 비동기로 취소실행!
        }

        #region '백그라운드워커 이벤트 핸들러'

        /* 사용 하면 복잡하지만 사용하지 않으면 프로그램 응답 대기중 뜸 */

        private void DoRealWork(BackgroundWorker worker, DoWorkEventArgs e)
        {
            var MaxValue = 100;
            double currValue = 0;

            for (var i = 0; i <= MaxValue; i++)
            {
                if (worker.CancellationPending) // 중간에 취소할건지 물어보는 로직
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    currValue = i;
                    // 시간이 오래 걸리는 작업 처리
                    Thread.Sleep(500);

                    // 이하 로직 실행 시 BgwProgress_ProgressChanged 이벤트핸들러에서
                    // ProgressChangedEventArgs 내의 ProgressPercentage 속성으로 값이 들어감
                    worker.ReportProgress((int)((currValue / MaxValue) * 100));
                }
            }
        }

        /* 일을 진행 */
        private void BgwProgress_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            DoRealWork((BackgroundWorker)sender, e);
            e.Result = null;
        }

        /* 진행 상태 변경 표시 */
        private void BgwProgress_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            PrgProcess.Value = e.ProgressPercentage;

            // 텍스트 박스에 스레드 진행상태 표시
            TxtLog.AppendText($"진행률 : {PrgProcess.Value}%\r\n");
        }

        /* 진행 종료 후 처리 */
        private void BgwProgress_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                TxtLog.AppendText("작업이 취소되었습니다.\r\n");
            }
            else
            {
                TxtLog.AppendText("작업이 완료되었습니다.\r\n");
            }

            // 작업이 끝났으니 버튼 상태 변경
            BtnNoThread.Enabled = BtnThread.Enabled = true;
            BtnStop.Enabled = false;
        }
        #endregion
    }
}
        #region

        #endregion
