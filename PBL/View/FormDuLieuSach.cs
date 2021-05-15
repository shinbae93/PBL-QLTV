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
    public partial class FormDuLieuSach : Form
    {
        public FormDuLieuSach(object p)
        {
            InitializeComponent();
            txtMaTaiLieu.Enabled = false;
        }
    }
}