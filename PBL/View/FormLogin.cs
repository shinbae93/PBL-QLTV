using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.View
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "quanly")
            {
                FormQuanLy f = new FormQuanLy();
                f.ShowDialog();
            }
            else if (textBox1.Text == "nhanvien")
            {
                FormNhanVien f = new FormNhanVien();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai thong tin");
            }

        }
        private void label3_Click(object sender, EventArgs e)
        {
            FormForgotPW f = new FormForgotPW();
            f.ShowDialog();
        }
    }
}