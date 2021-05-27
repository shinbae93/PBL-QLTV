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
    public partial class FormForgotPW2 : Form
    {
        public NguoiDung nd { get; set; } 
        public FormForgotPW2(NguoiDung nd_PW)
        {
            nd = nd_PW;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == nd.Email && txtSDT.Text == nd.DienThoai)
            {
                FormForgotPW3 f = new FormForgotPW3(nd);
                f.ShowDialog();
            }
            else {
                MessageBox.Show("Unknown email or phone number");
            }
        }
    }
}
