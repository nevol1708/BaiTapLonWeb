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
    
    public partial class sanpham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sanpham()
        {
            this.chitietHDBs = new HashSet<chitietHDB>();
            this.chitietHDNs = new HashSet<chitietHDN>();
            this.dathangs = new HashSet<dathang>();
        }
    
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string MaNSX { get; set; }
        public Nullable<int> GiaNhap { get; set; }
        public Nullable<int> GiaBan { get; set; }
        public string XuatXu { get; set; }
        public string BaoHanh { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chitietHDB> chitietHDBs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chitietHDN> chitietHDNs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dathang> dathangs { get; set; }
        public virtual hinhanh hinhanh { get; set; }
        public virtual nhasx nhasx { get; set; }
        public virtual soluong soluong { get; set; }
    }
}
