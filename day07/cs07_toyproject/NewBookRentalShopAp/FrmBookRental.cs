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
using NewBookRentalShopApp;

namespace NewBookRentalShopApp
{
    public partial class FrmBookRental : MetroForm
    {
        private bool isNew = false;  // UPDATE(false), INSERT(true) 

        public FrmBookRental()
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
           // ToDo 지금은 필요 없음
        }

        #region '신규'버튼 이벤트 핸들러 
        private void BtnNew_Click(object sender, EventArgs e)
        {
            isNew = true;
            TxtRentalIdx.Text = TxtMemNames.Text = string.Empty;
            TxtMemberIdx.Text = TxtBookIdx.Text = TxtBookNames.Text = string.Empty; 
            
            TxtRentalIdx.Focus(); // 순번은 자동증가 하기 때문에 입력불가 

            DtpReturnDate.Value = DtpRentalDate.Value = DateTime.Now;   

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
            if (string.IsNullOrEmpty(TxtMemNames.Text))
            {
                MessageBox.Show("회원명 입력하세요.");
                return ;
            }

            if (string.IsNullOrEmpty(TxtBookNames.Text))
            {
                MessageBox.Show("대출 할 책을 선택하세요.");
                return;
            }

            // 반납일이 1800-01-01이면 미반납 상태(Null) 

            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    conn.Open();

                    var query = "";
                    if (isNew) // INSERT이면
                    {
                        query = @"INSERT INTO [dbo].[rentaltbl]
                                               ([memberIdx]
                                               ,[bookIdx]
                                               ,[rentalDate]
                                               ,[returnDate])
                                         VALUES
                                               (@memberIdx 
                                               ,@bookIdx 
                                               ,@rentalDate 
                                               ,@returnDate)";
                    }
                    else // UPDATE 
                    {
                        query = @"UPDATE [dbo].[rentaltbl]
                                       SET [memberIdx] = @memberIdx
                                          ,[bookIdx] = @bookIdx
                                          ,[rentalDate] = @rentalDate
                                          ,[returnDate] = @returnDate
                                     WHERE rentalIdx = @rentalIdx";
                    }
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlParameter prmMemberIdx = new SqlParameter("@memberIdx", TxtMemberIdx.Text);
                    cmd.Parameters.Add(prmMemberIdx);
                    SqlParameter prmBookIdx = new SqlParameter("@bookIdx", TxtBookIdx.Text);
                    cmd.Parameters.Add(prmBookIdx);
                    SqlParameter prmRentalDate = new SqlParameter("@rentalDate", DtpRentalDate.Value);
                    cmd.Parameters.Add(prmRentalDate);

                    var returnDate = "";  // 반납 날짜 때문에 추가한 구문 
                    if (DtpReturnDate.Value <= DtpRentalDate.Value) // 대출일보다 반납일이 뒤의 날짜가 되어야 함! 
                    {
                        returnDate = "";
                    }
                    else
                    {
                        returnDate = DtpReturnDate.Value.ToString("yyyy-MM-dd");
                    }
                    SqlParameter prmReturnDate = new SqlParameter("@returnDate", returnDate);
                    cmd.Parameters.Add(prmReturnDate);  

                    if (isNew != true)
                    {
                        SqlParameter prmRentalIdx = new SqlParameter("@RentalIdx", TxtRentalIdx.Text); 
                        cmd.Parameters.Add(prmRentalIdx);
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

            RefreshData();
        }
        #endregion

        // '삭제'이벤트 핸들러 버튼 없으므로 삭제 

        #region 데이터 그리뷰(+컬럼 컨트롤)에 데이터를 새로 부르기 RefreshData()
        private void RefreshData()
        {
           using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
           {
                conn.Open();
                var query = @"SELECT r.rentalIdx 
                                    ,r.memberIdx 
	                                ,m.Names AS MemNames
                                    ,r.bookIdx 
	                                ,b.Names AS bookNames
                                    ,r.rentalDate 
                                    ,r.returnDate 
                                FROM rentaltbl AS r
                                JOIN membertbl AS m
                                  ON r.memberIdx = m.memberIdx
                                JOIN bookstbl AS b 
	                              ON r.bookIdx = b.bookIdx"; // 화면에 필요한 테이블 쿼리 변경
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "bookstbl");

                DgvResult.DataSource = ds.Tables[0];
                DgvResult.ReadOnly = true;

                DgvResult.Columns[0].HeaderText = "대출순번";
                DgvResult.Columns[1].HeaderText = "회원순번";
                DgvResult.Columns[2].HeaderText = "회원명";
                DgvResult.Columns[3].HeaderText = "책순번"; // -> 구분명 새로추가 
                DgvResult.Columns[4].HeaderText = "책제목";
                DgvResult.Columns[5].HeaderText = "대출일";
                DgvResult.Columns[6].HeaderText = "반납일";

                // 각 컬럼의 너비 지정, 컬럼 숨김 지정 
                DgvResult.Columns[0].Width = 30;  
                DgvResult.Columns[1].Width = 130; 
                DgvResult.Columns[2].Width = 50; 
                DgvResult.Columns[4].Width = 160; 
                DgvResult.Columns[5].Width = 75;  
            }
        }
        #endregion

        # region 셀 선택 컨트롤
        private void DgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex  > -1 ) // 아무것도 선택하지 않으면 -1 
            {
                var selData = DgvResult.Rows[e.RowIndex]; // 내가 선택한 인덱스 값 
                TxtRentalIdx.Text = selData.Cells[0].Value.ToString();    // 대출순번 
                TxtMemberIdx.Text = selData.Cells[1].Value.ToString();    // 책저자 
                TxtMemNames.Text = selData.Cells[2].Value.ToString();     // 회원명 
                TxtBookIdx.Text = selData.Cells[3].Value.ToString();      // 책순번
                TxtBookNames.Text = selData.Cells[4].Value.ToString();    // 책제목 
                DtpRentalDate.Value = DateTime.Parse(selData.Cells[5].Value.ToString());  // 대출일
                DtpReturnDate.Value = !string.IsNullOrEmpty(selData.Cells[6].Value.ToString()) ?
                                        DateTime.Parse(selData.Cells[6].Value.ToString()) :
                                        DateTime.Parse("1800-01-01");                                  
                // 반납을 안했을 경우 null이므로 오류 뜨기때문에 코드 수정! 

                TxtRentalIdx.ReadOnly = true; // UPDATE시 PK인 Division을 변경하면 안됨

                isNew = false; //UPDATE
            }
        }
        #endregion

        # region BtnSearchMember_Click 아이콘 (회원명 검색)
        private void BtnSearchMember_Click(object sender, EventArgs e)
        {
            PopMember popup = new PopMember();
            popup.StartPosition = FormStartPosition.CenterParent;
            
            if(popup.ShowDialog() == DialogResult.Yes)
            {
                TxtMemberIdx.Text = Helper.Common.SelMemberIdx;
                TxtMemNames.Text = Helper.Common.SelMemberName;
            }
        }
        #endregion

        # region BtnSearchBook_Click 아이콘 (책제목 검색)
        private void BtnSearchBook_Click(object sender, EventArgs e)
        {
            PopBook popup = new PopBook();
            popup.StartPosition = FormStartPosition.CenterParent;

            if (popup.ShowDialog() == DialogResult.Yes)
            {
                TxtBookIdx.Text = Helper.Common.SelBookIdx;
                TxtBookNames.Text = Helper.Common.SelBookName;
            }
        }
        #endregion
    }
}

