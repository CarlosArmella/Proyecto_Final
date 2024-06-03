using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    class Datos
    {
        public static List<Cliente> clientes = new List<Cliente>();
        public static List<Producto> productos = new List<Producto>();
        public static List<Usuario> usuarios = new List<Usuario>();
        public static List<Producto> venta = new List<Producto>();

        public static Producto objAux = new Producto();
        public static Cliente objAuxC = new Cliente();

        public static List<Reporte> reportes = new List<Reporte>();
    }
}
