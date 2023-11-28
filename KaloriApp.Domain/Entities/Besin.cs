using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KaloriApp.Domain.Enums;

namespace KaloriApp.Domain.Entities
{
    public class Besin : BaseEntity
    {
        public string BesinAdi { get; set; }

        public decimal BesinKalori100Gr { get; set; }

        public bool BesinPorsiyonMu { get; set; }

        public int BesinPorsiyon { get; set; }

        public decimal BesinGramaj { get; set; }

        public Ogun BesinOgun { get; set; }


    }
}
