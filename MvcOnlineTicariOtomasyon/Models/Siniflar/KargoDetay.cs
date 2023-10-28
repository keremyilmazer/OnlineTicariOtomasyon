using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class KargoDetay
    {
        public int KargoDetayid { get; set; }
        public string Aciklama { get; set; }
        public string TakipKodu { get; set; }
        public string Personel { get; set; }
        public string Alici { get; set; }
        public DateTime Tarih { get; set; }
    }
}