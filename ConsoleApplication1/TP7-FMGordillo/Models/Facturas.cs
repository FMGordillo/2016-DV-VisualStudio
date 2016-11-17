using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP7_FMGordillo.Models
{
    public class Facturas
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public double total { get; set; }
    }
}