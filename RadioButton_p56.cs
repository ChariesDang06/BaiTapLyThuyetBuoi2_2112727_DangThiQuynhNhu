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
    public partial class RadioButton_p56 : Form
    {
        public RadioButton_p56()
        {
            InitializeComponent();
        }

        private void rbNam_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbNam.Checked)
                MessageBox.Show("Giới tính của bạn là: " + rbNam.Text);
        }

        private void rbNu_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbNu.Checked)
                MessageBox.Show("Giới tính của bạn là: " + rbNu.Text);
        }
    }
}
