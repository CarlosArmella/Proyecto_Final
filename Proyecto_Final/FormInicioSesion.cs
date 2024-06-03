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
    public partial class FormInicioSesion : Form
    {
        public FormInicioSesion()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<Usuario> lista = Usuario.Listar();
            Usuario obj = new Usuario();
            bool aux = false;
            int num = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                obj = lista[i];
                if (txtId.Text == obj.Id.ToString() && txtContraseña.Text == obj.Contraseña)
                {
                    aux = true;
                    num = i;
                }
            }
            FormMenu ventana = new FormMenu(num);
            if (aux == true)
            {
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
