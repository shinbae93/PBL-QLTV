using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL.DAL;
using PBL.BLL.DTO;

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

        public List<NhanVien_DTO> GetListNV(string Name, string Email, string SDT, int ID_QuyenHan)
        {
            DHP_07Entities db = new DHP_07Entities();
            List<NhanVien_DTO> data = new List<NhanVien_DTO>();
            if (ID_QuyenHan == 0)
            {
                data = db.NguoiDungs.Where(p => p.HoTen.Contains(Name) && p.Email.Contains(Email) && p.DienThoai.Contains(SDT))
                .Select(p => new NhanVien_DTO
                {
                    ID = p.ID,
                    Username = p.Username,
                    Password = p.Password,
                    HoTen = p.HoTen,
                    NgaySinh = p.NgaySinh,
                    GioiTinh = p.GioiTinh,
                    DienThoai = p.DienThoai,
                    Email = p.Email,
                    QuyenHan = p.QuyenHan.TenQuyenHan
                }).ToList();
            }
            else
            {
                data = db.NguoiDungs.Where(p => p.HoTen.Contains(Name) && p.Email.Contains(Email) && p.DienThoai.Contains(SDT) && p.ID_QuyenHan == ID_QuyenHan)
                .Select(p => new NhanVien_DTO
                {
                    ID = p.ID,
                    Username = p.Username,
                    Password = p.Password,
                    HoTen = p.HoTen,
                    NgaySinh = p.NgaySinh,
                    GioiTinh = p.GioiTinh,
                    DienThoai = p.DienThoai,
                    Email = p.Email,
                    QuyenHan = p.QuyenHan.TenQuyenHan
                }).ToList();
            }
            return data;
        }

        public NguoiDung GetUserByUsername(string Username)
        {
            using (DHP_07Entities db = new DHP_07Entities())
            {
                NguoiDung data = db.NguoiDungs.Where(p => p.Username.Equals(Username)).FirstOrDefault();
                return data;
            }
        }

        public bool CheckUsername(string Username)
        {
            using (DHP_07Entities db = new DHP_07Entities())
            {
                return db.NguoiDungs.Any(p => p.Username == Username);
            }
        }

        public bool CheckEmail(string email)
        {
            using (DHP_07Entities db = new DHP_07Entities())
            {
                return db.NguoiDungs.Any(p => p.Email == email);
            }
        }

        public bool CheckPhoneNumber(string num)
        {
            using (DHP_07Entities db = new DHP_07Entities())
            {
                return db.NguoiDungs.Any(p => p.DienThoai == num);
            }
        }

        public void ChangePass(NguoiDung nd, string Pass)
        {
            using (DHP_07Entities db = new DHP_07Entities())
            {
                var l1 = db.NguoiDungs
                    .Single(p => p.ID == nd.ID);
                l1.Password = Pass;
                db.SaveChanges();
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

        public void EditHoTenNV(NguoiDung s, int ID_NguoiDung, string ten)
        {
            using (DHP_07Entities db = new DHP_07Entities())
            {
                NguoiDung s1 = db.NguoiDungs.Find(ID_NguoiDung);
                s1.HoTen = ten;
                db.SaveChanges();
            }
        }

        public void EditNgaySinhNV(NguoiDung s, int ID_NguoiDung, DateTime ngay)
        {
            using (DHP_07Entities db = new DHP_07Entities())
            {
                NguoiDung s1 = db.NguoiDungs.Find(ID_NguoiDung);
                s1.NgaySinh = ngay;
                db.SaveChanges();
            }
        }

        public void EditEmailNV(NguoiDung s, int ID_NguoiDung, string email)
        {
            using (DHP_07Entities db = new DHP_07Entities())
            {
                NguoiDung s1 = db.NguoiDungs.Find(ID_NguoiDung);
                s1.Email = email;
                db.SaveChanges();
            }
        }

        public void EditSDTNV(NguoiDung s, int ID_NguoiDung, string sdt)
        {
            using (DHP_07Entities db = new DHP_07Entities())
            {
                NguoiDung s1 = db.NguoiDungs.Find(ID_NguoiDung);
                s1.DienThoai = sdt;
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

        public List<NhanVien_DTO> SortNV(string TC)
        {
            using (DHP_07Entities db = new DHP_07Entities())
            {
                List<NhanVien_DTO> data = db.NguoiDungs.Select(p => new NhanVien_DTO
                {
                    ID = p.ID,
                    Username = p.Username,
                    Password = p.Password,
                    HoTen = p.HoTen,
                    NgaySinh = p.NgaySinh,
                    GioiTinh = p.GioiTinh,
                    DienThoai = p.DienThoai,
                    Email = p.Email,
                    QuyenHan = p.QuyenHan.TenQuyenHan
                }).ToList();
                if (TC == "ID (Tang)")
                {
                    return data.OrderBy(p => p.ID).ToList();
                }
                else if (TC == "ID (Giam)")
                {
                    return data.OrderByDescending(p => p.ID).ToList();
                }
                else if (TC == "Username (Tang)")
                {
                    return data.OrderBy(p => p.Username).ToList();
                }
                else if (TC == "Username (Giam)")
                {
                    return data.OrderByDescending(p => p.Username).ToList();
                }
                else if (TC == "HoTen (Tang)")
                {
                    return data.OrderBy(p => p.HoTen).ToList();
                }
                else if (TC == "HoTen (Giam)")
                {
                    return data.OrderByDescending(p => p.HoTen).ToList();
                }
                else if (TC == "NgaySinh (Tang)")
                {
                    return data.OrderBy(p => p.NgaySinh).ToList();
                }
                else if (TC == "NgaySinh (Giam)")
                {
                    return data.OrderByDescending(p => p.NgaySinh).ToList();
                }
                else if (TC == "GioiTinh (Tang)")
                {
                    return data.OrderBy(p => p.GioiTinh).ToList();
                }
                else if (TC == "GioiTinh (Giam)")
                {
                    return data.OrderByDescending(p => p.GioiTinh).ToList();
                }
                else if (TC == "QuyenHan (Tang)")
                {
                    return data.OrderBy(p => p.QuyenHan).ToList();
                }
                else if (TC == "QuyenHan (Giam)")
                {
                    return data.OrderByDescending(p => p.QuyenHan).ToList();
                }
                return data;
            }
        }
    }
}