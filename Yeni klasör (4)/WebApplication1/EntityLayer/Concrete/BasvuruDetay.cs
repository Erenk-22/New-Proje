using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class BasvuruDetay
    {
        [Key]
        public int BasvuruDetayID { get; set; }
        public int SirketID { get; set; }
        public string BildirimNo { get; set; }
        public string UyelikTürü { get; set; }
        public string BasvuruYapilan { get; set; }
        public string BasvuruTürü { get; set; }
        public string BildirimKapsami { get; set; }
        public string Tarih { get; set; }
        public string Aciklama { get; set; }
    }
}
