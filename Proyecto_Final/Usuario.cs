using System;
using System.Collections.Generic;
using System.IO;

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
            GuardarEnTxt();
        }
        public void Modificar()
        {
            GuardarEnTxt();
        }
        public void Borrar()
        {
            Datos.usuarios.Remove(this);
            GuardarEnTxt();
        }
        public static List<Usuario> Listar()
        {
            return Datos.usuarios;
        }
        private void GuardarEnTxt()
        {
            string rutaAbsoluta = Directory.GetCurrentDirectory();
            using (StreamWriter escritor = new StreamWriter(Path.Combine(rutaAbsoluta, "usuarios.txt")))
            {
                foreach (Usuario usuario in Datos.usuarios)
                {
                    escritor.WriteLine($"{usuario.Id}♣{usuario.Nombre}♣{usuario.Contraseña}♣{usuario.Rol}");
                }
            }
        }
        public static void RecuperarTxtUsuarios()
        {
            string rutaAbsoluta = Directory.GetCurrentDirectory();
            string rutaArchivo = Path.Combine(rutaAbsoluta, "usuarios.txt");

            if (File.Exists(rutaArchivo))
            {
                using (StreamReader lector = new StreamReader(rutaArchivo))
                {
                    string registro;
                    while ((registro = lector.ReadLine()) != null)
                    {
                        string[] datos = registro.Split('♣');
                        int id = int.Parse(datos[0]);
                        string nombre = datos[1];
                        string contraseña = datos[2];
                        bool rol = bool.Parse(datos[3]);
                        Usuario obj = new Usuario(id, nombre, contraseña, rol);
                        Datos.usuarios.Add(obj);
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
