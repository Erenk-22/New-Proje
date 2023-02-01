using BusinessLayer.Abstract;
using DataAcessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BasvuruDetayManager : IBasvuruDetay
    {
        IBasvuruDetayi _BasvuruDet;
        public BasvuruDetayManager(IBasvuruDetayi Bas)
        {
            _BasvuruDet = Bas;
        }
        public void BasvuruDetayAdd(BasvuruDetay Basvuru)
        {
            _BasvuruDet.Insert(Basvuru);
        }

        public void BasvuruDetaySil(BasvuruDetay Basvuru)
        {
            _BasvuruDet.Delete(Basvuru);
        }

        public void BasvuruDetayUpdate(BasvuruDetay Basvuru)
        {
            _BasvuruDet.Update(Basvuru);
        }

        public BasvuruDetay GetByID(int id)
        {
            return _BasvuruDet.Get(x => x.BasvuruDetayID == id);
        }

        public List<BasvuruDetay> GetList()
        {
            return _BasvuruDet.List();
        }

        public List<BasvuruDetay> GetList(string p)
        {
            return _BasvuruDet.List(x => x.UyelikTürü.Contains(p));
        }
        public List<BasvuruDetay> GetAll()
        {
            return _BasvuruDet.GetAll();
        }
        public List<BasvuruDetay> GetBasvur(int id)
        {
            return _BasvuruDet.GetAll(x => x.SirketID == id);
        }
    }
}
