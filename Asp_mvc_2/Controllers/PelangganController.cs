using Asp_mvc_2.Models.EntityManager;
using Asp_mvc_2.Models.ViewModel;
using Asp_mvc_2.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asp_mvc_2.Controllers
{
    public class PelangganController : Controller
    {
        // GET: Pelanggan
        public ActionResult Index()
        {
            return View();
        }

        [AuthorizeRole("Admin")]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [AuthorizeRole("Admin")]
        public ActionResult Add(TambahPelangganModel TPM)
        {
            if (ModelState.IsValid)
            {
                PelangganManager PM = new PelangganManager();
                PM.TambahPelanggan(TPM);
                return RedirectToAction("Welcome", "Home");
            }
            return View();
        }
    }
}