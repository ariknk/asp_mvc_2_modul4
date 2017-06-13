using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Asp_mvc_2.Models.ViewModel
{
    public class TambahPelangganModel
    {
        [Key]
        public int id_pelanggan { get; set; }

        public string no_id { get; set; }
        public string nama { get; set; }
        public string alamat { get; set; }
        public string no_tlp1 { get; set; }
         public string no_tlp2 { get; set; }

    }
}