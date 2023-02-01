using BusinessLayer.Concrete;
using DataAcessLayer.Concrete;
using DataAcessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace WebApplication1.Controllers
{
    public class UyelikController : Controller
    {
        UyelikIslemManager Uyelik = new UyelikIslemManager(new EFUyelik());
        Context c = new Context();
        // GET: Uyelik
        [HttpGet]
        public ActionResult UyelikIslem()
        {
            int n = new Random().Next();
            Session["UyeNo"] = n;
            return View();
        }

        [HttpPost]
        public ActionResult UyelikIslem(UyelikIslem model)
        {
            Uyelik.UyelikIslemAdd(model);
            return RedirectToAction("LogIn","Uyelik");
        }
        [HttpGet]
        public ActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LogIn(UyelikIslem model)
        {
            var sorgu = c.UyelikIslems.FirstOrDefault(x => x.Eposta == model.Eposta && x.Sifre == model.Sifre);

            if (sorgu != null)
            {
                FormsAuthentication.SetAuthCookie(Convert.ToString(sorgu.SirketID), false);
                Session["SirketID"] = sorgu.SirketID;
                Session["UyeNo"] = sorgu.UyeNo;
                return RedirectToAction("BasvuruList", "Basvuru");
            }
            else
            {
                TempData["Uyarı"] = "Şifreniz Veya Mailiniz Yanlış!";
                return View();
            }
        }
    }
}