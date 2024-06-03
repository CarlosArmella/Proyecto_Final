using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string rutaAbsoluta = Directory.GetCurrentDirectory();
            StreamWriter escritor = new StreamWriter(rutaAbsoluta + @"\productos.txt");
            List<Producto> lista = Datos.productos;
            for (int i = 0; i < lista.Count; i++)
            {
                Producto obj = lista[i];
                escritor.WriteLine($"{obj.Codigo}♣{obj.Nombre}♣{obj.Descripcion}♣{obj.Precio.ToString()}");
            }
            escritor.Close();
        }
        public void Modificar()
        {
            string rutaAbsoluta = Directory.GetCurrentDirectory();
            StreamWriter escritor = new StreamWriter(rutaAbsoluta + @"\productos.txt");
            List<Producto> lista = Datos.productos;
            for (int i = 0; i < lista.Count; i++)
            {
                Producto obj = lista[i];
                escritor.WriteLine($"{obj.Codigo}♣{obj.Nombre}♣{obj.Descripcion}♣{obj.Precio.ToString()}");
            }
            escritor.Close();
        }
        public void Borrar()
        {
            Datos.productos.Remove(this);
            string rutaAbsoluta = Directory.GetCurrentDirectory();
            StreamWriter escritor = new StreamWriter(rutaAbsoluta + @"\productos.txt");
            List<Producto> lista = Datos.productos;
            for (int i = 0; i < lista.Count; i++)
            {
                Producto obj = lista[i];
                escritor.WriteLine($"{obj.Codigo}♣{obj.Nombre}♣{obj.Descripcion}♣{obj.Precio.ToString()}");
            }
            escritor.Close();
        }
        public static List<Producto> Listar()
        {
            return Datos.productos;
        }
      
        public static void RecuperarTxtProductos()
        {
            string rutaAbsoluta = Directory.GetCurrentDirectory();

            if (File.Exists(rutaAbsoluta + @"\productos.txt"))
            {
                StreamReader lector = new StreamReader(rutaAbsoluta + @"\productos.txt");
                string registro = lector.ReadLine();
                while (registro != null)
                {
                    string[] datos = registro.Split('♣');
                    Producto obj = new Producto();
                    obj.Codigo = datos[0].ToString();
                    obj.Nombre = datos[1].ToString();
                    obj.Descripcion = datos[2].ToString();
                    obj.Precio = double.Parse(datos[3].ToString());
                    Datos.productos.Add(obj);
                    registro = lector.ReadLine();
                }
                lector.Close();
            }
            else
            {
                File.Create(rutaAbsoluta + @"\productos.txt");
            }
        }
    }
}
