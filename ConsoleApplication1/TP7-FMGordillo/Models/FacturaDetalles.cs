using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP7_FMGordillo.Models
{
    public class FacturaDetalles
    {
        public int id { get; set; }
        public int facturaid { get; set; }
        public int articulodid { get; set; }
        public int cantidad { get; set; }
        public double precio { get; set; }
    }
}