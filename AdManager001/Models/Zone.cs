using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdManager001.Models
{
    public class Zone
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
