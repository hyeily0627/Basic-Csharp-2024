using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hansot_pos
{
    class ListSet
    {
        public void SetList(string TableNumber)
        {
            switch (TableNumber)
            {
                case "table1":
                    Program.list = Program.table1Menu;
                    break;
                case "table2":
                    Program.list = Program.table2Menu;
                    break;
                case "table3":
                    Program.list = Program.table3Menu;
                    break;
                case "table4":
                    Program.list = Program.table4Menu;
                    break;
                case "table5":
                    Program.list = Program.table5Menu;
                    break;
                case "table6":
                    Program.list = Program.table6Menu;
                    break;
            }
        }

        public void SetPgList(string TableNumber)
        {
            switch (TableNumber)
            {
                case "table1":
                    Program.table1Menu = Program.list;
                    break;
                case "table2":
                    Program.table2Menu = Program.list;
                    break;
                case "table3":
                    Program.table3Menu = Program.list;
                    break;
                case "table4":
                    Program.table4Menu = Program.list;
                    break;
                case "table5":
                    Program.table5Menu = Program.list;
                    break;
                case "table6":
                    Program.table6Menu = Program.list;
                    break;
            }
        }
    }
}
