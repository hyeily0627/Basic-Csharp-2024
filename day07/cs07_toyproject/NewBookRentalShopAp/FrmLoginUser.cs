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
using MetroFramework;
using MetroFramework.Forms;

namespace NewBookRentalShopAp
{
    public partial class FrmLoginUser : MetroForm
    {
        private bool isNew = false;  // UPDATE(false), INSERT(true) 
        private string connString = "Data Source=localhost;" +
                                     "Initial Catalog=BookRentalShop2024;" +
                                     "Persist Security Info=True;" +
                                     "User ID=sa;Encrypt=False;" +
                                     "Password=mssql_p@ss";
        public FrmLoginUser()
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

        private void BtnNew_Click(object sender, EventArgs e)
        {
            isNew = true;
            TxtUserNumber.Text = TxtUserId.Text = TxtPassword.Text = string.Empty;
            TxtUserNumber.ReadOnly = true;
            TxtUserNumber.Focus(); //유저번호는 자동 증가로 입력안함. 아이디로 자동 포커스 
        }

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
            if (string.IsNullOrEmpty(TxtUserId.Text))
            {
                MessageBox.Show("사용자 아이디를 입력하세요.");
                return ;
            }
            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show("패스워드을 입력하세요.");
                return ;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    var query = "";
                    if (isNew) // INSERT이면
                    {
                        query = @"INSERT INTO usertbl
                                       (userid
                                       ,[password])
                                 VALUES
                                       (@userid
                                       ,@password)";
                    }
                    else // UPDATE 
                    {
                        query = @"UPDATE usertbl
                                 SET userid = @userid
                                   ,[password] = @password
                               WHERE useridx = @useridx";
                    }
                    SqlCommand cmd = new SqlCommand(query, conn);

                    if (isNew == false) // UPDATE 시에는 @userIdx 파라미터 필요! 
                    {
                        SqlParameter prmUserNumber = new SqlParameter("useridx", TxtUserNumber.Text);
                        cmd.Parameters.Add(prmUserNumber);
                    }
                    SqlParameter prmUserId = new SqlParameter("userId", TxtUserId.Text);
                    SqlParameter prmPassword = new SqlParameter("password", GetMd5Hash(md5hash, TxtPassword.Text));
                    // Command 에 Parameter를 연결해줘야함 
                    cmd.Parameters.Add(prmUserId);
                    cmd.Parameters.Add(prmPassword);

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


            TxtUserNumber.Text = TxtUserId.Text = TxtPassword.Text = string.Empty;  // 입력, 수정, 삭제이후에는 모든 입력값을 지워줘야함 
            RefreshData();
        }
        // 데이터 그리뷰에 데이터를 새로 부르기
        private void RefreshData()
        {
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
        }

        private void DgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex  > -1 ) // 아무것도 선택하지 않으면 -1 
            {
                var selData = DgvResult.Rows[e.RowIndex]; // 내가 선택한 인덱스 값 
                TxtUserNumber.Text = selData.Cells[0].Value.ToString();
                TxtUserNumber.ReadOnly = true;
                TxtUserId.Text = selData.Cells[1].Value.ToString();
                TxtPassword.Text = selData.Cells[2].Value.ToString();
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtUserNumber.Text))// 사용자 아이디 순번아 없으면
            {
                MetroMessageBox.Show(this, "삭제할 사용자를 선택하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var answer = MetroMessageBox.Show(this, "정말 삭제하시겠습니까?.", "삭제여부", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.OK)
            {
                return;
            }
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                var query = @"DELETE FROM usertbl WHERE useridx = @useridx";


                SqlCommand cmd = new SqlCommand(query, conn);
                SqlParameter prmUserNumber = new SqlParameter("@useridx", TxtUserNumber.Text);
                cmd.Parameters.Add(prmUserNumber);

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

            TxtUserNumber.Text = TxtUserId.Text = TxtPassword.Text = string.Empty;
            RefreshData();
        }
        // MD5 해시 알고리즘 암호화
        string GetMd5Hash(MD5 md5hash, string input)
        {
            // 입력문자열을 byte배열로 변환한 뒤 MD5 해시 처리
            byte[] data = md5hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("X2")); // 16진수 문자로 각 글자를 전부 변환
            }

            return builder.ToString();
        }
    }
}

