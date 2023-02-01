using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Basvuru
    {
        [Key]
        public int BasvuruID { get; set; }
        public int SirketID { get; set; }
        public string UyelikTürü { get; set; }
        public string UyeNo { get; set; }
        public string SirketAdiUnvan { get; set; }
        public string İletisimNo { get; set; }
        public string Eposta { get; set; }
        public string TicaretSicilNo { get; set; }
        public string VergiNo { get; set; }
        public string VergiDairesi { get; set; }
        public string il { get; set; }
        public string Adres { get; set; }
        public string KayitliOlunanOda { get; set; }
        public string TcKimlikNo { get; set; }
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
    }
}
