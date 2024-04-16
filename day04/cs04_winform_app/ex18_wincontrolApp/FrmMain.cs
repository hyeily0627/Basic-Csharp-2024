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
            if(PicNormal.SizeMode == PictureBoxSizeMode.Normal)
            {
                PicNormal.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                PicNormal.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
        #endregion
    }

}
