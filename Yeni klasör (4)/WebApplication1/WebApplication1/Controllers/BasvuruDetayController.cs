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
    public class BasvuruDetayController : Controller
    {
        BasvuruDetayManager BasvurDetay = new BasvuruDetayManager(new EFBasvuruDetay());
        // GET: BasvuruDetay
        [HttpGet]
        public ActionResult BasvuruDetay()
        {
            int n = new Random().Next();
            Session["UyeNo"] = n;
            return View();
        }
        [HttpPost]
        public ActionResult BasvuruDetay(BasvuruDetay model)
        {
            int n = (int)Session["SirketID"];
            model.SirketID = n;
            BasvurDetay.BasvuruDetayAdd(model);
            return RedirectToAction("BasvuruDetayList","BasvuruDetay");
        }
        public ActionResult BasvuruDetayList()
        {
            int a = (int)Session["SirketID"];
            var Adminİnfo = BasvurDetay.GetAll().Where(x => x.SirketID == a).Select(y => y.SirketID).FirstOrDefault();
            var BasvurList = BasvurDetay.GetBasvur(Adminİnfo);
            return View(BasvurList);
        }
        public ActionResult BasvuruDetaySil(int id)
        {
            var basvur = BasvurDetay.GetByID(id);
            BasvurDetay.BasvuruDetaySil(basvur);
            return RedirectToAction("BasvuruDetayList","BasvuruDetay");
        }
        [HttpGet]
        public ActionResult BasvuruDetayUpdate(int id)
        {
            var BASVURU = BasvurDetay.GetByID(id);
            return View(BASVURU);
        }
        [HttpPost]
        public ActionResult BasvuruDetayUpdate(BasvuruDetay model)
        {
            BasvurDetay.BasvuruDetayUpdate(model);
            return RedirectToAction("BasvuruDetayList","BasvuruDetay");
        }
    }
}