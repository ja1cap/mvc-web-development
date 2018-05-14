using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdManager001.Models
{
    public class Campaign
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        [Range(1, 99)]
        [Required]
        public int Revenue { get; set; }
        [Range(1, 99999)]
        [Required]
        public int Budget { get; set; }
        [Required]
        public string Currency { get; set; }
        [Required]
        [Url]
        public string BannerImageUrl { get; set; }
        [Required]
        public int BannerImageWidth { get; set; }
        [Required]
        public int BannerImageHeight { get; set; }
        [Required]
        [Url]
        public string ClickUrl { get; set; }
    }
}
