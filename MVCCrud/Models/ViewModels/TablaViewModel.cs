using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCrud.Models.ViewModels
{
    public class TablaViewModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(8)]
        [Display(Name = "Patente")]
        public string Patente { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Marca")]
        public string Marca { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Modelo")]
        public string Modelo { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Puertas")]
        public int Puertas { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Dueño")]
        public string Dueño { get; set; }
      }


    public enum marcaDeAutos
    {
        Audi,
        BMW,
        Lexus, 
        Renault,
        Fiat
    }
}