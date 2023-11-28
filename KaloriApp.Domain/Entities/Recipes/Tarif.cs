using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriApp.Domain.Entities.Recipes
{
    public class Tarif : BaseEntity
    {
        public int YemekId { get; set; }
        public string Metin { get; set; }
    }
}
