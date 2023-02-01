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
    public class BasvuruManager : IBasvuru
    {
        IBasvuri _Basvur;
        public BasvuruManager(IBasvuri Bas)
        {
            _Basvur = Bas;
        }
        public void BasvuruAdd(Basvuru Basvur)
        {
            _Basvur.Insert(Basvur);
        }

        public void BasvuruSil(Basvuru Basvur)
        {
            _Basvur.Delete(Basvur);
        }

        public void BasvuruUpdate(Basvuru Basvur)
        {
            _Basvur.Update(Basvur);
        }

        public Basvuru GetByID(int id)
        {
            return _Basvur.Get(x => x.BasvuruID == id);
        }

        public List<Basvuru> GetList()
        {
            return _Basvur.List();
        }

        public List<Basvuru> GetList(string p)
        {
            return _Basvur.List(x => x.AdSoyad.Contains(p));
        }
        public List<Basvuru> GetAll()
        {
            return _Basvur.GetAll();
        }
        public List<Basvuru> GetBasvur(int id)
        {
            return _Basvur.GetAll(x => x.SirketID == id);
        }
    }
}
