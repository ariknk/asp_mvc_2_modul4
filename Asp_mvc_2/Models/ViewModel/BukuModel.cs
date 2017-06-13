using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Asp_mvc_2.Models.ViewModel
{
    public class TambahBukuModel
    {
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

    }

    public class BukuDataView
    {
        public IEnumerable<TambahBukuModel> BukuProfile { get; set; }
    }

}