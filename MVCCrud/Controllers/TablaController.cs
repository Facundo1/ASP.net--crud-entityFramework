using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCrud.Models;
using MVCCrud.Models.ViewModels;

namespace MVCCrud.Controllers
{
    public class TablaController : Controller
    {
        // GET: Tabla
        public ActionResult Index()
        {
            List<ListTablaViewModel> lst;
            using (CrudEntities db= new CrudEntities())
            {
                lst = (from d in db.tabla
                           select new ListTablaViewModel
                           {
                               Id = d.id,
                               Patente = d.Patente,                              
                               Marca = d.Marca,
                               Modelo = d.Modelo,
                               Puertas = d.Puertas,
                               Dueño = d.Dueño
                               
                           }).ToList();
            }

            return View(lst);
        }


        public ActionResult Nuevo()
        {

            return View();
        }

        //AGREGAR NUEVO AUTO
        [HttpPost]
        public ActionResult Nuevo(TablaViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (CrudEntities db= new CrudEntities())
                    {
                        var oTabla = new tabla();
                        oTabla.Dueño = model.Dueño;
                        oTabla.Puertas = model.Puertas;
                        oTabla.Modelo = model.Modelo;
                        oTabla.Marca = model.Marca;
                        oTabla.Patente = model.Patente;

                        db.tabla.Add(oTabla);
                        db.SaveChanges();
                    }

                    return Redirect("~/Tabla/");
                }

                return View(model);
                

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
}
}