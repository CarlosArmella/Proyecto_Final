using System;
using System.Collections.Generic;
using System.IO;

namespace Proyecto_Final
{
    public class Reporte
    {
        // Atributos
        public string Fecha { get; set; }
        public int Cont { get; set; }
        public double Total { get; set; }
        public Cliente Cli { get; set; }
        public List<Producto> Pro { get; set; }

        // Metodos
        public void Agregar()
        {
            Datos.reportes.Add(this);
            GuardarEnTxt();
        }
        public void Borrar()
        {
            Datos.reportes.Remove(this);
            GuardarEnTxt();
        }
        public static List<Reporte> Listar()
        {
            return Datos.reportes;
        }
        private void GuardarEnTxt()
        {
            string rutaAbsoluta = Directory.GetCurrentDirectory();
            StreamWriter escritor = new StreamWriter(rutaAbsoluta + @"\reportes.txt");
            List<Reporte> listaR = Datos.reportes;
            for (int i = 0; i < listaR.Count; i++)
            {
                Reporte obj = listaR[i];
                List<Producto> listaP = obj.Pro;
                string linea = "";
                for (int j = 0; j < listaP.Count; j++)
                {
                    Producto ob = listaP[j];
                    linea += $"{ob.Codigo}♣{ob.Nombre}♣{ob.Descripcion}♣{ob.Precio.ToString()}♣{ob.Cantidad}♣";
                }
                escritor.WriteLine($"{obj.Fecha}♣{obj.Cont}♣{obj.Total}♣{obj.Cli.Ci}♣{obj.Cli.Nombre}♣" +
                    $"{obj.Cli.Direccion}♣{obj.Cli.Telefono}♣{linea}");
            }
            escritor.Close();
        }
        public static void RecuperarTxtReportes()
        {
            string rutaAbsoluta = Directory.GetCurrentDirectory();

            if (File.Exists(rutaAbsoluta + @"\reportes.txt"))
            {
                StreamReader lector = new StreamReader(rutaAbsoluta + @"\reportes.txt");
                string registro = lector.ReadLine();
                while (registro != null)
                {
                    Reporte objR = new Reporte();

                    string[] datos = registro.Split('♣');
                    objR.Fecha = datos[0].ToString();
                    objR.Cont = int.Parse(datos[1].ToString());
                    objR.Total = double.Parse(datos[2].ToString());

                    Cliente objC = new Cliente();
                    objC.Ci = int.Parse(datos[3].ToString());
                    objC.Nombre = datos[4].ToString();
                    objC.Direccion = datos[5].ToString();
                    objC.Telefono = int.Parse(datos[6].ToString());
                    objR.Cli = objC;

                    List<Producto> listP = new List<Producto>();
                    Producto objP;
                    int cont = 7 + (objR.Cont * 5);
                    for (int i = 7; i < cont; i++)
                    {
                        objP = new Producto();
                        objP.Codigo = datos[i].ToString();
                        i++;
                        objP.Nombre = datos[i].ToString();
                        i++;
                        objP.Descripcion = datos[i].ToString();
                        i++;
                        objP.Precio = double.Parse(datos[i].ToString());
                        i++;
                        objP.Cantidad = int.Parse(datos[i].ToString());
                        listP.Add(objP);
                    }
                    objR.Pro = listP;
                    Datos.reportes.Add(objR);
                    registro = lector.ReadLine();
                }
                lector.Close();
            }
            else
            {
                File.Create(rutaAbsoluta + @"\reportes.txt");
            }
        }
    }
}
