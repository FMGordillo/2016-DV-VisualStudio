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
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
    }

    public class ArticuloDBContext : DbContext
    {
        public DbSet<Articulo> Articulo { get; set; }
    }
}