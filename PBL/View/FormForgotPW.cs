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
    public partial class FormForgotPW : Form
    {
        public FormForgotPW()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NguoiDung s = QLNV_BLL.Instance.GetUserByUsername(txtUser.Text);
            if (s != null)
            {
                FormForgotPW2 f = new FormForgotPW2(s);
                this.Visible = false;
                f.ShowDialog();
                this.Visible = true;
            }
            else
            {
                MessageBox.Show("Unknown user");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}