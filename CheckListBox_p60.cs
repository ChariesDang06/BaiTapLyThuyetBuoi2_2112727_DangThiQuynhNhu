using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapBuoiLyThuyet2
{
    public partial class CheckListBox_p60 : Form
    {
        public CheckListBox_p60()
        {
            InitializeComponent();
        }

        private void clbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection items;
            items = this.clbMonHoc.CheckedItems;
            string s = "";
            foreach(object ob in items)
            {
                s += ob.ToString() + ",";
            }
            MessageBox.Show("Danh sach mon hoc: " + "s");
 
        }

       
    }
}
