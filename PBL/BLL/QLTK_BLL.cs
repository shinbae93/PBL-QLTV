using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL.BLL.DTO;
using PBL.DAL;

namespace PBL.BLL
{
    internal class QLTK_BLL
    {
        private static QLTK_BLL _Instance;

        public static QLTK_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLTK_BLL();
                }
                return _Instance;
            }
            private set { }
        }

        private QLTK_BLL()
        {
        }

        public List<PhieuMuon_DTO> GetListVP(string MSSV, string HoTen)
        {
            using (DHP_07Entities db = new DHP_07Entities())
            {
                List<PhieuMuon_DTO> data = db.PhieuMuons.Where(p => p.DocGia.HoTen.Contains(HoTen) && p.DocGia.MSSV.Contains(MSSV) && p.ViPham != null && p.ViPham != "").Select(p => new PhieuMuon_DTO
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

        public List<PhieuMuon_DTO> GetTKMS(int Month, int Year)
        {
            using (DHP_07Entities db = new DHP_07Entities())
            {
                List<PhieuMuon_DTO> data = new List<PhieuMuon_DTO>();
                data = db.PhieuMuons.Where(p => (p.NgayMuon.Month == Month || Month == 0) && (p.NgayMuon.Year == Year || Year == 0)).Select(p => new PhieuMuon_DTO
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

        public List<PhieuMuon_DTO> GetTKVP(int Month, int Year)
        {
            using (DHP_07Entities db = new DHP_07Entities())
            {
                List<PhieuMuon_DTO> data = new List<PhieuMuon_DTO>();
                data = db.PhieuMuons.Where(p => (p.NgayMuon.Month == Month || Month == 0) && (p.NgayMuon.Year == Year || Year == 0) && p.ViPham != null && p.ViPham != "").Select(p => new PhieuMuon_DTO
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
    }
}