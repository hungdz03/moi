//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TinhThanh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TinhThanh()
        {
            this.KhachSans = new HashSet<KhachSan>();
        }
    
        public int IDTinhThanh { get; set; }
        public Nullable<int> IDHinhAnh { get; set; }
        public string MaTinh { get; set; }
        public string TenTinh { get; set; }
        public string GhiChu { get; set; }
        public Nullable<bool> IsDelete { get; set; }
    
        public virtual HinhAnh HinhAnh { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhachSan> KhachSans { get; set; }
    }
}
