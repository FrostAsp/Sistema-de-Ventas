using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVentas.Entidades
{
    public class E_Proveedores
    {
        public int Codigo_po { get; set; }
        public string Nombre_po { get; set; }
        public string Nrodocumento_po { get; set; }
        public string Direccion_po { get; set; }
        public string Telefono_po { get; set; }
        public string Contacto_po { get; set; }
        public string Correo_po { get; set; }
        public string banco_po { get; set; }
        public string Nrocuenta_po { get; set; }
        public string Nrocuentainterbancaria { get; set; }
        public int Codigo_us { get; set; }
    }
}
