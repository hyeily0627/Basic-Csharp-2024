﻿using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewBookRentalShopApp
{
    public partial class PopMember : MetroForm  
    {
        public PopMember()
        {
            InitializeComponent();
        }

        private void PopMember_Load(object sender, EventArgs e)
        {
            
                using (SqlConnection conn = new SqlConnection(NewBookRentalShopApp.Helper.Common.ConnString))
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
                }
        }

        private void DgvResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 구현 할 부분 없음 
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if(DgvResult.SelectedRows == null)
            {
                MessageBox.Show("회원을 선택하세요.");
                return;
            }

            var selData = DgvResult.SelectedRows[0];
            //MessageBox.Show(selData.Cells[0].Value.ToString() + selData.Cells[1].Value.ToString());
            Helper.Common.SelMemberIdx = selData.Cells[0].Value.ToString();
            Helper.Common.SelMemberName = selData.Cells[1].Value.ToString();

            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();   // 닫기 
        }
    }
}
