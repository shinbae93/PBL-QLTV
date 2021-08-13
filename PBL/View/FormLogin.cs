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
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (Login_BLL.Instance.CheckNguoiDung(txtUser.Text, txtPassword.Text) == true)
                {
                    if (Login_BLL.Instance.GetNguoiDungByUserAndPW(txtUser.Text, txtPassword.Text).ID_QuyenHan == 1)
                    {
                        FormQuanLy f = new FormQuanLy(txtUser.Text);
                        this.Visible = false;
                        f.ShowDialog();
                        this.Visible = true;
                    }
                    else if (Login_BLL.Instance.GetNguoiDungByUserAndPW(txtUser.Text, txtPassword.Text).ID_QuyenHan == 2)
                    {
                        FormNhanVien f = new FormNhanVien(txtUser.Text);
                        this.Visible = false;
                        f.ShowDialog();
                        this.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Sai thong tin");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FormForgotPW f = new FormForgotPW();
            f.ShowDialog();
        }

        private void txtUser_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text))
            {
                e.Cancel = false;
                //txtUser.Focus();
                errorProvider.SetError(txtUser, "Please enter your user name");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtUser, null);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                e.Cancel = false;
                //txtPassword.Focus();
                errorProvider.SetError(txtPassword, "Please enter your password");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtPassword, null);
            }
        }
    }
}