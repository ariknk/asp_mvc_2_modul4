//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Asp_mvc_2.Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public partial class buku
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public buku()
        {
            this.laporans = new HashSet<laporan>();
        }
        
        [Key]
        public int id_buku { get; set; }
        public string ISBN { get; set; }
        public string judul { get; set; }
        public string penulis { get; set; }
        public string penerbit { get; set; }
        public int tahun { get; set; }
        public int stok { get; set; }
        public int harga_beli { get; set; }
        public int harga_jual { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<laporan> laporans { get; set; }
    }
}
