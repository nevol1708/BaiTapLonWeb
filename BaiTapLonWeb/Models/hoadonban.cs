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
    
    public partial class hoadonban
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hoadonban()
        {
            this.chitietHDBs = new HashSet<chitietHDB>();
        }
    
        public string MaHDB { get; set; }
        public string MaKH { get; set; }
        public Nullable<System.DateTime> NgayBan { get; set; }
        public Nullable<int> TongTien { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chitietHDB> chitietHDBs { get; set; }
        public virtual khachhang khachhang { get; set; }
    }
}
