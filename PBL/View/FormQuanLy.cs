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
using PBL.BLL.DTO;

namespace PBL.View
{
    public partial class FormQuanLy : Form
    {
        public string Username { get; set; }
        public Boolean UserClosing = false;

        public FormQuanLy(string Username)
        {
            InitializeComponent();
            SetCBBSach();
            SetCBBSortDG();
            SetCBBNV();
            this.Username = Username;
        }

        #region Logout
        
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            UserClosing = true;
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn đăng xuất khỏi chương trình không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {
                
            }
        }
        private void FormQuanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.ApplicationExitCall:
                    break;
                case CloseReason.FormOwnerClosing:
                    break;
                case CloseReason.MdiFormClosing:
                    break;
                case CloseReason.None:
                    break;
                case CloseReason.TaskManagerClosing:
                    break;
                case CloseReason.UserClosing:
                    if (!UserClosing)
                    {
                        DialogResult TL;
                        TL = MessageBox.Show("Bạn Có Muốn Thoát không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (TL == DialogResult.No)
                        {
                            e.Cancel = true;
                        }
                    }
                    break;
                case CloseReason.WindowsShutDown:
                    break;
                default:
                    break;
            }
            UserClosing = false;
        }

        #endregion Logout

        #region Sach

        private void SetCBBSach()
        {
            using (DHP_07Entities db = new DHP_07Entities())
            {
                cbbLoaiTL.Items.Add(new CBBItem { Value = 0, Text = "ALL" });
                cbbLoaiTL.Text = "ALL";
                foreach (LoaiTaiLieu i in db.LoaiTaiLieux)
                {
                    cbbLoaiTL.Items.Add(new CBBItem { Value = i.MaLTL, Text = i.TenLoai });
                }
            }
        }

        private void ShowSach(string TenTL, int MaLTL)
        {
            dataGridViewQLSach.DataSource = QLTL_BLL.Instance.GetListTL(TenTL, MaLTL);
        }

        private void btnAddSach_Click(object sender, EventArgs e)
        {
            FormDuLieuSach f = new FormDuLieuSach(null);
            f.d = new FormDuLieuSach.MyDel(this.ShowSach);
            f.ShowDialog();
        }

        private void btnEditS_Click(object sender, EventArgs e)
        {
            if (dataGridViewQLSach.SelectedRows.Count == 1)
            {
                FormDuLieuSach f = new FormDuLieuSach(dataGridViewQLSach.SelectedRows[0].Cells["MaTL"].Value.ToString());
                f.d = new FormDuLieuSach.MyDel(this.ShowSach);
                f.ShowDialog();
            }
        }

        private void btnSearchS_Click(object sender, EventArgs e)
        {
            ShowSach(txtTenTaiLieuS.Text, ((CBBItem)cbbLoaiTL.SelectedItem).Value);
        }

        private void btnShowS_Click(object sender, EventArgs e)
        {
            ShowSach("", 0);
        }

        private void btnDelS_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow i in dataGridViewQLSach.SelectedRows)
            {
                QLTL_BLL.Instance.DeleteTL(i.Cells["MaTL"].Value.ToString());
            }
            ShowSach(txtTenTaiLieuS.Text, ((CBBItem)cbbLoaiTL.SelectedItem).Value);
        }

        private void btnSortS_Click(object sender, EventArgs e)
        {
            dataGridViewQLSach.DataSource = QLTL_BLL.Instance.SortTL(cbbSortS.Text);
        }

        private void btnViTri_Click(object sender, EventArgs e)
        {
            if (dataGridViewQLSach.SelectedRows.Count == 1)
            {
                string s = dataGridViewQLSach.SelectedRows[0].Cells["MaTL"].Value.ToString();
                MessageBox.Show("Ke Sach : " + s[0]
                    + "\nTang : " + s.Substring(1, 2)
                    + "\nHang : " + s.Substring(3, 2)
                    + "\nCot : " + s.Substring(5, 2));
            }
        }

        #endregion Sach

        #region PhieuMuon

        private void ShowPM(string TenDG, string MSSV)
        {
            dataGridViewPhieuMuon.DataSource = QLPM_BLL.Instance.GetListPM(TenDG, MSSV);
        }

        private void btnAddPhieuMuon_Click(object sender, EventArgs e)
        {
            FormAddDuLieuPhieuMuon f = new FormAddDuLieuPhieuMuon(Username);
            f.d = new FormAddDuLieuPhieuMuon.MyDel(this.ShowPM);
            f.ShowDialog();
        }

        private void btnReturnPM_Click(object sender, EventArgs e)
        {
            if (dataGridViewPhieuMuon.SelectedRows.Count == 1)
            {
                FormTraDuLieuPhieuMuon f = new FormTraDuLieuPhieuMuon(Convert.ToInt32(dataGridViewPhieuMuon.SelectedRows[0].Cells[0].Value));
                f.d = new FormTraDuLieuPhieuMuon.MyDel(this.ShowPM);
                f.ShowDialog();
            }
        }

        private void btnSearchPM_Click(object sender, EventArgs e)
        {
            ShowPM(txtTenDocGiaPM.Text, txtMSSVPM.Text);
        }

        private void btnShowPM_Click(object sender, EventArgs e)
        {
            ShowPM("", "");
        }

        private void btnDelPM_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow i in dataGridViewPhieuMuon.SelectedRows)
            {
                QLPM_BLL.Instance.DeletePM(Convert.ToInt32(i.Cells["MaPhieuMuon"].Value));
            }
            ShowPM(txtTenDocGiaPM.Text, txtMSSVPM.Text);
        }

        private void btnSortPM_Click(object sender, EventArgs e)
        {
            dataGridViewPhieuMuon.DataSource = QLPM_BLL.Instance.SortPM(cbbSortPM.Text);
        }

        #endregion PhieuMuon

        #region NhanVien

        #region MethodNV

        private void SetCBBNV()
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

        public void ShowNV(string HoTen, string Email, string SDT, int ID_QuyenHan)
        {
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

        #endregion MethodNV

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
            dataGridViewNhanVien.DataSource = QLNV_BLL.Instance.SortNV(cbbSortNV.Text);
        }

        #endregion EventNV

        #endregion NhanVien

        #region DocGia

        private void SetCBBSortDG()
        {
            cbbSortDG.Items.Add(new CBBItem { Value = 0, Text = "MaDocGia Tang" });
            cbbSortDG.Text = "MaDocGia Tang";
            cbbSortDG.Items.Add(new CBBItem { Value = 1, Text = "MaDocGia Giam" });
            cbbSortDG.Items.Add(new CBBItem { Value = 2, Text = "MSSV Tang" });
            cbbSortDG.Items.Add(new CBBItem { Value = 3, Text = "MSSV Giam" });
            cbbSortDG.Items.Add(new CBBItem { Value = 4, Text = "HoTen Tang" });
            cbbSortDG.Items.Add(new CBBItem { Value = 5, Text = "HoTen Giam" });
            cbbSortDG.Items.Add(new CBBItem { Value = 6, Text = "NgaySinh Tang" });
            cbbSortDG.Items.Add(new CBBItem { Value = 7, Text = "NgaySinh Giam" });
            cbbSortDG.Items.Add(new CBBItem { Value = 8, Text = "MaLop Tang" });
            cbbSortDG.Items.Add(new CBBItem { Value = 9, Text = "MaLop Giam" });
            cbbSortDG.Items.Add(new CBBItem { Value = 10, Text = "NgayDK Tang" });
            cbbSortDG.Items.Add(new CBBItem { Value = 11, Text = "NgayDK Giam" });
        }

        private void ShowDG(string sothe, string name)
        {
            dataGridViewDocGia.DataSource = QLDG_BLL.Instance.GetListDGSelect(sothe, name);
        }

        private void btnSearchDG_Click(object sender, EventArgs e)
        {
            ShowDG(txtSoTheDG.Text, txtHoTenDG.Text);
        }

        private void btnShowDG_Click(object sender, EventArgs e)
        {
            ShowDG("", "");
        }

        private void btnAddDocGia_Click(object sender, EventArgs e)
        {
            FormDuLieuDocGia f = new FormDuLieuDocGia(null);
            f.d = new FormDuLieuDocGia.Mydel(this.ShowDG);
            f.ShowDialog();
        }

        private void btnEditDocGia_Click(object sender, EventArgs e)
        {
            if (dataGridViewDocGia.SelectedRows.Count == 1)
            {
                FormDuLieuDocGia f = new FormDuLieuDocGia(dataGridViewDocGia.SelectedRows[0].Cells["MSSV"].Value.ToString());
                f.d = new FormDuLieuDocGia.Mydel(this.ShowDG);
                f.ShowDialog();
            }
        }

        private void btnDelDG_Click(object sender, EventArgs e)
        {
            if (dataGridViewDocGia.SelectedRows.Count == 1)
            {
                string m = dataGridViewDocGia.SelectedRows[0].Cells["MSSV"].Value.ToString();
                QLDG_BLL.Instance.DelDG(QLDG_BLL.Instance.GetDGByMSSV(m));
            }
            ShowDG("", "");
        }

        private void btnSortDG_Click(object sender, EventArgs e)
        {
            string[] arrListStr = cbbSortDG.Text.Split(' ');
            string m1 = arrListStr[0];
            string m2 = arrListStr[1];
            dataGridViewDocGia.DataSource = QLDG_BLL.Instance.SortDG(m1, m2);
        }

        #endregion DocGia

        #region Thong Ke

        private void btnSearchTKVP_Click(object sender, EventArgs e)
        {
            FormViPham f = new FormViPham();
            f.ShowDialog();
        }

        private void btnTKVP_Click(object sender, EventArgs e)
        {
            dataGridViewTKVP.DataSource = QLTK_BLL.Instance.GetTKVP((cbbThangTK.SelectedIndex == -1) ? 0 : Convert.ToInt32(cbbThangTK.SelectedItem), (cbbNamTK.SelectedIndex == -1) ? 0 : Convert.ToInt32(cbbNamTK.SelectedItem));
        }

        private void btnShowTKMS_Click(object sender, EventArgs e)
        {
            dataGridViewTKMS.DataSource = QLTK_BLL.Instance.GetTKMS((cbbThangTK.SelectedIndex == -1) ? 0 : Convert.ToInt32(cbbThangTK.SelectedItem), (cbbNamTK.SelectedIndex == -1) ? 0 : Convert.ToInt32(cbbNamTK.SelectedItem));
            txtTongSoLuongTK.Text = dataGridViewTKMS.Rows.Count.ToString();
        }

        #endregion Thong Ke

        private void FormQuanLy_Load(object sender, EventArgs e)
        {

        }
    }
}