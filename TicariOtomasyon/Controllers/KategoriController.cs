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

        [HttpGet]
        public ActionResult KategoriEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult KategoriEkle(Kategori k)
        {
            c.Kategoris.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");            
        }

        public ActionResult KategoriSil(int id)
        {
            var kategoriSil = c.Kategoris.Find(id);
            c.Kategoris.Remove(kategoriSil);
            c.SaveChanges();
            return RedirectToAction("Index");
        }


        
        public ActionResult KategoriGetir(int id)
        {
            var kategoriUpdate = c.Kategoris.Find(id);
            return View("KategoriGetir", kategoriUpdate);            
        }

        [HttpPost]
        public ActionResult KategoriGuncelleme(Kategori k)
        {
            var ktgr = c.Kategoris.Find(k.KategoriID);
            ktgr.KategoriAd = k.KategoriAd;
            c.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}