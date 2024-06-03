using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class FormInicioSesion : Form
    {
        public FormInicioSesion()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<Usuario> lista = Usuario.Listar();
            bool usuarioValido = false;
            int num = 0;

            for (int i = 0; i < lista.Count; i++)
            {
                Usuario obj = lista[i];
                if (txtId.Text == obj.Id.ToString() && txtContraseña.Text == obj.Contraseña)
                {
                    usuarioValido = true;
                    num = i;
                    break;
                }
            }
            
            if (usuarioValido == true)
            {
                FormMenu ventana = new FormMenu(num);
                ventana.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario no Valido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtId.Clear();
            txtContraseña.Clear();
        }
    }
}
