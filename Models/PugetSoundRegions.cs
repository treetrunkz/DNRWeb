using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DNR_Aquatics.Models
{
    public class PugetSoundRegions
    {
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "0.00")]
        public float Coordinates_N { get; set; }

        [Display(Name = "0.00")]
        public float Coordinates_W { get; set; }

        [StringLength(250), Display(Name = "0.00")]
        public float Width { get; set; }

        [StringLength(250), Display(Name = "0.00")]
        public float Depth { get; set; }

        [StringLength(250), Display(Name = "Wildlife"), DataType(DataType.MultilineText)]
        public string Wildlife { get; set; }

        [StringLength(250), Display(Name = "Biome"), DataType(DataType.MultilineText)]
        public string Biome { get; set; }

        [Display(Name = "isResidential")]
        public Boolean? isResidential { get; set; }

        [Display(Name = "IsPublicLand")]
        public Boolean? isPublicLand { get; set; }

        [Display(Name = "ValeTopography")]
        public float ValeTopography { get; set; }

        public ICollection<User> Users { get; set; }

    }
}