using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class FormClientes : Form
    {
        Cliente obj;
        public FormClientes()
        {
            InitializeComponent();
            Listar();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                obj = new Cliente();
                CargarDatos();
                obj.Agregar();
                Listar();
                LimpiarEspacios();
                MessageBox.Show("Cliente agregado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores válidos para CI y Teléfono.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    CargarDatos();
                    obj.Modificar();
                    Listar();
                    LimpiarEspacios();
                    obj = null;
                    MessageBox.Show("Cliente modificado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un Cliente de la lista para modificar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                Listar();
                LimpiarEspacios();
                MessageBox.Show("Cliente eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Cliente de la lista para borrar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            obj = null;
        }
        private void CargarDatos()
        {
            obj.Ci = int.Parse(txtCi.Text);
            obj.Nombre = txtNombre.Text;
            obj.Direccion = txtDireccion.Text;
            obj.Telefono = int.Parse(txtTelefono.Text);
        }
        private void LimpiarEspacios()
        {
            txtCi.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
        }
        private void Listar()
        {
            List<Cliente> lista = Cliente.Listar();

            dtGVClientes.Rows.Clear();
            foreach (Cliente cliente in lista)
            {
                int rowIndex = dtGVClientes.Rows.Add(cliente.Ci.ToString(), cliente.Nombre, cliente.Direccion, cliente.Telefono.ToString());
                dtGVClientes.Rows[rowIndex].Tag = cliente;
            }
        }
        private void dtGVClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            obj = (Cliente)dtGVClientes.CurrentRow.Tag;
            if (obj != null)
            {
                txtCi.Text = obj.Ci.ToString();
                txtNombre.Text = obj.Nombre;
                txtDireccion.Text = obj.Direccion;
                txtTelefono.Text = obj.Telefono.ToString();
            }
        }
    }
}
