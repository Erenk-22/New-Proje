using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBasvuru
    {
        List<Basvuru> GetList();
        List<Basvuru> GetList(string p);
        void BasvuruAdd(Basvuru Basvur);
        Basvuru GetByID(int id);
        void BasvuruSil(Basvuru Basvur);
        void BasvuruUpdate(Basvuru Basvur);
    }
}
