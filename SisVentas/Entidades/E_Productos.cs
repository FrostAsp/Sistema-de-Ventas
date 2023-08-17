using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVentas.Entidades
{
    public class E_Productos
    {
        public int Codigo_pr { get; set; }
        public string Descripcion_pr { get; set; }
        public string Codigomanual { get; set; }
        public int Codigo_me { get; set; }
        public int Codigo_fa { get; set; }
        public decimal Pu_costo { get; set; }
        public decimal Pu_venta { get; set; }
        public decimal Pu_descuento { get; set; }
        public int Codigo_us { get; set; }

    }
}
