using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBasvuruDetay
    {
        List<BasvuruDetay> GetList();
        List<BasvuruDetay> GetList(string p);
        void BasvuruDetayAdd(BasvuruDetay Basvuru);
        BasvuruDetay GetByID(int id);
        void BasvuruDetaySil(BasvuruDetay Basvuru);
        void BasvuruDetayUpdate(BasvuruDetay Basvuru);
    }
}
