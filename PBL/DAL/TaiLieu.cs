//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PBL.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TaiLieu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TaiLieu()
        {
            this.CuonTaiLieux = new HashSet<CuonTaiLieu>();
            this.LoaiTaiLieux = new HashSet<LoaiTaiLieu>();
            this.TaiLieuCTs = new HashSet<TaiLieuCT>();
        }
    
        public string MaTL { get; set; }
        public string TenTL { get; set; }
        public string MaNgonNgu { get; set; }
        public string MaTacGia { get; set; }
        public System.DateTime NamXuatBan { get; set; }
        public System.DateTime NgayCN { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CuonTaiLieu> CuonTaiLieux { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoaiTaiLieu> LoaiTaiLieux { get; set; }
        public virtual NgonNgu NgonNgu { get; set; }
        public virtual TacGia TacGia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaiLieuCT> TaiLieuCTs { get; set; }
    }
}
