using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriApp.Domain.Entities
{
    public class Rapor : BaseEntity
    {
        public DateTime Tarih { get; set; }
        public double AlinanKalori { get; set; }
        public double YakilanKalori { get; set; }
        public string EnCokSevilenYemek { get; set; }
        public List<Besin> EnCokYenenYemek { get; set; }
        
        //one to one
        public int KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; }

        // one to many
        public ICollection<Spor> Spors { get; set; }
    }
}
