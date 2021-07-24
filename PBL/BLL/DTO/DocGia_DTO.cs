using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.BLL.DTO
{
    internal class DocGia_DTO
    {
        public string MSSV { get; set; }
        public string HoTen { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public Nullable<bool> GioiTinh { get; set; }
        public string TenLop { get; set; }
        public System.DateTime NgayDK { get; set; }
    }
}