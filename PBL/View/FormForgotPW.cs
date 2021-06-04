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
    public partial class FormForgotPW : Form
    {
        public FormForgotPW()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DHP_07Entities db = new DHP_07Entities();
            var l1 = db.NguoiDungs
                .Where(p => p.Username == txtUser.Text)
                .Select(p => p).ToList();
            if (l1.Count != 0)
            {
                FormForgotPW2 f = new FormForgotPW2(l1[0]);
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
