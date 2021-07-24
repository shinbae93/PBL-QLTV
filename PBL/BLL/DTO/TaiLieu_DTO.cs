using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.BLL.DTO
{
    public class TaiLieu_DTO
    {
        public string MaTL { get; set; }
        public string TenTL { get; set; }
        public System.DateTime NamXuatBan { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public string TacGia { get; set; }
        public string LoaiTaiLieu { get; set; }
        public string NgonNgu { get; set; }
        public string NhaXuatBan { get; set; }
    }
}