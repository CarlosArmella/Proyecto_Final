using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    public class Cliente
    {
        // Atributos
        public int Ci { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }

        // Constructor
        public Cliente(int ci = 0, string nombre = "", string direccion = "", int telefono = 0)
        {
            Ci = ci;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
        }

        // Metodos
        public void Agregar()
        {
            Datos.clientes.Add(this);
            string rutaAbsoluta = Directory.GetCurrentDirectory();
            StreamWriter escritor = new StreamWriter(rutaAbsoluta + @"\clientes.txt");
            List<Cliente> lista = Datos.clientes;
            for (int i = 0; i < lista.Count; i++)
            {
                Cliente obj = lista[i];
                escritor.WriteLine($"{obj.Ci.ToString()}♣{obj.Nombre}♣{obj.Direccion}♣{obj.Telefono.ToString()}");
            }
            escritor.Close();
        }
        public void Modificar()
        {
            string rutaAbsoluta = Directory.GetCurrentDirectory();
            StreamWriter escritor = new StreamWriter(rutaAbsoluta + @"\clientes.txt");
            List<Cliente> lista = Datos.clientes;
            for (int i = 0; i < lista.Count; i++)
            {
                Cliente obj = lista[i];
                escritor.WriteLine($"{obj.Ci.ToString()}♣{obj.Nombre}♣{obj.Direccion}♣{obj.Telefono.ToString()}");
            }
            escritor.Close();
        }
        public void Borrar()
        {
            Datos.clientes.Remove(this);
            string rutaAbsoluta = Directory.GetCurrentDirectory();
            StreamWriter escritor = new StreamWriter(rutaAbsoluta + @"\clientes.txt");
            List<Cliente> lista = Datos.clientes;
            for (int i = 0; i < lista.Count; i++)
            {
                Cliente obj = lista[i];
                escritor.WriteLine($"{obj.Ci.ToString()}♣{obj.Nombre}♣{obj.Direccion}♣{obj.Telefono.ToString()}");
            }
            escritor.Close();
        }
        public static List<Cliente> Listar()
        {
            return Datos.clientes;
        }
        
        public static void RecuperarTxtClientes()
        {
            string rutaAbsoluta = Directory.GetCurrentDirectory();

            if (File.Exists(rutaAbsoluta + @"\clientes.txt"))
            {
                StreamReader lector = new StreamReader(rutaAbsoluta + @"\clientes.txt");
                string registro = lector.ReadLine();
                while (registro != null)
                {
                    string[] datos = registro.Split('♣');
                    Cliente obj = new Cliente();
                    obj.Ci = int.Parse(datos[0].ToString());
                    obj.Nombre = datos[1].ToString();
                    obj.Direccion = datos[2].ToString();
                    obj.Telefono = int.Parse(datos[3].ToString());
                    Datos.clientes.Add(obj);
                    registro = lector.ReadLine();
                }
                lector.Close();
            }
            else
            {
                File.Create(rutaAbsoluta + @"\clientes.txt");
            }
        }
    }
}
