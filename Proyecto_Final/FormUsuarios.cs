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
    public partial class FormUsuarios : Form
    {
        Usuario obj;
        public FormUsuarios()
        {
            InitializeComponent();
            List<Usuario> lista = Usuario.Listar();

            dtGVUsuarios.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                obj = lista[i];
                dtGVUsuarios.Rows.Add(obj.Id.ToString(), obj.Nombre, obj.Contraseña, obj.Rol.ToString());
                dtGVUsuarios.Rows[i].Tag = obj;
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                obj = new Usuario();
                obj.Id = int.Parse(txtId.Text);
                obj.Nombre = txtNombre.Text;
                obj.Contraseña = txtContraseña.Text;
                obj.Rol = checkBox1.Checked;
                obj.Agregar();
                List<Usuario> lista = Usuario.Listar();

                dtGVUsuarios.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    obj = lista[i];
                    dtGVUsuarios.Rows.Add(obj.Id.ToString(), obj.Nombre, obj.Contraseña, obj.Rol.ToString());
                    dtGVUsuarios.Rows[i].Tag = obj;
                }
                txtId.Clear();
                txtNombre.Clear();
                txtContraseña.Clear();
                checkBox1.Checked = false;
                MessageBox.Show("Usuario agregado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores válidos para el ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    obj.Id = int.Parse(txtId.Text);
                    obj.Nombre = txtNombre.Text;
                    obj.Contraseña = txtContraseña.Text;
                    obj.Rol = checkBox1.Checked;
                    obj.Modificar();
                    List<Usuario> lista = Usuario.Listar();

                    dtGVUsuarios.Rows.Clear();
                    for (int i = 0; i < lista.Count; i++)
                    {
                        obj = lista[i];
                        dtGVUsuarios.Rows.Add(obj.Id.ToString(), obj.Nombre, obj.Contraseña, obj.Rol.ToString());
                        dtGVUsuarios.Rows[i].Tag = obj;
                    }
                    txtId.Clear();
                    txtNombre.Clear();
                    txtContraseña.Clear();
                    checkBox1.Checked = false;
                    obj = null;
                    MessageBox.Show("Usuario modificado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un Usuario de la lista para modificar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                List<Usuario> lista = Usuario.Listar();

                dtGVUsuarios.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    obj = lista[i];
                    dtGVUsuarios.Rows.Add(obj.Id.ToString(), obj.Nombre, obj.Contraseña, obj.Rol.ToString());
                    dtGVUsuarios.Rows[i].Tag = obj;
                }
                txtId.Clear();
                txtNombre.Clear();
                txtContraseña.Clear();
                checkBox1.Checked = false;
                MessageBox.Show("Usuario eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Usuario de la lista para borrar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            obj = null;
        }
        private void dtGVUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            obj = (Usuario)dtGVUsuarios.CurrentRow.Tag;
            if (obj != null)
            {
                txtId.Text = obj.Id.ToString();
                txtNombre.Text = obj.Nombre;
                txtContraseña.Text = obj.Contraseña;
                checkBox1.Checked = obj.Rol;
            }
        }
    }
}
