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
    
    public partial class TaiLieuCT
    {
        public int MaPhieuMuon { get; set; }
        public int MaVach { get; set; }
        public string TinhTrang { get; set; }
    
        public virtual CuonTaiLieu CuonTaiLieu { get; set; }
        public virtual PhieuMuon PhieuMuon { get; set; }
    }
}
