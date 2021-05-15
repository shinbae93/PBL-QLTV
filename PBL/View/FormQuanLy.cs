﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL.DAL;

namespace PBL.View
{
    public partial class FormQuanLy : Form
    {
        public FormQuanLy()
        {
            InitializeComponent();
            SetCBB();
        }

        private void SetCBB()
        {
            DHP07Entities db = new DHP07Entities();
            cbbLoaiTL.Items.Add(new CBBItem { Value = null, Text = "ALL" });
            cbbLoaiTL.Text = "ALL";
            foreach (LoaiTaiLieu i in db.LoaiTaiLieux)
            {
                cbbLoaiTL.Items.Add(new CBBItem { Value = i.MaLTL, Text = i.TenLoai });
            }
        }

        private void ShowSach()
        {
        }

        private void ShowPM()
        {
        }

        private void ShowDG()
        {
        }

        private void ShowNV()
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
    }
}