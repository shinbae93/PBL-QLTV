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
using PBL.DAL;

namespace PBL.View
{
    public partial class FormQuanLy : Form
    {
        public FormQuanLy()
        {
            InitializeComponent();
            ShowNV("", "", "", 0);
            SetCBB();
        }

        private void SetCBB()
        {
            DHP_07Entities db = new DHP_07Entities();
            cbbLoaiTL.Items.Add(new CBBItem { Value = 0, Text = "ALL" });
            cbbLoaiTL.Text = "ALL";
            foreach (LoaiTaiLieu i in db.LoaiTaiLieux)
            {
                cbbLoaiTL.Items.Add(new CBBItem { Value = i.MaLTL, Text = i.TenLoai });
            }

            cbbQuyenHan.Items.Add(new CBBItem { Value = 0, Text = "ALL" });
            cbbQuyenHan.SelectedIndex = 0;
            foreach (QuyenHan i in db.QuyenHans)
            {
                cbbQuyenHan.Items.Add(new CBBItem { Value = i.ID_QuyenHan, Text = i.TenQuyenHan });
            }
        }
        #region 
        private void ShowSach()
        {
        }

        private void ShowPM()
        {
        }

        private void ShowDG()
        {
        }


        private void btnAddSach_Click(object sender, EventArgs e)
        {
            FormDuLieuSach f = new FormDuLieuSach(null);
            //f.d = new Form2.MyDel(this.Show);
            f.ShowDialog();
        }

        private void btnAddDocGia_Click(object sender, EventArgs e)
        {
            FormDuLieuDocGia f = new FormDuLieuDocGia(null);
            //f.d = new Form2.MyDel(this.Show);
            f.ShowDialog();
        }

        private void btnAddPhieuMuon_Click(object sender, EventArgs e)
        {
            FormAddDuLieuPhieuMuon f = new FormAddDuLieuPhieuMuon();
            //f.d = new Form2.MyDel(this.Show);
            f.ShowDialog();
        }

        private void btnEditPhieuMuon_Click(object sender, EventArgs e)
        {
            FormDuLieuPhieuMuon f = new FormDuLieuPhieuMuon(null);
            //f.d = new Form2.MyDel(this.Show);
            f.ShowDialog();
        }

        private void btnSearchTKVP_Click(object sender, EventArgs e)
        {
            FormViPham f = new FormViPham();
            f.ShowDialog();
        }


        private void btnTKVP_Click(object sender, EventArgs e)
        {
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FormLogOut f = new FormLogOut();
            f.ShowDialog();
        }

        private void btnReturnPM_Click(object sender, EventArgs e)
        {
            FormTraDuLieuPhieuMuon f = new FormTraDuLieuPhieuMuon();
            f.ShowDialog();
        }

        private void btnSearchS_Click(object sender, EventArgs e)
        {
        }

        private void btnShowS_Click(object sender, EventArgs e)
        {
        }

        private void btnDelS_Click(object sender, EventArgs e)
        {
        }

        private void btnSortS_Click(object sender, EventArgs e)
        {
        }

        private void btnSearchPM_Click(object sender, EventArgs e)
        {
        }

        private void btnShowPM_Click(object sender, EventArgs e)
        {
        }

        private void btnDelPM_Click(object sender, EventArgs e)
        {
        }

        private void btnSortPM_Click(object sender, EventArgs e)
        {
        }
        #endregion
        #region MethodNV
        public void ShowNV(string HoTen, string Email, string SDT, int ID_QuyenHan)
        {
            DHP_07Entities db = new DHP_07Entities();
            dataGridViewNhanVien.DataSource = QLNV_BLL.Instance.GetListNV(HoTen, Email, SDT, ID_QuyenHan);
            
        }
        public void DeleteNV()
        {
            if (dataGridViewNhanVien.SelectedRows.Count > 0)
            {
                int ID_NguoiDung = Convert.ToInt32(dataGridViewNhanVien.SelectedRows[0].Cells[0].Value);
                QLNV_BLL.Instance.DeleteNV(ID_NguoiDung);
            }
        }
        public void SortNV()
        {

        }
        #endregion

        #region EventNV
        private void btnShowNV_Click(object sender, EventArgs e)
        {
            ShowNV("", "", "", 0);
        }
        private void btnSearchNV_Click(object sender, EventArgs e)
        {
            ShowNV(txtHoTenNV.Text, txtEmailNV.Text, txtDienThoaiNV.Text, cbbQuyenHan.SelectedIndex);
        }
        private void btnAddNV_Click(object sender, EventArgs e)
        {
            FormDuLieuNhanVien f = new FormDuLieuNhanVien(0);
            f.d += new FormDuLieuNhanVien.MyDel(ShowNV);
            f.Show();
        }
        private void btnEditNV_Click(object sender, EventArgs e)
        {
            if (dataGridViewNhanVien.SelectedRows.Count == 1)
            {
                int ID = Convert.ToInt32(dataGridViewNhanVien.SelectedRows[0].Cells[0].Value);
                FormDuLieuNhanVien f = new FormDuLieuNhanVien(ID);
                f.d += new FormDuLieuNhanVien.MyDel(ShowNV);
                f.Show();
            }
            else
            {
                MessageBox.Show("Hay chon 1 Row!!");
            }
        }

        private void btnDelNV_Click(object sender, EventArgs e)
        {
            DeleteNV();
            ShowNV("", "", "", 0);
        }

        private void btnSortNV_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}