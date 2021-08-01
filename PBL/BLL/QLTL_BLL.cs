using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL.DAL;
using System.Data;
using PBL.BLL.DTO;

namespace PBL.BLL
{
    public class QLTL_BLL
    {
        private static QLTL_BLL _Instance;

        public static QLTL_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLTL_BLL();
                }
                return _Instance;
            }
            private set { }
        }

        private QLTL_BLL()
        {
        }

        public void AddCTL(string MaTL, int Num)
        {
            using (DHP_07Entities db = new DHP_07Entities())
            {
                for (int i = 0; i < Num; ++i)
                {
                    db.CuonTaiLieux.Add(new CuonTaiLieu { MaTL = MaTL });
                }
                db.SaveChanges();
            }
        }

        public void DeleteCTL(string MaTL, int Num)
        {
            using (DHP_07Entities db = new DHP_07Entities())
            {
                for (int i = 0; i < Num; ++i)
                {
                    db.CuonTaiLieux.Remove(db.CuonTaiLieux.Find(MaTL));
                }
                db.SaveChanges();
            }
        }

        public List<int> GetListMaCTL(string MaTL, int Num)
        {
            DHP_07Entities db = new DHP_07Entities();
            List<int> data = new List<int>();
            CuonTaiLieu tmp = db.CuonTaiLieux.Where(p => p.MaTL == MaTL).FirstOrDefault();
            for (int i = 0; i < Num; ++i)
            {
                data.Add(tmp.MaVach + i);
            }
            return data;
        }

        public void AddTLCT(List<int> data, int MaPM)
        {
            using (DHP_07Entities db = new DHP_07Entities())
            {
                PhieuMuon s = db.PhieuMuons.Find(MaPM);
                foreach (int i in data)
                {
                    db.TaiLieuCTs.Add(new TaiLieuCT
                    {
                        MaPhieuMuon = s.MaPhieuMuon,
                        MaVach = i,
                        TinhTrang = ""
                    });
                }
                db.SaveChanges();
            }
        }

        public void GiamSL(string MaTL, int Num)
        {
            using (DHP_07Entities db = new DHP_07Entities())
            {
                TaiLieu s = db.TaiLieux.Find(MaTL);
                s.SoLuong -= Num;
                db.SaveChanges();
            }
        }

        public List<TaiLieu_DTO> GetListTL(string TenTL, int MaLTL)
        {
            using (DHP_07Entities db = new DHP_07Entities())
            {
                List<TaiLieu_DTO> data = null;
                if (MaLTL == 0)
                {
                    data = db.TaiLieux.Where(p => p.TenTL.Contains(TenTL)).Select(p => new TaiLieu_DTO
                    {
                        MaTL = p.MaTL,
                        TenTL = p.TenTL,
                        NgonNgu = p.NgonNgu.TenNgonNgu,
                        TacGia = p.TacGia,
                        NhaXuatBan = p.NhaXuatBan.TenNXB,
                        NamXuatBan = p.NamXuatBan,
                        LoaiTaiLieu = p.LoaiTaiLieu.TenLoai,
                        SoLuong = p.SoLuong
                    }).ToList();
                }
                else
                {
                    data = db.TaiLieux.Where(p => p.TenTL.Contains(TenTL) && p.MaLTL == MaLTL).Select(p => new TaiLieu_DTO
                    {
                        MaTL = p.MaTL,
                        TenTL = p.TenTL,
                        NgonNgu = p.NgonNgu.TenNgonNgu,
                        TacGia = p.TacGia,
                        NhaXuatBan = p.NhaXuatBan.TenNXB,
                        NamXuatBan = p.NamXuatBan,
                        LoaiTaiLieu = p.LoaiTaiLieu.TenLoai,
                        SoLuong = p.SoLuong
                    }).ToList();
                }
                return data;
            }
        }

        public TaiLieu GetTLByMaTL(string MaTL)
        {
            DHP_07Entities db = new DHP_07Entities();
            if (MaTL == null) return null;
            return db.TaiLieux.Where(p => p.MaTL.Equals(MaTL)).FirstOrDefault();
        }

        public void AddTL(TaiLieu s)
        {
            using (DHP_07Entities db = new DHP_07Entities())
            {
                db.TaiLieux.Add(s);
                db.SaveChanges();
                Instance.AddCTL(s.MaTL, (int)s.SoLuong);
            }
        }

        public void EditTL(TaiLieu s)
        {
            using (DHP_07Entities db = new DHP_07Entities())
            {
                TaiLieu res = db.TaiLieux.Find(s.MaTL);
                if (s.SoLuong > res.SoLuong) Instance.AddCTL(s.MaTL, (int)(s.SoLuong - res.SoLuong));
                else if (s.SoLuong < res.SoLuong) Instance.DeleteCTL(s.MaTL, (int)(res.SoLuong - s.SoLuong));
                res.TenTL = s.TenTL;
                res.MaLTL = s.MaLTL;
                res.MaNgonNgu = s.MaNgonNgu;
                res.MaNXB = s.MaNXB;
                res.NamXuatBan = s.NamXuatBan;
                res.SoLuong = s.SoLuong;
                res.TacGia = s.TacGia;
                db.SaveChanges();
            }
        }

        public void DeleteTL(string MaTL)
        {
            using (DHP_07Entities db = new DHP_07Entities())
            {
                db.TaiLieux.Remove(db.TaiLieux.Find(MaTL));
                db.SaveChanges();
            }
        }

        public List<TaiLieu_DTO> SortTL(string TC)
        {
            using (DHP_07Entities db = new DHP_07Entities())
            {
                List<TaiLieu_DTO> data = db.TaiLieux.Select(p => new TaiLieu_DTO
                {
                    MaTL = p.MaTL,
                    TenTL = p.TenTL,
                    NgonNgu = p.NgonNgu.TenNgonNgu,
                    TacGia = p.TacGia,
                    NhaXuatBan = p.NhaXuatBan.TenNXB,
                    NamXuatBan = p.NamXuatBan,
                    LoaiTaiLieu = p.LoaiTaiLieu.TenLoai,
                    SoLuong = p.SoLuong
                }).ToList();
                if (TC == "MaTL (Tang)")
                {
                    return data.OrderBy(p => p.MaTL).ToList();
                }
                else if (TC == "MaTL (Giam)")
                {
                    return data.OrderByDescending(p => p.MaTL).ToList();
                }
                else if (TC == "TenTL (Tang)")
                {
                    return data.OrderBy(p => p.TenTL).ToList();
                }
                else if (TC == "TenTL (Giam)")
                {
                    return data.OrderByDescending(p => p.TenTL).ToList();
                }
                else if (TC == "LoaiTL (Tang)")
                {
                    return data.OrderBy(p => p.LoaiTaiLieu).ToList();
                }
                else if (TC == "LoaiTL (Giam)")
                {
                    return data.OrderByDescending(p => p.LoaiTaiLieu).ToList();
                }
                else if (TC == "Tac Gia (Tang)")
                {
                    return data.OrderBy(p => p.TacGia).ToList();
                }
                else if (TC == "Tac Gia (Giam)")
                {
                    return data.OrderByDescending(p => p.TacGia).ToList();
                }
                else if (TC == "NXB (Tang)")
                {
                    return data.OrderBy(p => p.NhaXuatBan).ToList();
                }
                else if (TC == "NXB (Giam)")
                {
                    return data.OrderByDescending(p => p.NhaXuatBan).ToList();
                }
                else if (TC == "Ngon Ngu (Tang)")
                {
                    return data.OrderBy(p => p.NgonNgu).ToList();
                }
                else if (TC == "Ngon Ngu (Giam)")
                {
                    return data.OrderByDescending(p => p.NgonNgu).ToList();
                }
                return data;
            }
        }
    }
}