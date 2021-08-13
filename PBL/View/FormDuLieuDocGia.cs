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
            SetCBB();
            SetEnable();
            SetGUI();
        }

        private void SetCBB()
        {
            DHP_07Entities db = new DHP_07Entities();
            foreach (Lop i in db.Lops)
            {
                cbbMaLop.Items.Add(new CBBItem { Value = i.MaLop, Text = i.TenLop });
            }
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
                cbbMaLop.Text = ((CBBItem)cbbMaLop.Items[tmp.MaLop]).Text;
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
            if (txtHoTen.Text == "" || txtMSSV.Text == "" || cbbMaLop.SelectedIndex == -1 || rbtnNam.Checked == rbtnNu.Checked)
            {
                MessageBox.Show("Vui long dien du thong tin !");
            }
            else if (!txtMSSV.Text.All(Char.IsDigit))
            {
                MessageBox.Show("MSSV khong hop le !");
            }
            else if (dtpNgayDK.Value > DateTime.Now)
            {
                MessageBox.Show("Ngay DK khong hop le !");
            }
            else if (dtpNgaySinh.Value > DateTime.Now)
            {
                MessageBox.Show("Ngay sinh khong hop le !");
            }
            else
            {
                DocGia tmp = new DocGia
                {
                    MSSV = txtMSSV.Text,
                    HoTen = txtHoTen.Text,
                    NgaySinh = dtpNgaySinh.Value,
                    GioiTinh = rbtnNam.Checked,
                    MaLop = cbbMaLop.SelectedIndex,
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
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}