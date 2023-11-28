using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriApp.Domain.Entities
{
    public class Spor  : BaseEntity
    {
        public int SporID { get; set; }

        public string SporName { get; set; }
        
        public string SporDescription { get; set; }

        public double YakilanKalori { get; set; }

    }
}
