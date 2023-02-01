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
    public class UyelikIslemManager : IUyelikIslem
    {
        IUyelikİslem _UyelikIslem;
        public UyelikIslemManager(IUyelikİslem Uye)
        {
            _UyelikIslem = Uye;
        }
        public UyelikIslem GetByID(int id)
        {
            return _UyelikIslem.Get(x => x.SirketID == id);
        }

        public List<UyelikIslem> GetList()
        {
            return _UyelikIslem.List();
        }

        public List<UyelikIslem> GetList(string p)
        {
            return _UyelikIslem.List(x => x.SirketAdiUnvan.Contains(p));
        }

        public void UyelikIslemAdd(UyelikIslem Uye)
        {
            _UyelikIslem.Insert(Uye);
        }

        public void UyelikIslemSil(UyelikIslem Uye)
        {
            _UyelikIslem.Delete(Uye);
        }

        public void UyelikIslemUpdate(UyelikIslem Uye)
        {
            _UyelikIslem.Update(Uye);
        }
    }
}
