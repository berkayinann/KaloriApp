using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriApp.Domain.Entities.Reports
{
    public class Rapor
    {
        public int RaporId { get; set; }
        public int KullaniciId { get; set; }
        public DateTime Tarih { get; set; }
        public double AlinanKalori { get; set; }
        public double YakilanKalori { get; set; }
    }
}
