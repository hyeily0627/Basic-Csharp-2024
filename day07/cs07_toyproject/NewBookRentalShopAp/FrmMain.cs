using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace NewBookRentalShopApp
{
    public partial class FrmMain : MetroForm
    {
        #region 각 화면을 초기화 (클래스 초기화)
        // F12 눌러서 확인해보면 Frm~ 은 클래스❗❗❗ frm~ 은 객체변수 ❗❗❗
        FrmLoginUser frmLoginUser = null;   // 객체를 메서드로 생성 
        FrmBookDivision frmbookdivision = null;
        FrmBookInfo frmbookinfo = null;
        FrmMember frmmember = null;
        FrmBookRental frmBookRental = null; 
        #endregion

        #region FrmMain 
        public FrmMain()
        {
            InitializeComponent();
        }
        #endregion

        #region 폼로드 이벤트 핸들러 : 로그인창 먼저 띄우기! 
        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();

            //frm.Parent = this;  // FrmMain이 부모창 설정
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.TopMost = true;  // 윈도우 화면 상단에 
            frm.ShowDialog();

            LblLoginId.Text = Helper.Common.LoginId;  
        }
        #endregion

        #region '로그인 사용자 관리' 메뉴 클릭 이벤트 핸들러
        private void MnuLoginUsers_Click(object sender, EventArgs e)
        {
            // 이미 이런 창이 열려있으면 새로 생성 할 필요가 없기때문에, 이런 작업을 안하면 메뉴 클릭시 마다 새 폼이 열림 
            frmLoginUser = ShowActiveForm(frmLoginUser, typeof(FrmLoginUser)) as FrmLoginUser; 
        }
        #endregion

        #region'책 장르관리' 메뉴 클릭 이벤트 핸들러 
        private void MnuBookDiv_Click(object sender, EventArgs e)
        {
            frmbookdivision = ShowActiveForm(frmbookdivision, typeof(FrmBookDivision)) as FrmBookDivision; 
        }
        #endregion

        #region '책 정보' 메뉴 클릭 이벤트 핸들러 
        private void MnuInfo_Click(object sender, EventArgs e)
        {   
            // 객체변수, 객체변수, 클래스, 클래스
            frmbookinfo = ShowActiveForm(frmbookinfo, typeof(FrmBookInfo)) as FrmBookInfo;
        }
        #endregion

        #region '도서회원 관리' 메뉴 클릭 이벤트 핸들러 
        private void MnuMembers_Click(object sender, EventArgs e)
        {
            frmmember = ShowActiveForm(frmmember, typeof(FrmMember)) as FrmMember;
        }
        #endregion

        #region '대출관리' 메뉴 클릭 이벤트 핸들러
        private void MnuRental_Click(object sender, EventArgs e)
        {
            frmBookRental = ShowActiveForm(frmBookRental, typeof(FrmBookRental)) as FrmBookRental;
        }
        #endregion

        #region 창 컨트롤링
        Form ShowActiveForm(Form form,Type type)
        {
            if (form == null) // 화면이 한번도 안열렸으면 
            {
                form = Activator.CreateInstance(type) as Form; // 타입은 클래스 타입 
                form.MdiParent = this; // 자식창의 부모는 FrmMain 
                form.WindowState = FormWindowState.Normal;
                form.Show();
            }
            else
            {
                if (form.IsDisposed) // 화면이 한번이라도 닫혔으면 
                {
                    form = Activator.CreateInstance(type) as Form; // 타입은 클래스 타입 
                    form.MdiParent = this; // 자식창의 부모는 FrmMain 
                    form.WindowState = FormWindowState.Normal;
                    form.Show();
                }
                else // 창을 그냥 최소화, 열려있으면! 
                {
                    form.Activate(); // 화면에 열려있는 창을 활성화 
                }
            }
            return form;
        }
        #endregion

        #region 폼 닫기 컨트롤링 
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MetroMessageBox.Show(this, "종료하시겠습니까?", "종료여부", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) 
            {
                e.Cancel = true;  
            }
            else 
            {
                Environment.Exit(0);           
            }
        }
        #endregion

        private void MnuAbout_Click(object sender, EventArgs e)
        {
            FrmAbout popup = new FrmAbout();    
            popup.StartPosition = FormStartPosition.CenterParent;
            popup.ShowDialog(); 
        }
    }
}
