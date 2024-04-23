using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
    public partial class FrmBookDivision : MetroForm
    {
        private bool isNew = false;  // UPDATE(false), INSERT(true) 

        public FrmBookDivision()
        {
            InitializeComponent();
        }

        private void FrmLoginUser_Load(object sender, EventArgs e)
        {
            RefreshData();
            /*
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                var query = @"SELECT useridx 
                                    ,userid 
                                    ,[password] 
                                    ,lastLoginDateTime
                                FROM usertbl";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "usertbl");

                DgvResult.DataSource = ds.Tables[0];
                DgvResult.ReadOnly = true;  // 수정불가
                DgvResult.Columns[0].HeaderText = "사용자 순번";
                DgvResult.Columns[1].HeaderText = "아이디";
                DgvResult.Columns[2].HeaderText = "패스워드";
                DgvResult.Columns[3].HeaderText = "마지막 로그인날짜";
            }
            */
        }
        #region '신규'버튼 이벤트 핸들러 
        private void BtnNew_Click(object sender, EventArgs e)
        {
            isNew = true;
            TxtDivison.Text = TxtNames.Text = string.Empty;
            TxtDivison.ReadOnly = false; // 최초 입력할때는 PK값을 입력해줘야함
            TxtDivison.Focus(); // 순번은 자동증가 하기 때문에 입력불가 
        }
        #endregion

        #region '저장'버튼 이벤트 핸들러 
        private void BtnSave_Click(object sender, EventArgs e)
        {
            var md5hash = MD5.Create(); // MD5 암호화용 객체 생성

            // 입력검증(Validation check), 아이디, 패스워드를 안넣으면 
            /*
            if (string.IsNullOrEmpty(TxtUserNumber.Text))
            {
                MessageBox.Show("사용자 순번을 입력하세요.");
            }
            */
            if (string.IsNullOrEmpty(TxtDivison.Text))
            {
                MessageBox.Show("구분코드를 입력하세요.");
                return ;
            }
            if (string.IsNullOrEmpty(TxtNames.Text))
            {
                MessageBox.Show("구분명을 입력하세요.");
                return ;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    conn.Open();

                    var query = "";
                    if (isNew) // INSERT이면
                    {
                        query = @"INSERT INTO divtbl
                                              (Division
                                             ,Names)
                                        VALUES
                                              (@Division
                                             ,@Names)";
                    }
                    else // UPDATE 
                    {
                        query = @"UPDATE divtbl
                                 SET Names = @Names
                               WHERE Division = @Division";
                    }
                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlParameter prmDivision = new SqlParameter("Division", TxtDivison.Text);
                    SqlParameter prmNames = new SqlParameter("Names",TxtNames.Text);
                    // Command 에 Parameter를 연결해줘야함 
                    cmd.Parameters.Add(prmDivision);
                    cmd.Parameters.Add(prmNames);

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

            TxtDivison.Text = TxtNames.Text = string.Empty;  // 입력, 수정, 삭제이후에는 모든 입력값을 지워줘야함 
            RefreshData();
        }
        #endregion

        #region '삭제'버튼 이벤트 핸들러
        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtDivison.Text))// 구분코드가 없으면 
            {
                MetroMessageBox.Show(this, "삭제할 구분코드를 선택하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                var query = @"DELETE FROM divtbl WHERE Division = @Division";


                SqlCommand cmd = new SqlCommand(query, conn);
                SqlParameter prmDivision = new SqlParameter("@Division", TxtDivison.Text);
                cmd.Parameters.Add(prmDivision);

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

            TxtDivison.Text = TxtNames.Text = string.Empty;
            RefreshData();
        }
        #endregion

        #region 데이터 그리뷰에 데이터를 새로 부르기
        private void RefreshData()
        {
           using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
           {
                conn.Open();
                var query = @"SELECT Division
                                    ,Names
                                FROM divtbl"; // 화면에 필요한 테이블 쿼리 변경
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "divtbl");

                DgvResult.DataSource = ds.Tables[0];
                DgvResult.ReadOnly = true;  // 수정불가
                DgvResult.Columns[0].HeaderText = "구분코드";
                DgvResult.Columns[1].HeaderText = "구분명";
            }
        }
        #endregion

        private void DgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex  > -1 ) // 아무것도 선택하지 않으면 -1 
            {
                var selData = DgvResult.Rows[e.RowIndex]; // 내가 선택한 인덱스 값 
                TxtDivison.Text = selData.Cells[0].Value.ToString();
                TxtNames.Text = selData.Cells[1].Value.ToString();
                TxtDivison.ReadOnly = true; // UPDATE시 PK인 Division을 변경하면 안됨

                isNew = false; //UPDATE
            }
        }
    }
}

