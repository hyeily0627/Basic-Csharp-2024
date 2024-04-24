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
    public partial class PopBook : MetroForm  
    {
        public PopBook()
        {
            InitializeComponent();
        }

        private void PopMember_Load(object sender, EventArgs e)
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
                DgvResult.ReadOnly = true; // 수정불가

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

        private void DgvResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 구현 할 부분 없음 
        }

        # region '선택' 버튼 컨트롤
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if(DgvResult.SelectedRows == null)
            {
                MessageBox.Show("책을 선택하세요.");
                return;
            }

            var selData = DgvResult.SelectedRows[0];
            //MessageBox.Show(selData.Cells[0].Value.ToString() + selData.Cells[1].Value.ToString());
            Helper.Common.SelBookIdx = selData.Cells[0].Value.ToString();   // 책순번 
            Helper.Common.SelBookName = selData.Cells[4].Value.ToString();  // 책제목 

            this.DialogResult = DialogResult.Yes;
            this.Close();
        }
        #endregion

        # region '취소' 버튼 컨트롤
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();   // 닫기 
        }
        #endregion
    }
}
