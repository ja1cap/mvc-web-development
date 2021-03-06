﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace AdManager001.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<Campaign> Campaigns { get; set; }
        public virtual ICollection<Zone> Zones { get; set; }
        public virtual ICollection<Website> Websites { get; set; }
    }
}
