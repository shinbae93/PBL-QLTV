using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.BLL.DTO
{
    internal class PhieuMuon_DTO
    {
        public int MaPhieuMuon { get; set; }
        public string DocGia { get; set; }
        public string NguoiDung { get; set; }
        public System.DateTime NgayMuon { get; set; }
        public System.DateTime HanTra { get; set; }
        public Nullable<System.DateTime> NgayTra { get; set; }
        public string ViPham { get; set; }
    }
}