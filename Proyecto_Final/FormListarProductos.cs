using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class FormListarProductos : Form
    {
        Producto obj = new Producto();
        static bool aux;
        public FormListarProductos(bool a)
        {
            InitializeComponent();
            List<Producto> lista = Producto.Listar();
            dtGVProductos.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                obj = lista[i];
                dtGVProductos.Rows.Add(obj.Codigo, obj.Nombre, obj.Descripcion, obj.Precio.ToString());
                dtGVProductos.Rows[i].Tag = obj;
            }
            aux = a;
        }
        private void btnOrdCodigo_Click(object sender, EventArgs e)
        {
            List<Producto> lista = Producto.Listar();
            IEnumerable<Producto> listaOrd = lista.OrderBy(user => user.Codigo);
            
            dtGVProductos.Rows.Clear();
            int i = 0;
            foreach (Producto obj in listaOrd)
            {
                dtGVProductos.Rows.Add(obj.Codigo, obj.Nombre, obj.Descripcion, obj.Precio.ToString());
                dtGVProductos.Rows[i].Tag = obj;
                i++;
            }
        }
        private void btnOrdNombre_Click(object sender, EventArgs e)
        {
            List<Producto> lista = Producto.Listar();
            IEnumerable<Producto> listaOrd = lista.OrderBy(user => user.Nombre);
            dtGVProductos.Rows.Clear();
            int i = 0;
            foreach (Producto obj in listaOrd)
            {
                dtGVProductos.Rows.Add(obj.Codigo, obj.Nombre, obj.Descripcion, obj.Precio.ToString());
                dtGVProductos.Rows[i].Tag = obj;
                i++;
            }
        }
        private void btnOrdPrecio_Click(object sender, EventArgs e)
        {
            List<Producto> lista = Producto.Listar();
            IEnumerable<Producto> listaOrd = lista.OrderBy(user => user.Precio);
            dtGVProductos.Rows.Clear();
            int i = 0;
            foreach(Producto obj in listaOrd)
            {
                dtGVProductos.Rows.Add(obj.Codigo, obj.Nombre, obj.Descripcion, obj.Precio.ToString());
                dtGVProductos.Rows[i].Tag = obj;
                i++;
            }
        }
        private void dtGVProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {          
            if (aux == true)
            {
                Datos.objAux = new Producto();
                obj = (Producto)dtGVProductos.CurrentRow.Tag;
                Datos.objAux = obj;
                obj = null;
                this.Close();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var filtrados = Filter(Datos.productos, textBox1.Text);
            dtGVProductos.Rows.Clear();
            int i = 0;
            foreach (Producto c in filtrados)
            {
                if (c != null)
                {
                    dtGVProductos.Rows.Add(c.Codigo,c.Nombre,c.Descripcion,c.Precio);
                    dtGVProductos.Rows[i].Tag = c;
                }
                i++;
            }
        }
        public List<Producto> Filter(List<Producto> input, string text)
        {
            if (text == "")
            {
                return input;
            }
            List<Producto> contacts = new List<Producto>();
            string valor2 = text.ToLower();
            foreach (Producto c in input)
            {
                if (c != null)
                {
                    string codigo = c.Codigo.ToLower();
                    string nombre = c.Nombre.ToLower();
                    if ((codigo + " " + nombre).IndexOf(valor2) >= 0)
                    {
                        contacts.Add(c);
                    }
                }
            }
            return contacts.ToList();
        }
    }
}
