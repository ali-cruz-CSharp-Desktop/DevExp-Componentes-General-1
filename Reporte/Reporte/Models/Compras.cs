using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporte
{
    public class Compras
    {
        public int CompraID { get; set; }
        public string ClienteID { get; set; }
        [Display(Name = "Nombre Contacto")]
        public string NombreContacto { get; set; }
        public string Direccion { get; set; }
        [Display(Name = "Codigo Postal")]
        public string CodigoPostal { get; set; }
        public string Ciudad { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaCompra { get; set; }
    }

}
