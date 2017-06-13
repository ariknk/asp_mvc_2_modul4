using Asp_mvc_2.Models.EntityManager;
using Asp_mvc_2.Models.ViewModel;
using Asp_mvc_2.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Asp_mvc_2.Models.ViewModel;

namespace Asp_mvc_2.Controllers
{
    public class LaporanController : Controller
    {
        // GET: Laporan
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
        public ActionResult Add(TambahLaporanModel TPM)
        {
            if (ModelState.IsValid)
            {
                LaporanManager PM = new LaporanManager();
                PM.TambahLaporan(TPM);
                return RedirectToAction("Welcome", "Home");
            }
            return View();
        }
    }
}