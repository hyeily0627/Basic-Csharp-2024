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
    public partial class FrmBookInfo : MetroForm
    {
        private bool isNew = false;  // UPDATE(false), INSERT(true) 

        public FrmBookInfo()
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
                using(SqlConnection conn = new SqlConnection(Helper.Common.ConnString)) 
                {
                    conn.Open();
                    var query = @"SELECT Division, Names From divtbl";
                    SqlCommand cmd = new SqlCommand(query, conn);       
                    // SqlDataReader = 개발자가 하나씩 처리 할 때 
                    // SqlDataAdapter.DataSet = 한번에 데이터 그리드 뷰 등에 뿌릴때 
                    SqlDataReader reader = cmd.ExecuteReader();
                    var temp = new Dictionary<string, string>();

                    while (reader.Read()) 
                    {
                        // reader[0] = Division컬럼, reader[1] = Names컬럼
                        temp.Add(reader[0].ToString(), reader[1].ToString());
                    }
                    CboDivision.DataSource = new BindingSource(temp, null);
                    CboDivision.DisplayMember = "Value"; // 공포/스릴러 표시
                    CboDivision.ValueMember = "Key"; // B001 
                    CboDivision.SelectedIndex = -1;
                    CboDivision.PromptText = "-- 구분명 선택-- ";
                }

            }
            catch (Exception)
            {

                
            }
        }

        #region '신규'버튼 이벤트 핸들러 
        private void BtnNew_Click(object sender, EventArgs e)
        {
            isNew = true;
            TxtBookIdx.Text = TxtAuthor.Text = string.Empty;
            
            TxtBookIdx.Focus(); // 순번은 자동증가 하기 때문에 입력불가 

            CboDivision.SelectedIndex = -1;
            TxtNames.Text = TxtIsbn.Text = string.Empty;
            DtpReleaseDate.Value = DateTime.Now;
            NudPrice.Value = 0;
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
            if (string.IsNullOrEmpty(TxtAuthor.Text))
            {
                MessageBox.Show("구분코드를 입력하세요.");
                return ;
            }

            // 콤보박스는 SelectedIndex가 -1이 되면 안됨 
            if (CboDivision.SelectedIndex < 0)
            {
                MessageBox.Show("구분명을 선택하세요");
                return ;
            }
            if (string.IsNullOrEmpty(TxtNames.Text))
            {
                MessageBox.Show("책제목을 입력하세요.");
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
                        query = @"INSERT INTO [dbo].[bookstbl]
                                               ([Author]
                                               ,[Division]
                                               ,[Names]
                                               ,[ReleaseDate]
                                               ,[ISBN]
                                               ,[Price])
                                         VALUES
                                               (@Author
                                               ,@Division
                                               ,@Names
                                               ,@ReleaseDate
                                               ,@ISBN
                                               ,@Price)";
                    }
                    else // UPDATE 
                    {
                        query = @"UPDATE [bookstbl]
                                       SET [Author] = @Author
                                          ,[Division] = @Division
                                          ,[Names] = @Names
                                          ,[ReleaseDate] = @ReleaseDate
                                          ,[ISBN] = @ISBN
                                          ,[Price] = @Price
                                     WHERE bookIdx = @bookIdx";
                    }
                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlParameter prmAuthor = new SqlParameter("@Author", TxtAuthor.Text);
                    SqlParameter prmDivision = new SqlParameter("@Division",CboDivision.SelectedValue);
                    SqlParameter prmNames = new SqlParameter("@Names", TxtNames.Text);
                    SqlParameter prmReleaseDate = new SqlParameter("@ReleaseDate", DtpReleaseDate.Value);
                    SqlParameter prmISBN = new SqlParameter("@ISBN", TxtIsbn.Text);
                    SqlParameter prmPrice = new SqlParameter("@Price", NudPrice.Text);

                    cmd.Parameters.Add(prmAuthor);
                    cmd.Parameters.Add(prmDivision);
                    cmd.Parameters.Add(prmNames);
                    cmd.Parameters.Add(prmReleaseDate);
                    cmd.Parameters.Add(prmISBN);
                    cmd.Parameters.Add(prmPrice);

                    if(isNew != true)
                    {
                        SqlParameter prmBookIdx = new SqlParameter("bookIdx", TxtBookIdx.Text); 
                        cmd.Parameters.Add(prmBookIdx);
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

            TxtBookIdx.Text = TxtAuthor.Text = string.Empty;  // 입력, 수정, 삭제이후에는 모든 입력값을 지워줘야함 
            CboDivision.SelectedIndex = -1;
            TxtNames.Text = TxtIsbn.Text = string.Empty;    
            DtpReleaseDate.Value = DateTime.Now;
            NudPrice.Value = 0;

            RefreshData();
        }
        #endregion

        #region '삭제'버튼 이벤트 핸들러
        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBookIdx.Text))// 구분코드가 없으면 
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
                var query = @"DELETE FROM bookstbl WHERE bookIdx = @bookIdx";


                SqlCommand cmd = new SqlCommand(query, conn);
                SqlParameter prmBookIdx = new SqlParameter("@bookIdx", TxtBookIdx.Text);
                cmd.Parameters.Add(prmBookIdx);

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

            TxtBookIdx.Text = TxtAuthor.Text = string.Empty;  // 입력, 수정, 삭제이후에는 모든 입력값을 지워줘야함 
            CboDivision.SelectedIndex = -1;
            TxtNames.Text = TxtIsbn.Text = string.Empty;
            DtpReleaseDate.Value = DateTime.Now;
            NudPrice.Value = 0;

            TxtBookIdx.Text = TxtAuthor.Text = string.Empty;
            RefreshData();
        }
        #endregion

        #region 데이터 그리뷰에 데이터를 새로 부르기
        private void RefreshData()
        {
           using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
           {
                conn.Open();
                var query = @"SELECT b.[bookIdx]
                                    ,b.[Author]
                                    ,b.[Division]
	                                ,d.Names AS DivNames
                                    ,b.[Names]
                                    ,b.[ReleaseDate]
                                    ,b.[ISBN]
                                    ,b.[Price]
                               FROM [bookstbl] AS B
                               JOIN divtbl AS d
                                 ON b.Division = d.Division"; // 화면에 필요한 테이블 쿼리 변경
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "bookstbl");

                DgvResult.DataSource = ds.Tables[0];
                DgvResult.ReadOnly = true;

                DgvResult.Columns[0].HeaderText = "책순번";
                DgvResult.Columns[1].HeaderText = "저자명";
                DgvResult.Columns[2].HeaderText = "구분코드";
                DgvResult.Columns[3].HeaderText = "구분명"; // -> 구분명 새로추가 
                DgvResult.Columns[4].HeaderText = "책제목";
                DgvResult.Columns[5].HeaderText = "출판일";
                DgvResult.Columns[6].HeaderText = "ISBN";
                DgvResult.Columns[7].HeaderText = "책가격";

                // 각 컬럼의 너비 지정
                DgvResult.Columns[0].Width = 30;  // 책순번
                DgvResult.Columns[1].Width = 130; // 저자명
                DgvResult.Columns[2].Visible = false; // 구분코드 숨겨버리기!
                DgvResult.Columns[4].Width = 160; // 책제목
                DgvResult.Columns[5].Width = 75;  // 출판일
                DgvResult.Columns[7].Width = 50;  // 책가격
            }
        }
        #endregion

        # region 셀 선택 컨트롤
        private void DgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex  > -1 ) // 아무것도 선택하지 않으면 -1 
            {
                var selData = DgvResult.Rows[e.RowIndex]; // 내가 선택한 인덱스 값 
                TxtBookIdx.Text = selData.Cells[0].Value.ToString();  // 책순번 
                TxtAuthor.Text = selData.Cells[1].Value.ToString();   // 책저자 
                TxtNames.Text = selData.Cells[4].Value.ToString();    // 책제목

                DtpReleaseDate.Value = DateTime.Parse(selData.Cells[5].Value.ToString());    // 책제목
                // 2019-03-09 문자열을 DateTime.Parse() 로 DataTime형으로 변경 
                
                TxtIsbn.Text = selData.Cells[6].Value.ToString();
                // 20000가격을 숫자형으로 형 변환해주는
                // 거의 모든 타입에 *.Parse(string) 메서드가 존재 
                NudPrice.Value = Decimal.Parse(selData.Cells[7].Value.ToString());
                TxtBookIdx.ReadOnly = true; // UPDATE시 PK인 Division을 변경하면 안됨

                // 콤보박스는 맨 마지막에 
                //MessageBox.Show(selData.Cells[3].Value.ToString());
                CboDivision.SelectedValue = selData.Cells[2].Value; // 구분코드로 선택해야함!

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

