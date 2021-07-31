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
using PBL.BLL;

namespace PBL.View
{
    public partial class FormForgotPW3 : Form
    {
        public NguoiDung nd { get; set; }

        public FormForgotPW3(NguoiDung nd_PW2)
        {
            InitializeComponent();
            nd = nd_PW2;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.Text == txtXacNhanLaiMatKhau.Text)
            {
                QLNV_BLL.Instance.ChangePass(nd, txtXacNhanLaiMatKhau.Text);
                MessageBox.Show("Your password has been change successfully !");
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong Password");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}