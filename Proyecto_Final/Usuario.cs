using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    class Usuario
    {
        // Atributos
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public bool Rol { get; set; }

        // Constructor
        public Usuario(int id = 0, string nombre = "", string contraseña = "", bool rol = false)
        {
            Id = id;
            Nombre = nombre;
            Contraseña = contraseña;
            Rol = rol;
        }

        // Metodos
        public void Agregar()
        {
            Datos.usuarios.Add(this);
            string rutaAbsoluta = Directory.GetCurrentDirectory();
            StreamWriter escritor = new StreamWriter(rutaAbsoluta + @"\usuarios.txt");
            List<Usuario> lista = Datos.usuarios;
            for (int i = 0; i < lista.Count; i++)
            {
                Usuario obj = lista[i];
                escritor.WriteLine($"{obj.Id.ToString()}♣{obj.Nombre}♣{obj.Contraseña}♣{obj.Rol.ToString()}");
            }
            escritor.Close();
        }
        public void Modificar()
        {
            string rutaAbsoluta = Directory.GetCurrentDirectory();
            StreamWriter escritor = new StreamWriter(rutaAbsoluta + @"\usuarios.txt");
            List<Usuario> lista = Datos.usuarios;
            for (int i = 0; i < lista.Count; i++)
            {
                Usuario obj = lista[i];
                escritor.WriteLine($"{obj.Id.ToString()}♣{obj.Nombre}♣{obj.Contraseña}♣{obj.Rol.ToString()}");
            }
            escritor.Close();
        }
        public void Borrar()
        {
            Datos.usuarios.Remove(this);
            string rutaAbsoluta = Directory.GetCurrentDirectory();
            StreamWriter escritor = new StreamWriter(rutaAbsoluta + @"\usuarios.txt");
            List<Usuario> lista = Datos.usuarios;
            for (int i = 0; i < lista.Count; i++)
            {
                Usuario obj = lista[i];
                escritor.WriteLine($"{obj.Id.ToString()}♣{obj.Nombre}♣{obj.Contraseña}♣{obj.Rol.ToString()}");
            }
            escritor.Close();
        }
        public static List<Usuario> Listar()
        {
            return Datos.usuarios;
        }
        
        public static void RecuperarTxtUsuarios()
        {
            string rutaAbsoluta = Directory.GetCurrentDirectory();

            if (File.Exists(rutaAbsoluta + @"\usuarios.txt"))
            {
                StreamReader lector = new StreamReader(rutaAbsoluta + @"\usuarios.txt");
                string registro = lector.ReadLine();
                while (registro != null)
                {
                    string[] datos = registro.Split('♣');
                    Usuario obj = new Usuario();
                    obj.Id = int.Parse(datos[0].ToString());
                    obj.Nombre = datos[1].ToString();
                    obj.Contraseña = datos[2].ToString();
                    obj.Rol = Convert.ToBoolean(datos[3].ToString());
                    Datos.usuarios.Add(obj);
                    registro = lector.ReadLine();
                }
                lector.Close();
            }
            else
            {
                File.Create(rutaAbsoluta + @"\usuarios.txt");
            }
        }
    }
}
