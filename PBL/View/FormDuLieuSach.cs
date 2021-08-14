using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL.DAL;
using PBL.BLL;

namespace PBL.View
{
    public partial class FormDuLieuSach : Form
    {
        public delegate void MyDel(string TenTL, int MaLTL);

        public MyDel d { get; set; }
        public string MaTL { get; set; }

        public FormDuLieuSach(string MaTL)
        {
            InitializeComponent();
            this.MaTL = MaTL;
            SetCBB();
            if (MaTL != null) Reload();
        }

        private void Reload()
        {
            txtMaTaiLieu.Text = MaTL;
            txtTenTaiLieu.Text = QLTL_BLL.Instance.GetTLByMaTL(MaTL).TenTL;
            txtTenTacGia.Text = QLTL_BLL.Instance.GetTLByMaTL(MaTL).TacGia;
            cbbNgonNgu.Text = QLTL_BLL.Instance.GetTLByMaTL(MaTL).NgonNgu.TenNgonNgu;
            cbbNhaXuatBan.Text = QLTL_BLL.Instance.GetTLByMaTL(MaTL).NhaXuatBan.TenNXB;
            cbbLTL.Text = QLTL_BLL.Instance.GetTLByMaTL(MaTL).LoaiTaiLieu.TenLoai;
            dtpNamXB.Value = QLTL_BLL.Instance.GetTLByMaTL(MaTL).NamXuatBan;
            numSLSach.Value = (decimal)QLTL_BLL.Instance.GetTLByMaTL(MaTL).SoLuong;
            txtMaTaiLieu.Enabled = false;
        }

        private void SetCBB()
        {
            using (DHP_07Entities db = new DHP_07Entities())
            {
                foreach (NgonNgu i in db.NgonNgus)
                {
                    cbbNgonNgu.Items.Add(new CBBItem { Value = i.MaNgonNgu, Text = i.TenNgonNgu });
                }
                foreach (NhaXuatBan i in db.NhaXuatBans)
                {
                    cbbNhaXuatBan.Items.Add(new CBBItem { Value = i.MaNXB, Text = i.TenNXB });
                }
                foreach (LoaiTaiLieu i in db.LoaiTaiLieux)
                {
                    cbbLTL.Items.Add(new CBBItem { Value = i.MaLTL, Text = i.TenLoai });
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtMaTaiLieu.Text == "" || txtTenTacGia.Text == "" || txtTenTaiLieu.Text == "" || cbbLTL.SelectedIndex == -1 || cbbNgonNgu.SelectedIndex == -1 || cbbNhaXuatBan.SelectedIndex == -1)
            {
                MessageBox.Show("Vui long dien du thong tin !");
            }
            else if (!Regex.Match(txtMaTaiLieu.Text, @"^([A-Z]([0-9][1-9]){3})$").Success)
            {
                MessageBox.Show("Ma tai lieu khong hop le !");
            }
            else if (QLTL_BLL.Instance.GetTLByMaTL(txtMaTaiLieu.Text) != null)
            {
                MessageBox.Show("Ma tai lieu da ton tai !");
            }
            else if (numSLSach.Value == 0)
            {
                MessageBox.Show("So luong khong hop le !");
            }
            else
            {
                TaiLieu s = new TaiLieu()
                {
                    MaTL = txtMaTaiLieu.Text.ToString(),
                    TenTL = txtTenTaiLieu.Text.ToString(),
                    TacGia = txtTenTacGia.Text.ToString(),
                    MaNgonNgu = ((CBBItem)cbbNgonNgu.SelectedItem).Value,
                    MaNXB = ((CBBItem)cbbNhaXuatBan.SelectedItem).Value,
                    MaLTL = ((CBBItem)cbbLTL.SelectedItem).Value,
                    SoLuong = (int)numSLSach.Value,
                    NamXuatBan = dtpNamXB.Value
                };
                if (MaTL == null) QLTL_BLL.Instance.AddTL(s);
                else QLTL_BLL.Instance.EditTL(s);
                d("", 0);
                this.Dispose();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}