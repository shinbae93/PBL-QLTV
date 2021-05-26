using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL.DAL;

namespace PBL.BLL
{
    internal class QLNV_BLL
    {
        private static QLNV_BLL _Instance;

        public static QLNV_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLNV_BLL();
                }
                return _Instance;
            }
            private set { }
        }

        private QLNV_BLL()
        {
        }
        
        public List<NguoiDung> GetListNV(string Name, string Email, string SDT, int ID_QuyenHan)
        {
            DHP_07Entities db = new DHP_07Entities();
            if (ID_QuyenHan == 0)
            {
                var weary = db.NguoiDungs
                .Where(p => p.HoTen.Contains(Name) && p.Email.Contains(Email) && p.DienThoai.Contains(SDT));
                return weary.ToList();
            }
            else
            {
                var weary = db.NguoiDungs
                .Where(p => p.HoTen.Contains(Name) && p.Email.Contains(Email) && p.DienThoai.Contains(SDT) && p.ID_QuyenHan == ID_QuyenHan);
                return weary.ToList();
            }
        }
        public void AddNV(NguoiDung s)
        {
            using (DHP_07Entities db = new DHP_07Entities())
            {
                db.NguoiDungs.Add(s);
                db.SaveChanges();
            }
        }
        public void EditNV(NguoiDung s, int ID_NguoiDung)
        {
            using (DHP_07Entities db = new DHP_07Entities())
            {
                NguoiDung s1 = db.NguoiDungs.Find(ID_NguoiDung);
                s1.Username = s.Username;
                s1.Password = s.Password;
                s1.HoTen = s.HoTen;
                s1.GioiTinh = s.GioiTinh;
                s1.NgaySinh = s.NgaySinh;
                s1.Email = s.Email;
                s1.DienThoai = s.DienThoai;
                s1.ID_QuyenHan = s.ID_QuyenHan;
                db.SaveChanges();
            }
        }
        public void DeleteNV(int ID_NguoiDung)
        {
            using (DHP_07Entities db = new DHP_07Entities())
            {
                NguoiDung s = db.NguoiDungs.Find(ID_NguoiDung);
                db.NguoiDungs.Remove(s);
                db.SaveChanges();
            }
        }
    }
}