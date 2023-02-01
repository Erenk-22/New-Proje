using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.Concrete
{
    public class Context: DbContext
    {
        public DbSet<Basvuru> Basvurus { get; set; }
        public DbSet<UyelikIslem> UyelikIslems { get; set; }
        public DbSet<BasvuruDetay> BasvuruDetays { get; set; }
    }
}
