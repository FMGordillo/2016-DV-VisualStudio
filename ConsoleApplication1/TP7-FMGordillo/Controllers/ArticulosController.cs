using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TP7_FMGordillo.Controllers
{
    public class ArticulosController : Controller {

        // GET: /Articulos/
        // http://localhost:*****/Articulos
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListadoArticulos(string name, int ID = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.ID = ", ID is: " + ID;
            return View();
        }

        // GET: /Articulos/Welcome/
        // http://localhost:*****/Articulos/Welcome
        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID is: " + ID);
        }
    }
}