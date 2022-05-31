using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCOnlineOtomasyon.Models.Sınıflar
{
    public class Kategori
    {
        [Key]
        public int KategoriID { get; set; }

        [Column(TypeName = "VarChar")]
        [StringLength(30)]
        public string KategoriAd { get; set; }

        // 1'e çok ilişkideki 1'e anlamına gelen yapı
        // bir kategorinin birden çok ürünü olabilir yapısını kuruyoruz

        public ICollection<Urun> Uruns { get; set; }


    }
}
