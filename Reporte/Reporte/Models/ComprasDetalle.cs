using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporte
{
    public class ComprasDetalle
    {
        public int CompraID { get; set; }
        [Display(Name = "Nombre Producto")]
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Descuento { get; set; }
        [Display(Name = "Precio unitario")]
        public decimal PrecioUnitario { get; set; }
        public decimal Total
        {
            get
            {
                return Cantidad * PrecioUnitario - Cantidad * PrecioUnitario * Descuento;
            }
        }

    }
}
