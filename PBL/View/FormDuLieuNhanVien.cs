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
using System.Text.RegularExpressions;

namespace PBL.View
{
    public partial class FormDuLieuNhanVien : Form
    {
        public delegate void MyDel(string HoTen, string Email, string SDT, int ID_QuyenHan);

        public MyDel d { get; set; }
        public int ID_NguoiDung { get; set; }

        public FormDuLieuNhanVien(int ID)
        {
            InitializeComponent();
            ID_NguoiDung = ID;
            SetCBB();
            SetGUI();
        }

        #region Method

        public void SetCBB()
        {
            DHP_07Entities db = new DHP_07Entities();
            foreach (QuyenHan i in db.QuyenHans)
            {
                cbbQuyenHan.Items.Add(new CBBItem { Value = i.ID_QuyenHan, Text = i.TenQuyenHan });
            }
        }

        public void SetGUI()
        {
            DHP_07Entities db = new DHP_07Entities();
            if (ID_NguoiDung != 0)
            {
                NguoiDung s = db.NguoiDungs.Find(ID_NguoiDung);
                txtUser.Text = s.Username;
                txtPassword.Text = s.Password;
                txtHoTen.Text = s.HoTen;
                txtDienThoai.Text = s.DienThoai;
                txtEmail.Text = s.Email;
                dateTimePicker1.Value = s.NgaySinh.Value;
                if (s.GioiTinh == true)
                {
                    rbtnNam.Checked = true;
                }
                else
                {
                    rbtnNu.Checked = true;
                }
                cbbQuyenHan.SelectedIndex = s.ID_QuyenHan - 1;
                txtUser.Enabled = false;
            }
        }

        #endregion Method

        #region Event

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtEmail.Text == "" || txtDienThoai.Text == "" || txtPassword.Text == "" || txtHoTen.Text == "" || cbbQuyenHan.SelectedIndex == -1 || rbtnNam.Checked == rbtnNu.Checked)
            {
                MessageBox.Show("Vui long dien du thong tin !");
            }
            else if (QLNV_BLL.Instance.CheckUsername(txtUser.Text) && ID_NguoiDung == 0)
            {
                MessageBox.Show("Username da ton tai !");
            }
            else if (!Regex.Match(txtDienThoai.Text, @"^([0][0-9]{9})$").Success)
            {
                MessageBox.Show("So dien thoai khong hop le !");
            }
            else if (QLNV_BLL.Instance.CheckPhoneNumber(txtDienThoai.Text) && ID_NguoiDung == 0)
            {
                MessageBox.Show("So dien thoai da ton tai !");
            }
            else if (!Regex.Match(txtEmail.Text, @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@"
                                               + @"((([\-\w]+\.)+[a-zA-Z]{2,4}))\z").Success)
            {
                MessageBox.Show("Email khong hop le !");
            }
            else if (QLNV_BLL.Instance.CheckEmail(txtEmail.Text) && ID_NguoiDung == 0)
            {
                MessageBox.Show("Email da ton tai !");
            }
            else
            {
                NguoiDung s = new NguoiDung
                {
                    Username = txtUser.Text,
                    Password = txtPassword.Text,
                    HoTen = txtHoTen.Text,
                    NgaySinh = dateTimePicker1.Value,
                    DienThoai = txtDienThoai.Text,
                    Email = txtEmail.Text,
                    GioiTinh = rbtnNam.Checked,
                    ID_QuyenHan = ((CBBItem)cbbQuyenHan.SelectedItem).Value
                };
                if (ID_NguoiDung == 0)
                {
                    QLNV_BLL.Instance.AddNV(s);
                }
                else
                {
                    QLNV_BLL.Instance.EditNV(s, ID_NguoiDung);
                }
                d("", "", "", 0);
                this.Dispose();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        #endregion Event
    }
}