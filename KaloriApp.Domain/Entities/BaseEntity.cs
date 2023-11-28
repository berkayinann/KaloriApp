using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriApp.Domain.Entities
{
    public class BaseEntity
    {
        public int ID { get; set; }

        public DateTime CreateTime { get; set; } = DateTime.Now;

        public DateTime? ModifiedTime { get; set; }

        public DateTime? DeletedTime { get; set; }

    }
}
