using Asp_mvc_2.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Asp_mvc_2.Models.ViewModel;

namespace Asp_mvc_2.Models.EntityManager
{
    public class LaporanManager
    {
        public void TambahLaporan(TambahLaporanModel LaporanModel)
        {
            using (DemoDBEntities db = new DemoDBEntities())
            {
                laporan l = new laporan();
                l.id_laporan = LaporanModel.id_laporan;
                l.id_buku = LaporanModel.id_buku;
                l.id_pelanggan = LaporanModel.id_pelanggan;
                l.keterangan = LaporanModel.keterangan;
                l.kredit = LaporanModel.kredit;
                l.saldo = LaporanModel.saldo;
                l.debet = LaporanModel.debet;
                l.tanggal = LaporanModel.tanggal;

                db.laporans.Add(l);
                db.SaveChanges();
            }

        }
    }
}