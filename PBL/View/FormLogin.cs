using PBL.BLL;
using PBL.DAL;
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
            if (Login_BLL.Instance.CheckNguoiDung(txtUser.Text, txtPassword.Text) == true)
            {
                if (Login_BLL.Instance.GetNguoiDungByUserAndPW(txtUser.Text, txtPassword.Text).ID_QuyenHan == 1)
                {
                    FormQuanLy f = new FormQuanLy(txtUser.Text);
                    f.ShowDialog();
                }
                else if (Login_BLL.Instance.GetNguoiDungByUserAndPW(txtUser.Text, txtPassword.Text).ID_QuyenHan == 2)
                {
                    FormNhanVien f = new FormNhanVien();
                    f.ShowDialog();
                }
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