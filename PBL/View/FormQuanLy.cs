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
            SetCBB();
            SetCBBSortDG();
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
        }
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
            dataGridViewDocGia.DataSource = QLDG_BLL.Instance.GetListDG(sothe, name);
        }


        private void btnAddSach_Click(object sender, EventArgs e)
        {
            FormDuLieuSach f = new FormDuLieuSach(null);
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

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            FormDuLieuNhanVien f = new FormDuLieuNhanVien();
            f.ShowDialog();
        }

        private void btnSearchNV_Click(object sender, EventArgs e)
        {
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

        private void btnSearchDG_Click(object sender, EventArgs e)
        {
            ShowDG(txtSoTheDG.Text,txtHoTenDG.Text);
        }

        private void btnShowDG_Click(object sender, EventArgs e)
        {
            ShowDG("","");
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
            if(dataGridViewDocGia.SelectedRows.Count == 1)
            {
                string m = dataGridViewDocGia.SelectedRows[0].Cells["MSSV"].Value.ToString();
                QLDG_BLL.Instance.DelDG(QLDG_BLL.Instance.GetDGByMSSV(m));
            }
            ShowDG("","");
        }

        private void btnSortDG_Click(object sender, EventArgs e)
        {
            string[] arrListStr = cbbSortDG.Text.Split(' ');
            string m1 = arrListStr[0];
            string m2 = arrListStr[1];
            dataGridViewDocGia.DataSource = QLDG_BLL.Instance.SortDG(m1, m2);
            
        }
    }
}