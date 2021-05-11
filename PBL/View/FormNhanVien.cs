﻿using PBL.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
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

        private void btnAddPM_Click(object sender, EventArgs e)
        {
            FormAddDuLieuPhieuMuon f = new FormAddDuLieuPhieuMuon();
            //f.d = new Form2.MyDel(this.Show);
            f.ShowDialog();
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FormLogOut f = new FormLogOut();
            f.ShowDialog();
        }

        private void btnRenderPM_Click(object sender, EventArgs e)
        {
            FormTraDuLieuPhieuMuon f = new FormTraDuLieuPhieuMuon();
            f.ShowDialog();
        }

        private void btnEditPM_Click(object sender, EventArgs e)
        {
            FormDuLieuPhieuMuon f = new FormDuLieuPhieuMuon(null);
            f.ShowDialog();
        }
    }
}
