using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TP7_FMGordillo.Controllers
{
    public class FacturasController : Controller
    {
        // GET: Facturas
        public ActionResult Index()
        {
            return View();
        }

        // GET: CargarFacturas
        public ActionResult CargarFactura()
        {
            return View();
        }
    }
}