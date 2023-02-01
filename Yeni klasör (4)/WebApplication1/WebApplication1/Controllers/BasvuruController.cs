using BusinessLayer.Concrete;
using DataAcessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class BasvuruController : Controller
    {
        BasvuruManager basvuru = new BasvuruManager(new EFBasvur());
        [HttpGet]
        public ActionResult Basvuru()
        {
            //int a = (int)Session["SirketID"];
            int n = new Random().Next();
            Session["UyeNo"] = n;
            return View();
        }
        [HttpPost]
        public ActionResult Basvuru(Basvuru model)
        {
            int a = (int)Session["SirketID"];
            model.SirketID = a;
            basvuru.BasvuruAdd(model);
            return RedirectToAction("BasvuruList","Basvuru");
        }
        public ActionResult BasvuruList()
        {
            int a = (int)Session["SirketID"];
            var Adminİnfo = basvuru.GetAll().Where(x => x.SirketID == a).Select(y => y.SirketID).FirstOrDefault();
            var BasvurList = basvuru.GetBasvur(Adminİnfo);
            return View(BasvurList);
        }
        public ActionResult BasvuruSil(int id)
        {
            var basvur = basvuru.GetByID(id);
            basvuru.BasvuruSil(basvur);
            return RedirectToAction("BasvuruList","Basvuru");
        }
        [HttpGet]
        public ActionResult BasvuruUpdate(int id)
        {
            var BASVURU = basvuru.GetByID(id);
            return View(BASVURU);
        }
        [HttpPost]
        public ActionResult BasvuruUpdate(Basvuru model)
        {
            basvuru.BasvuruUpdate(model);
            return RedirectToAction("BasvuruList","Basvuru");
        }
    }
}