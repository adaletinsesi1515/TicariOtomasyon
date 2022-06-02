using MVCOnlineOtomasyon.Models.Sınıflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace TicariOtomasyon.Controllers
{
    public class KategoriController : Controller
    {
        Context c = new Context();
        // GET: Kategori
        public ActionResult Index()
        {
            var degerler = c.Kategoris.ToList();
            return View(degerler);
        }
    }
}