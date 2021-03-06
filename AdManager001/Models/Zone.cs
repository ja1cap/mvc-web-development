﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdManager001.Models
{
    public class Zone
    {
        public int ID { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public int WebsiteId { get; set; }
        public Website Website { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int AdPlacementWidth { get; set; }
        [Required]
        public int AdPlacementHeight { get; set; }
    }
}
