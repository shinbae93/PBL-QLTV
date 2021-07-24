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
    public partial class FormDuLieuDocGia : Form
    {
        public delegate void Mydel(string sothe, string name);

        public Mydel d { get; set; }
        public string mssv;

        public FormDuLieuDocGia(string m)
        {
            InitializeComponent();
            mssv = m;
            SetEnable();
            SetGUI();
        }

        public void SetEnable()
        {
            if (mssv != null)
            {
                txtMSSV.Text = mssv;
                txtMSSV.Enabled = false;
            }
        }

        public void SetGUI()
        {
            if (mssv != null)
            {
                DocGia tmp = new DocGia();
                tmp = QLDG_BLL.Instance.GetDGByMSSV(mssv);
                txtHoTen.Text = tmp.HoTen;
                txtMaLop.Text = Convert.ToString(tmp.MaLop);
                dtpNgaySinh.Value = Convert.ToDateTime(tmp.NgaySinh);
                dtpNgayDK.Value = Convert.ToDateTime(tmp.NgayDK);
                if (tmp.GioiTinh == true)
                {
                    rbtnNam.Checked = true;
                }
                else
                {
                    rbtnNu.Checked = true;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DocGia tmp = new DocGia
            {
                MSSV = txtMSSV.Text,
                HoTen = txtHoTen.Text,
                NgaySinh = dtpNgaySinh.Value,
                GioiTinh = rbtnNam.Checked,
                MaLop = Convert.ToInt32(txtMaLop.Text),
                NgayDK = dtpNgayDK.Value
            };
            if (mssv == null)
            {
                QLDG_BLL.Instance.AddDG(tmp);
            }
            else
            {
                QLDG_BLL.Instance.EditDG(tmp);
            }
            d("", "");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}