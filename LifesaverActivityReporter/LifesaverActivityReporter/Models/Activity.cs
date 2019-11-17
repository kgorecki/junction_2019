using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifesaverActivityReporter.Models
{
    public class Activity
    {
        public long Id { get; set; }

        public string user_id { get; set; }

        public long activity_typeId { get; set; }

        public string additional_info { get; set; }

        public virtual ActivityType activity_type { get; set; }
    }
}
