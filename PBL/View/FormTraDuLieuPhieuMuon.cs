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
    public partial class FormTraDuLieuPhieuMuon : Form
    {
        public int MaPM { get; set; }

        public FormTraDuLieuPhieuMuon(int MaPM)
        {
            InitializeComponent();
            txtMaPhieuMuon.Enabled = false;
            this.MaPM = MaPM;
            dtpHanTra.Value = QLPM_BLL.Instance.GetPMByMaPM(MaPM).HanTra;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            QLPM_BLL.Instance.TraPM(MaPM, txtViPham.Text, dtpNgayTra.Value);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}