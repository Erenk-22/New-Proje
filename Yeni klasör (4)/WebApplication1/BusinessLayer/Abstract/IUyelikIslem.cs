using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUyelikIslem
    {
        List<UyelikIslem> GetList();
        List<UyelikIslem> GetList(string p);
        void UyelikIslemAdd(UyelikIslem Uye);
        UyelikIslem GetByID(int id);
        void UyelikIslemSil(UyelikIslem Uye);
        void UyelikIslemUpdate(UyelikIslem Uye);
    }
}
