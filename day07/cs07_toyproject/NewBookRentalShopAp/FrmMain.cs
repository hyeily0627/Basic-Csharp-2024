using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace NewBookRentalShopAp
{
    public partial class FrmMain : MetroForm
    {
        // 각 화면을 초기화 
        FrmLoginUser frmLoginUser = null;   // 객체를 메서드로 생성 
        public FrmMain()
        {
            InitializeComponent();
        }

        // 폼로드 이벤트 핸들러 -> 로그인창 먼저 띄우기! 
        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmLogin frm =  new FrmLogin(); 
            //frm.Parent = this;  // FrmMain이 부모창 설정
            frm.StartPosition = FormStartPosition.CenterScreen; 
            frm.TopMost = true;  // 윈도우 화면 상단에 
            frm.ShowDialog();   
        }

        private void MnuLoginUsers_Click(object sender, EventArgs e)
        {
            frmLoginUser = ShowActiveForm(frmLoginUser, typeof(FrmLoginUser)) as FrmLoginUser; 
        }

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
    }
}
