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
        public FormForgotPW2()
        {
            InitializeComponent();
        }

        private void FormForgotPW2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormForgotPW3 f = new FormForgotPW3();
            f.ShowDialog();
        }
    }
}
