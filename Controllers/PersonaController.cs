using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class PersonaController : Controller
    {
        //
        // GET: /Persona/
        public ActionResult Persona()
        {
            Persona obj = new Persona();
            obj.edad = Convert.ToInt32(Request.Form["edad"]);
            obj.nombre = Request.Form["nombre"].ToString();
            obj.apellido = Request.Form["apellido"].ToString();
            return View(obj);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Buscar()
        {
            String nombreProducto = RouteData.Values["nombreProducto"].ToString();
            nombreProducto = Server.HtmlEncode(nombreProducto);
            String resultado = String.Empty;

            switch (nombreProducto)
            {
                case "PC":
                    {
                        resultado = "Disponibles 4 unidades";
                        break;
                    }
                case "RAM":
                    {
                        resultado = "Disponibles 2 unidades";
                        break;
                    }
                default:
                    {
                        resultado = String.Format("El producto {0} no existe en stock",nombreProducto);
                        break;
                    }
            }
            return Content("<p>"+ resultado +"</p>");
        }
	}
}