using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MetroFramework;
using MetroFramework.Forms;

namespace NewBookRentalShopApp
{
    public partial class FrmMember : MetroForm
    {
        private bool isNew = false;  // UPDATE(false), INSERT(true) 

        public FrmMember()
        {
            InitializeComponent();
        }

        private void FrmLoginUser_Load(object sender, EventArgs e)
        {
            RefreshData();  // bookstbl에서 데이터를 가져오는 부분 
            // 콤보박스에 들어가는 데이터를 초기화해야함 
            InitInputData(); // 콤보박스, 날짜, NumericUpDown 컨트롤 데이터, 초기화 
        }

        private void InitInputData()
        {
            try
            {
                var temp = new Dictionary<string, string>();    
                temp.Add("A", "A");
                temp.Add("B", "B");
                temp.Add("C", "C");
                temp.Add("D", "D");

                CboLevels.DataSource = new BindingSource(temp, null);
                CboLevels.DisplayMember = "Value";
                CboLevels.ValueMember = "Key";
                CboLevels.SelectedIndex = -1;


            }
            catch (Exception)
            {

                
            }
        }

        #region '신규'버튼 이벤트 핸들러 
        private void BtnNew_Click(object sender, EventArgs e)
        {
            isNew = true;
            TxtNumberIdx.Text = TxtNames.Text = string.Empty;
            
            TxtNumberIdx.Focus(); // 순번은 자동증가 하기 때문에 입력불가 

            CboLevels.SelectedIndex = -1;
            TxtAddr.Text = TxtEmail.Text = string.Empty;
            
        }
        #endregion

        #region '저장'버튼 이벤트 핸들러 
        private void BtnSave_Click(object sender, EventArgs e)
        {
            //var md5hash = MD5.Create(); // MD5 암호화용 객체 생성

            // 입력검증(Validation check), 아이디, 패스워드를 안넣으면 
            /*
            if (string.IsNullOrEmpty(TxtUserNumber.Text))
            {
                MessageBox.Show("사용자 순번을 입력하세요.");
            }
            */
            if (string.IsNullOrEmpty(TxtNames.Text))
            {
                MessageBox.Show("회원명을 입력하세요.");
                return ;
            }

            // 콤보박스는 SelectedIndex가 -1이 되면 안됨 
            if (CboLevels.SelectedIndex < 0)
            {
                MessageBox.Show("등급을 선택하세요");
                return ;
            }
            if (string.IsNullOrEmpty(TxtAddr.Text))
            {
                MessageBox.Show("주소를 입력하세요.");
                return ;
            }

            // 출판일은 기본으로 오늘 날짜가 들어감
            // ISBN은 null이 들어가도 상관없음
            // 책 기본가격은 0원

            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    conn.Open();

                    var query = "";
                    if (isNew) // INSERT이면
                    {
                        query = @"INSERT INTO [dbo].[membertbl]
                                             ([Names]
                                             ,[Levels]
                                             ,[Addr]
                                             ,[Mobile]
                                             ,[Email])
                                       VALUES
                                             (@Names
                                             ,@Levels
                                             ,@Addr,
                                             ,@Mobile,
                                             ,@Email,)";
                    }
                    else // UPDATE 
                    {
                        query = @"UPDATE [dbo].[membertbl]
                                     SET [Names] = @Names
                                        ,[Levels] = @Levels
                                        ,[Addr] = @Addr
                                        ,[Mobile] = @Mobile
                                        ,[Email] = @Email
                                   WHERE memberIdx = @memberIdx";
                    }
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // 복붙 후 쿼리가 바뀌면 파라미터도 꼭꼭 변경해야함! 
                    SqlParameter prmNames = new SqlParameter("@Names", TxtAddr.Text);
                    SqlParameter prmLevels = new SqlParameter("@Levels", CboLevels.SelectedValue);
                    SqlParameter prmAddr = new SqlParameter("@Addr", TxtAddr.Text);
                    SqlParameter prmMobile = new SqlParameter("@Mobile", TxtMobile.Text);
                    SqlParameter prmEmail = new SqlParameter("@Email", TxtAddr.Text);

                    cmd.Parameters.Add(prmNames);
                    cmd.Parameters.Add(prmLevels);
                    cmd.Parameters.Add(prmAddr);
                    cmd.Parameters.Add(prmMobile);
                    cmd.Parameters.Add(prmEmail);

                    if(isNew != true)
                    {
                        SqlParameter prmMemberIdx = new SqlParameter("memberIdx", TxtNumberIdx.Text); 
                        cmd.Parameters.Add(prmMemberIdx);
                    }

                    var result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        // this 메세지박스의 부모창이 누구냐, FrmLoginUser
                        MetroMessageBox.Show(this, "저장성공!", "저장", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MessageBox.Show("저장성공!", "저장", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("저장실패!", "실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this,$"오류 : {ex.Message}","오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            TxtNumberIdx.Text = TxtNames.Text = string.Empty;  // 입력, 수정, 삭제이후에는 모든 입력값을 지워줘야함 
            CboLevels.SelectedIndex = -1;
            TxtAddr.Text = TxtEmail.Text = string.Empty;    
            //DtpReleaseDate.Value = DateTime.Now;
            //NudPrice.Value = 0;

            RefreshData();
        }
        #endregion

        #region '삭제'버튼 이벤트 핸들러
        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNumberIdx.Text))// 구분코드가 없으면 
            {
                MetroMessageBox.Show(this, "삭제할 책을 선택하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var answer = MetroMessageBox.Show(this, "정말 삭제하시겠습니까?.", "삭제여부", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.OK)
            {
                return;
            }
            using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
            {
                conn.Open();
                var query = @"DELETE FROM merbertbl WHERE memberIdx = @memberIdx";


                SqlCommand cmd = new SqlCommand(query, conn);
                SqlParameter prmMemberIdx = new SqlParameter("@memberIdx", TxtNumberIdx.Text);
                cmd.Parameters.Add(prmMemberIdx);

                var result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MetroMessageBox.Show(this, "삭제성공!", "삭제", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroMessageBox.Show(this, "삭제실패!", "실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            TxtNumberIdx.Text = TxtNames.Text = string.Empty;  // 입력, 수정, 삭제이후에는 모든 입력값을 지워줘야함 
            CboLevels.SelectedIndex = -1;
            TxtAddr.Text = TxtEmail.Text = string.Empty;
            //DtpReleaseDate.Value = DateTime.Now;
            //NudPrice.Value = 0;

            TxtNumberIdx.Text = TxtNames.Text = string.Empty;
            RefreshData();
        }
        #endregion

        #region 데이터 그리뷰에 데이터를 새로 부르기 RefreshData()
        private void RefreshData()
        {
           using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
           {
                conn.Open();
                var query = @"SELECT [memberIdx]
                                          ,[Names]
                                          ,[Levels]
                                          ,[Addr]
                                          ,[Mobile]
                                          ,[Email]
                                      FROM [membertbl]"; // 화면에 필요한 테이블 쿼리 변경
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "membertbl");

                DgvResult.DataSource = ds.Tables[0];
                DgvResult.ReadOnly = true;  // 수정불가 

                DgvResult.Columns[0].HeaderText = "회원순번";
                DgvResult.Columns[1].HeaderText = "회원명";
                DgvResult.Columns[2].HeaderText = "등급";
                DgvResult.Columns[3].HeaderText = "주소"; 
                DgvResult.Columns[4].HeaderText = "전화번호";
                DgvResult.Columns[5].HeaderText = "이메일";

                // 각 컬럼의 너비 지정
                DgvResult.Columns[0].Width = 30;  // 회원순번
                DgvResult.Columns[1].Width = 70; // 회원명
                DgvResult.Columns[2].Width = 50; // 등급
                DgvResult.Columns[4].Width = 10; // 주소
                //DgvResult.Columns[5].Width = 75;  // 
            }
        }
        #endregion

        #region 셀 선택 컨트롤 
        private void DgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex  > -1 ) // 아무것도 선택하지 않으면 -1 
            {
                var selData = DgvResult.Rows[e.RowIndex]; // 내가 선택한 인덱스 값 
                TxtNumberIdx.Text = selData.Cells[0].Value.ToString();      // 회원순번
                TxtNames.Text = selData.Cells[1].Value.ToString();          // 회원명
                CboLevels.SelectedValue = selData.Cells[2].Value;           // 등급
                TxtAddr.Text = selData.Cells[3].Value.ToString();           // 주소
                TxtMobile.Text = selData.Cells[4].Value.ToString();         // 전화번호 
                TxtEmail.Text = selData.Cells[5].Value.ToString();          // 이메일

                isNew = false; //UPDATE
            }
            
        }
        #endregion

        #region ISBN에 숫자만 입력되도록 처리 
        private void TxtIsbn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}

