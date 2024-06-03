using System;
using System.Collections.Generic;
using System.IO;

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
            GuardarEnTxt();
        }
        public void Modificar()
        {
            GuardarEnTxt();
        }
        public void Borrar()
        {
            Datos.clientes.Remove(this);
            GuardarEnTxt();
        }
        public static List<Cliente> Listar()
        {
            return Datos.clientes;
        }
        private void GuardarEnTxt()
        {
            string rutaAbsoluta = Directory.GetCurrentDirectory();
            using (StreamWriter escritor = new StreamWriter(Path.Combine(rutaAbsoluta, "clientes.txt")))
            {
                foreach (Cliente cliente in Datos.clientes)
                {
                    escritor.WriteLine($"{cliente.Ci}♣{cliente.Nombre}♣{cliente.Direccion}♣{cliente.Telefono}");
                }
            }
        }
        public static void RecuperarTxtClientes()
        {
            string rutaAbsoluta = Directory.GetCurrentDirectory();
            string rutaArchivo = Path.Combine(rutaAbsoluta, "clientes.txt");

            if (File.Exists(rutaArchivo))
            {
                using (StreamReader lector = new StreamReader(rutaArchivo))
                {
                    string registro;
                    while ((registro = lector.ReadLine()) != null)
                    {
                        string[] datos = registro.Split('♣');
                        int ci = int.Parse(datos[0]);
                        string nombre = datos[1];
                        string direccion = datos[2];
                        int telefono = int.Parse(datos[3]);
                        Cliente obj = new Cliente(ci, nombre, direccion, telefono);
                        Datos.clientes.Add(obj);
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
