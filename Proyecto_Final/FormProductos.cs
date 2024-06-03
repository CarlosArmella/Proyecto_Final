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
    public partial class FormProductos : Form
    {
        Producto obj;
        public FormProductos()
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
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                obj = new Producto();
                obj.Codigo = txtCodigo.Text;
                obj.Nombre = txtNombre.Text;
                obj.Descripcion = txtDescripcion.Text;
                obj.Precio = double.Parse(txtPrecio.Text);
                obj.Agregar();

                List<Producto> lista = Producto.Listar();
                dtGVProductos.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    obj = lista[i];
                    dtGVProductos.Rows.Add(obj.Codigo, obj.Nombre, obj.Descripcion, obj.Precio.ToString());
                    dtGVProductos.Rows[i].Tag = obj;
                }
                txtCodigo.Clear();
                txtNombre.Clear();
                txtDescripcion.Clear();
                txtPrecio.Clear();
                MessageBox.Show("Producto agregado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            obj = null;
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (obj != null)
                {
                    obj.Codigo = txtCodigo.Text;
                    obj.Nombre = txtNombre.Text;
                    obj.Descripcion = txtDescripcion.Text;
                    obj.Precio = double.Parse(txtPrecio.Text);
                    obj.Modificar();
                    List<Producto> lista = Producto.Listar();
                    dtGVProductos.Rows.Clear();
                    for (int i = 0; i < lista.Count; i++)
                    {
                        obj = lista[i];
                        dtGVProductos.Rows.Add(obj.Codigo, obj.Nombre, obj.Descripcion, obj.Precio.ToString());
                        dtGVProductos.Rows[i].Tag = obj;
                    }
                    txtCodigo.Clear();
                    txtNombre.Clear();
                    txtDescripcion.Clear();
                    txtPrecio.Clear();
                    obj = null;
                    MessageBox.Show("Producto modificado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un Producto de la lista para modificar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (obj != null)
            {
                obj.Borrar();
                List<Producto> lista = Producto.Listar();
                dtGVProductos.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    obj = lista[i];
                    dtGVProductos.Rows.Add(obj.Codigo, obj.Nombre, obj.Descripcion, obj.Precio.ToString());
                    dtGVProductos.Rows[i].Tag = obj;
                }
                txtCodigo.Clear();
                txtNombre.Clear();
                txtDescripcion.Clear();
                txtPrecio.Clear();
                MessageBox.Show("Producto eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Producto de la lista para borrar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            obj = null;
        }
        private void dtGVProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            obj = (Producto)dtGVProductos.CurrentRow.Tag;
            if (obj != null)
            {
                txtCodigo.Text = obj.Codigo;
                txtNombre.Text = obj.Nombre;
                txtDescripcion.Text = obj.Descripcion;
                txtPrecio.Text = obj.Precio.ToString();
            }
        }
    }
}
