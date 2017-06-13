using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Asp_mvc_2.Models.ViewModel
{
    public class TambahLaporanModel
    {
        [Key]
        public int id_laporan { get; set; }
        public int id_buku { get; set; }
        public int id_pelanggan { get; set; }
        public string keterangan { get; set; }
        public DateTime tanggal { get; set; }
        public int debet { get; set; }
        public int kredit { get; set; }
        public int saldo { get; set; }



    }
}