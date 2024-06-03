using System;
using System.Collections.Generic;
using System.IO;

namespace Proyecto_Final
{
    public class Producto
    {
        // Atributos
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }

        // Constructor
        public Producto(string codigo = "", string nombre = "", string descripcion = "", double precio = 0.0, int cantidad = 0)
        {
            Codigo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            Cantidad = cantidad;
        }
        // Metodos
        public void Agregar()
        {
            Datos.productos.Add(this);
            GuardarEnTxt();
        }
        public void Modificar()
        {
            GuardarEnTxt();
        }
        public void Borrar()
        {
            Datos.productos.Remove(this);
            GuardarEnTxt();
        }
        public static List<Producto> Listar()
        {
            return Datos.productos;
        }
        private void GuardarEnTxt()
        {
            string rutaAbsoluta = Directory.GetCurrentDirectory();
            using (StreamWriter escritor = new StreamWriter(Path.Combine(rutaAbsoluta, "productos.txt")))
            {
                foreach (Producto producto in Datos.productos)
                {
                    escritor.WriteLine($"{producto.Codigo}♣{producto.Nombre}♣{producto.Descripcion}♣{producto.Precio}");
                }
            }
        }
        public static void RecuperarTxtProductos()
        {
            string rutaAbsoluta = Directory.GetCurrentDirectory();
            string rutaArchivo = Path.Combine(rutaAbsoluta, "productos.txt");

            if (File.Exists(rutaArchivo))
            {
                using (StreamReader lector = new StreamReader(rutaArchivo))
                {
                    string registro;
                    while ((registro = lector.ReadLine()) != null)
                    {
                        string[] datos = registro.Split('♣');
                        Producto obj = new Producto
                        {
                            Codigo = datos[0],
                            Nombre = datos[1],
                            Descripcion = datos[2],
                            Precio = double.Parse(datos[3])
                        };
                        Datos.productos.Add(obj);
                    }
                }
            }
            else
            {
                File.Create(rutaArchivo).Close();
            }
        }
    }
}
