using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCrud.Models.ViewModels
{
    public class ListTablaViewModel
    {
        public int Id { get; set; }
        public string Patente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Puertas { get; set; }
        public string Dueño { get; set; }
     
    }
}