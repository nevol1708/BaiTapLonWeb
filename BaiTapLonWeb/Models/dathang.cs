//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BaiTapLonWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class dathang
    {
        public string MaDH { get; set; }
        public string MaKH { get; set; }
        public string MaSP { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public string Size { get; set; }
        public string DiaChiDH { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
    
        public virtual khachhang khachhang { get; set; }
        public virtual sanpham sanpham { get; set; }
    }
}
