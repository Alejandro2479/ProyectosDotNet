using System;

namespace AppProducto.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaAlta { get; set; }
    }
}