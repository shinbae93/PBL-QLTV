using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL.BLL.DTO;
using PBL.DAL;

namespace PBL.BLL
{
    internal class QLPM_BLL
    {
        private static QLPM_BLL _Instance;

        public static QLPM_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLPM_BLL();
                }
                return _Instance;
            }
            private set { }
        }

        private QLPM_BLL()
        {
        }

        public bool CheckReturned(int MaPM)
        {
            using (DHP_07Entities db = new DHP_07Entities())
            {
                return (db.PhieuMuons.Find(MaPM).NgayTra != null);
            }
        }

        public List<PhieuMuon_DTO> GetListPM(string TenDG, string MSSV)
        {
            using (DHP_07Entities db = new DHP_07Entities())
            {
                List<PhieuMuon_DTO> data = db.PhieuMuons.Where(p => p.DocGia.HoTen.Contains(TenDG) && p.DocGia.MSSV.Contains(MSSV)).Select(p => new PhieuMuon_DTO
                {
                    MaPhieuMuon = p.MaPhieuMuon,
                    DocGia = p.DocGia.HoTen,
                    NguoiDung = p.NguoiDung.HoTen,
                    NgayMuon = p.NgayMuon,
                    HanTra = p.HanTra,
                    NgayTra = p.NgayTra,
                    ViPham = p.ViPham
                }).ToList();
                return data;
            }
        }

        public PhieuMuon GetPMByMaPM(int MaPM)
        {
            DHP_07Entities db = new DHP_07Entities();
            if (MaPM == 0) return null;
            return db.PhieuMuons.Where(p => p.MaPhieuMuon.Equals(MaPM)).FirstOrDefault();
        }

        public void AddPM(PhieuMuon s)
        {
            using (DHP_07Entities db = new DHP_07Entities())
            {
                db.PhieuMuons.Add(s);
                db.SaveChanges();
            }
        }

        public void EditPM(PhieuMuon s)
        {
            using (DHP_07Entities db = new DHP_07Entities())
            {
                PhieuMuon res = db.PhieuMuons.Find(s.MaPhieuMuon);
                res.ID = s.ID;
                res.HanTra = s.HanTra;
                res.MaDocGia = s.MaDocGia;
                res.NgayMuon = s.NgayMuon;
                res.NgayTra = s.NgayTra;
                res.MaPhieuMuon = s.MaPhieuMuon;
                res.ViPham = s.ViPham;
                db.SaveChanges();
            }
        }

        public void DeletePM(int MaPM)
        {
            using (DHP_07Entities db = new DHP_07Entities())
            {
                db.PhieuMuons.Remove(db.PhieuMuons.Find(MaPM));
                db.SaveChanges();
            }
        }

        public void TraPM(int MaPM, string VP, DateTime NgayTra)
        {
            using (DHP_07Entities db = new DHP_07Entities())
            {
                PhieuMuon res = db.PhieuMuons.Find(MaPM);
                res.ViPham = VP;
                res.NgayTra = NgayTra;
                foreach (TaiLieuCT i in res.TaiLieuCTs)
                {
                    TaiLieu a = db.TaiLieux.Find(i.CuonTaiLieu.MaTL);
                    ++a.SoLuong;
                    QLTL_BLL.Instance.AddCTL(a.MaTL, 1);
                }
                db.SaveChanges();
            }
        }

        public void TraSLTL(List<TaiLieu_DTO> data)
        {
            using (DHP_07Entities db = new DHP_07Entities())
            {
                foreach (TaiLieu_DTO i in data)
                {
                    TaiLieu s = db.TaiLieux.Find(i.MaTL);
                    s.SoLuong++;
                }
                db.SaveChanges();
            }
        }

        public List<PhieuMuon_DTO> SortPM(string TC)
        {
            using (DHP_07Entities db = new DHP_07Entities())
            {
                List<PhieuMuon_DTO> data = db.PhieuMuons.Select(p => new PhieuMuon_DTO
                {
                    MaPhieuMuon = p.MaPhieuMuon,
                    DocGia = p.DocGia.HoTen,
                    NguoiDung = p.NguoiDung.HoTen,
                    NgayMuon = p.NgayMuon,
                    HanTra = p.HanTra,
                    NgayTra = p.NgayTra,
                    ViPham = p.ViPham
                }).ToList();
                if (TC == "MaPM (Tang)")
                {
                    return data.OrderBy(p => p.MaPhieuMuon).ToList();
                }
                else if (TC == "MaPM (Giam)")
                {
                    return data.OrderByDescending(p => p.MaPhieuMuon).ToList();
                }
                else if (TC == "DocGia (Tang)")
                {
                    return data.OrderBy(p => p.DocGia).ToList();
                }
                else if (TC == "DocGia (Giam)")
                {
                    return data.OrderByDescending(p => p.DocGia).ToList();
                }
                else if (TC == "NguoiDung (Tang)")
                {
                    return data.OrderBy(p => p.NguoiDung).ToList();
                }
                else if (TC == "NguoiDung (Giam)")
                {
                    return data.OrderByDescending(p => p.NguoiDung).ToList();
                }
                else if (TC == "NgayMuon (Tang)")
                {
                    return data.OrderBy(p => p.NgayMuon).ToList();
                }
                else if (TC == "NgayMuon (Giam)")
                {
                    return data.OrderByDescending(p => p.NgayMuon).ToList();
                }
                else if (TC == "HanTra (Tang)")
                {
                    return data.OrderBy(p => p.HanTra).ToList();
                }
                else if (TC == "HanTra (Giam)")
                {
                    return data.OrderByDescending(p => p.HanTra).ToList();
                }
                else if (TC == "NgayTra (Tang)")
                {
                    return data.OrderBy(p => p.NgayTra).ToList();
                }
                else if (TC == "NgayTra (Giam)")
                {
                    return data.OrderByDescending(p => p.NgayTra).ToList();
                }
                return data;
            }
        }
    }
}