using Asp_mvc_2.Models.DB;
using Asp_mvc_2.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asp_mvc_2.Models.EntityManager
{
    public class PelangganManager
    {
        public void TambahPelanggan(TambahPelangganModel PelangganModel)
        {
            using (DemoDBEntities db = new DemoDBEntities())
            {
                pelanggan p = new pelanggan();
                p.alamat = PelangganModel.alamat;
                p.id_pelanggan = PelangganModel.id_pelanggan;
                p.nama = PelangganModel.nama;
                p.no_id = PelangganModel.no_id;
                p.no_tlp2 = PelangganModel.no_tlp2;
                p.no_tlp1 = PelangganModel.no_tlp1;
           
                

                db.pelanggans.Add(p);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex) {
                    String x = "";
                    foreach (var y in db.GetValidationErrors())
                    {
                        x = x + y.ValidationErrors.First().PropertyName + " " + y.ValidationErrors.First().ErrorMessage;
                    }
                    throw new Exception(x);
                }
            }

        }
    }
}