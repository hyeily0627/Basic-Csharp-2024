using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace hansot_pos
{
    public partial class TableUserCtrl : UserControl
    {
        public string tableNumber = string.Empty;
        ListSet ls = new ListSet();

        public TableUserCtrl()
        {
            InitializeComponent();
        }
        
        public void SetTableNum(string tableNum)
        {
            this.tableNumber = tableNum;
        }

        public void SetTableNumberLabel(string num)
        {
            this.TableNumber.Text = tableNumber;
            tableNumber = num;
        }

        public void SetListBox()
        {
            menuListBox.Items.Clear();

            for (int i = 0; i < Program.list.Count; i++)
            {
                menuListBox.Items.Add(Program.list[i].Name + " * " + Program.list[i].cnt);
            }
            menuListBox.SelectionMode = SelectionMode.None;
        }

        private void Clicked(object sender, EventArgs e)
        {
            Order order = new Order(tableNumber);
            order.OnOrderComplete += Order_OnOrderComplete;
            order.setListBox += Order_setListBox;
            order.Show();
        }

        private void Order_setListBox()
        {
            SetListBox();
        }

        private void Order_OnOrderComplete(object sender, EventArgs e)
        {
            ls.SetList(tableNumber);
            SetListBox();
        }
    }
}