using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KaloriApp.Domain.Enums;

namespace KaloriApp.Domain.Entities
{
    public class Kullanici : BaseEntity
    {
        public string KullanıcıAdi { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        public DateTime Dogumtarihi { get; set; }

        public string Email { get; set; }

        public int Ağırlık { get; set; }

        public Amac Amac { get; set; }

        public bool Cinsiyet { get; set; }

        public double Boy { get; set; }

        public List<Besin> AldigiBesinler { get; set; }
    }
}
