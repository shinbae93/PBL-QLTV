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
    
    public partial class PhieuMuon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuMuon()
        {
            this.TaiLieuCTs = new HashSet<TaiLieuCT>();
        }
    
        public int MaPhieuMuon { get; set; }
        public int ID { get; set; }
        public int MaDocGia { get; set; }
        public System.DateTime NgayMuon { get; set; }
        public System.DateTime HanTra { get; set; }
        public Nullable<System.DateTime> NgayTra { get; set; }
        public string ViPham { get; set; }
    
        public virtual DocGia DocGia { get; set; }
        public virtual NguoiDung NguoiDung { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaiLieuCT> TaiLieuCTs { get; set; }
    }
}
