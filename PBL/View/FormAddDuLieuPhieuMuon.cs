using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL.DAL;
using PBL.BLL;
using PBL.BLL.DTO;

namespace PBL.View
{
    public partial class FormAddDuLieuPhieuMuon : Form
    {
        public delegate void MyDel(string TenDG, string MSSV);

        public MyDel d { get; set; }
        public string Username { get; set; }
        public List<TaiLieu_DTO> data { get; set; }
        public List<int> ListMaCTL { get; set; }

        public FormAddDuLieuPhieuMuon(string Username)
        {
            data = new List<TaiLieu_DTO>();
            InitializeComponent();
            SetCBB();
            this.Username = Username;
        }

        private void SetCBB()
        {
            using (DHP_07Entities db = new DHP_07Entities())
            {
                foreach (TaiLieu i in db.TaiLieux)
                {
                    cbbTL.Items.Add(new CBBItem_TL { Value = i.MaTL, Text = i.TenTL });
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            PhieuMuon s = new PhieuMuon()
            {
                ID = QLNV_BLL.Instance.GetUserByUsername(Username).ID,
                MaDocGia = QLDG_BLL.Instance.GetDGByMSSV(txtSoThe.Text).MaDocGia,
                NgayMuon = dtpNgayMuon.Value,
                HanTra = dtpHanTra.Value
            };
            QLPM_BLL.Instance.AddPM(s);
            QLTL_BLL.Instance.AddTLCT(ListMaCTL, s.MaPhieuMuon);
            d(s.DocGia.HoTen, s.DocGia.MSSV);
            this.Dispose();
        }

        private void btnAddTL_Click(object sender, EventArgs e)
        {
            TaiLieu s = QLTL_BLL.Instance.GetTLByMaTL(((CBBItem_TL)cbbTL.SelectedItem).Value);
            if ((int)numSLTL.Value >= s.SoLuong) MessageBox.Show("Vượt quá số lượng cho phép !");
            else
            {
                for (int i = 0; i < (int)numSLTL.Value; ++i)
                {
                    data.Add(new TaiLieu_DTO
                    {
                        MaTL = s.MaTL,
                        TenTL = s.TenTL,
                        TacGia = s.TacGia,
                        LoaiTaiLieu = s.LoaiTaiLieu.TenLoai,
                        NgonNgu = s.NgonNgu.TenNgonNgu,
                        NhaXuatBan = s.NhaXuatBan.TenNXB,
                        NamXuatBan = s.NamXuatBan,
                        SoLuong = s.SoLuong - 1
                    });
                }
                ListMaCTL = QLTL_BLL.Instance.GetListMaCTL(s.MaTL, (int)numSLTL.Value);
                QLTL_BLL.Instance.GiamSL(((CBBItem_TL)cbbTL.SelectedItem).Value, (int)numSLTL.Value);
                dgvTL.DataSource = null;
                dgvTL.DataSource = data;
            }
        }
    }
}