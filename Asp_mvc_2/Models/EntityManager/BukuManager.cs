using Asp_mvc_2.Models.DB;
using Asp_mvc_2.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asp_mvc_2.Models.EntityManager
{
    public class BukuManager
    {
        public void TambahBuku(TambahBukuModel bukuModel)
        {
            using (DemoDBEntities db = new DemoDBEntities()) {
                buku b = new buku();
                b.harga_beli = bukuModel.harga_beli;
                b.harga_jual = bukuModel.harga_jual;
                b.id_buku = bukuModel.id_buku;
                b.ISBN = bukuModel.ISBN;
                b.judul = bukuModel.judul;
                b.penerbit = bukuModel.penerbit;
                b.penulis = bukuModel.penulis;
                b.stok = bukuModel.stok;
                b.tahun = bukuModel.tahun;

                db.bukus.Add(b);
                db.SaveChanges();
            }

        }

        public List<TambahBukuModel> GetBukuData()
        {
            using (DemoDBEntities db = new DemoDBEntities())
            {
                var buku = db.bukus.Select(b => new TambahBukuModel
                {
                    harga_beli = b.harga_beli,
                    harga_jual = b.harga_jual,
                    id_buku = b.id_buku,
                    ISBN = b.ISBN,
                    judul = b.judul,
                    penerbit = b.penerbit,
                    penulis = b.penulis,
                    stok = b.stok,
                    tahun = b.tahun,
                }).ToList();
                return buku;
            }
        }

    }
}