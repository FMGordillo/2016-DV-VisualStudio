using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TP7_FMGordillo.Models
{
    public class Articulo
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public string descripcion { get; set; }
        public double precio { get; set; }
    }

    public class ArticuloDBContext : DbContext
    {
        public DbSet<Articulo> Articulo { get; set; }
    }
}