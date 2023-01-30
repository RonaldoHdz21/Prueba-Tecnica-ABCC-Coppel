using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Prueba_Tecnica_ABCC.Clases
{
    public class Producto
    {
        [Required]
        public int Sku { get; set; }
        [Required]
        public string Articulo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Departamento { get; set; }
        public string Clase { get; set; }
        public string Familia { get; set; }
        public int Stock { get; set; }
        public int Cantidad { get; set; }
        public bool Descontinuado { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaBaja { get; set; }
    }
}
