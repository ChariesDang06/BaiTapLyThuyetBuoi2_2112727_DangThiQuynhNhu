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
    public partial class ListBox_p52 : Form
    {
        public ListBox_p52()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int itemSelect = lbDanhSach.SelectedItems.Count - 1;
            for (int i = itemSelect; i >= 0; i--)
            {
                lbDanhSachChon.Items.Add(lbDanhSach.SelectedItems[i]);
                lbDanhSach.Items.Remove(lbDanhSach.SelectedItems[i]);
            }    
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int i = lbDanhSachChon.SelectedItems.Count - 1;
            while(i>=0)
            {
                lbDanhSachChon.Items.RemoveAt(lbDanhSachChon.SelectedIndices[i]);
                i--;
            }
        }
    }
}
