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
        public delegate void MyDel(string TenDG, string MSSV);

        public MyDel d { get; set; }
        public int MaPM { get; set; }

        public FormTraDuLieuPhieuMuon(int MaPM)
        {
            InitializeComponent();
            txtMaPhieuMuon.Enabled = false;
            this.MaPM = MaPM;
            txtMaPhieuMuon.Text = MaPM.ToString();
            dtpHanTra.Value = QLPM_BLL.Instance.GetPMByMaPM(MaPM).HanTra;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (dtpNgayTra.Value > DateTime.Now)
            {
                MessageBox.Show("Ngay tra khong hop le !");
            }
            else
            {
                QLPM_BLL.Instance.TraPM(MaPM, txtViPham.Text, dtpNgayTra.Value);
                d("", "");
                this.Dispose();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}