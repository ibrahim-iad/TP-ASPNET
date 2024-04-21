using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TP1ASP.Models
{
    public class Rectangle
    {
        [Required]
        [Display(Name = "Longueur")]
        public int Longueur { get; set; }
        [Required]
        [Display(Name = "Largeur")]
        public int Largeur { get; set; }
        [Display(Name = "Périmètre")]
        public int Perimetre { get; set; }
        [Display(Name = "Surface")]
        public int Surface { get; set; }
    }
}