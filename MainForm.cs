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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void linkLbl_p35_Click(object sender, EventArgs e)
        {
            LinkLabel_p35 p35 = new LinkLabel_p35();
            p35.ShowDialog();   
        }

        private void linkLbl_p42_Click(object sender, EventArgs e)
        {
            frmSubmit_p42 p42 = new frmSubmit_p42();
            p42.ShowDialog();
        }

        private void linkLbl_p56_Click(object sender, EventArgs e)
        {
            RadioButton_p56 p56 = new RadioButton_p56();
            p56.ShowDialog();
        }

        private void linkLbl_p60_Click(object sender, EventArgs e)
        {
            CheckListBox_p60 p60 = new CheckListBox_p60();
            p60.ShowDialog();
        }

        private void linkLbl_p48_Click(object sender, EventArgs e)
        {
            ComboBox_p48 p48 = new ComboBox_p48();
            p48.ShowDialog();
        }

        private void linkLbl_p52_Click(object sender, EventArgs e)
        {
            ListBox_p52 p52 = new ListBox_p52();   
            p52.ShowDialog();
        }

        private void linkLbl_p57_Click(object sender, EventArgs e)
        {
            Buttons_p57 p57 = new Buttons_p57();
            p57.ShowDialog();
        }
    }
}
