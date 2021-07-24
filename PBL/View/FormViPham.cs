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
    public partial class FormViPham : Form
    {
        public FormViPham()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridViewVP.DataSource = QLTK_BLL.Instance.GetListVP(txtMSSV.Text, txtHoTen.Text);
        }
    }
}
