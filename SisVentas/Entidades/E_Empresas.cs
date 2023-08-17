using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVentas.Entidades
{
    public class E_Empresas
    {
        public int Codigo_em { get; set; }
        public string Nombre_em { get; set; }
        public string Nrodocumento_em { get; set; }
        public string Direccion_em { get; set; }
        public string Telefono_em { get; set; }
        public string Correo_em { get; set; }
        public byte[] Logo_em { get; set; }
    }
}
