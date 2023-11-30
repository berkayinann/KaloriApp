using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriApp.Domain.Entities
{
    public class HaftalikRapor
    {
        public DateTime HaftaBaslangic { get; set; }
        public DateTime HaftaBitis { get; set; }
        public List<Rapor> GunlukRaporlar { get; set; }
    }
}
