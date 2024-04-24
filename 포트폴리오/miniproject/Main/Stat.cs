using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hansot_pos
{
    public partial class Stat : Form
    {
        public Stat()
        {
            InitializeComponent();
            InitCategoryComboBoxData();
            InitMenuComboBoxData();
        }

        private void InitCategoryComboBoxData()
        {
            for (int i = 0; i < Program.menuList.Count; i++)
            {
                if(!(categoryComboBox.Items.Contains(Program.menuList[i].category)))
                categoryComboBox.Items.Add(Program.menuList[i].category);
            }
        }

        private void InitMenuComboBoxData()
        {
            for ( int i = 0; i < Program.menuList.Count; i++)
            {
                menuComboBox.Items.Add(Program.menuList[i].Name);
            }
        }

        private void categoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CgSelect = categoryComboBox.SelectedIndex;

            String txt = categoryComboBox.SelectedItem as String;  // 아래 2가지는 안됨....

            if (CgSelect > -1)
            {
                String seltxt = String.Format("{0}", categoryComboBox.Items[CgSelect]);

                CgTotalPrice.Text = SetCgTotalPrice(seltxt) + " 원";
                CgTotalSales.Text = SetCgTotalSalse(seltxt) + " 개";
            }
        }

        private void menuCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int MnSelect = menuComboBox.SelectedIndex;

            String txt = menuComboBox.SelectedItem as String;  // 아래 2가지는 안됨....

            if (MnSelect > -1)
            {
                String seltxt = String.Format("{0}", menuComboBox.Items[MnSelect]);

                MnTotalPrice.Text = SetMnTotalPrice(seltxt) + " 원";
                MnTotalSales.Text = SetMnTotalSalse(seltxt) + " 개";
            }
        }

        private string SetCgTotalPrice(string category)
        {
            int totalPrice = 0;

            for(int i=0; i<Program.StatList.Count; i++)
            {
                if(Program.StatList[i].category.ToString() == category)
                {
                    totalPrice += Program.StatList[i].price;
                }
            }

            return totalPrice.ToString();
        }

        private string SetCgTotalSalse(string category)
        {
            int totalCount = 0;

            for (int i = 0; i < Program.StatList.Count; i++)
            {
                if (Program.StatList[i].category.ToString() == category)
                {
                    totalCount += Program.StatList[i].cnt;
                }
            }

            return totalCount.ToString();
        }

        private string SetMnTotalPrice(string Menu)
        {
            int totalPrice = 0;

            for (int i = 0; i < Program.StatList.Count; i++)
            {
                if (Program.StatList[i].Name == Menu)
                {
                    totalPrice += Program.StatList[i].price;
                }
            }

            return totalPrice.ToString();
        }

        private string SetMnTotalSalse(string Menu)
        {
            int totalCount = 0;

            for (int i = 0; i < Program.StatList.Count; i++)
            {
                if (Program.StatList[i].Name == Menu)
                {
                    totalCount += Program.StatList[i].cnt;
                }
            }

            return totalCount.ToString();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
