using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCOnlineOtomasyon.Models.Sınıflar
{
    public class SatisHareket
    {
        [Key]
        public int SatisID { get; set; }
        
        public DateTime Tarih { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
        public decimal ToplamTutar { get; set; }

        
        public Urun Urun { get; set; }        
        public Cari Cari { get; set; }
        public Personel Personel { get; set; }

    }
}
