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
    public class BukuController : Controller
    {
        // GET: Buku
        public ActionResult Index()
        {
            return View();
        }

        
        [AuthorizeRole("Admin")]
        public ActionResult Add() {
            return View();
        }

        [HttpPost]
        [AuthorizeRole("Admin")]
        public ActionResult Add(TambahBukuModel TBM) {
            if (ModelState.IsValid)
            {
                BukuManager BM = new BukuManager();
                BM.TambahBuku(TBM);
                return RedirectToAction("Welcome", "Home");
            }
            return View();
        }

        public ActionResult ManageBukuPartial(string status="")
        {
            string loginName = User.Identity.Name;
            BukuManager BM = new BukuManager();
            BukuDataView BDV = new BukuDataView();
            BDV.BukuProfile = BM.GetBukuData();
            string message = string.Empty;
            if (status.Equals("update"))
                message = "Update Sukses";
            else if (status.Equals("delete"))
                message = "Hapus Sukses";
            ViewBag.Message = message;
            return PartialView(BDV);
        }

    }
}