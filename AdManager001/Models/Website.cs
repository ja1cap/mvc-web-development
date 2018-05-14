using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdManager001.Models
{
    public class Website
    {
        public int ID { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public virtual ICollection<Zone> Zones { get; set; }
        [Required]
        [Url]
        public string Url { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ContactName { get; set; }
        [Required]
        [EmailAddress]
        public string ContactEmail { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
