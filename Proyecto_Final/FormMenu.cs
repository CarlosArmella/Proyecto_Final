using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class FormMenu : Form
    {
        public FormMenu(int num)
        {
            InitializeComponent();
            VerificarRol(num);
        }
        public void VerificarRol(int num)
        {
            List<Usuario> lista = Usuario.Listar();
            Usuario obj = lista[num];
            labelNombre.Text = obj.Nombre;
            if (obj.Rol == true)
            {
                labelRol.Text = "Administrador";
                HabilitarAccionesAdministrativas();
            }
        }
        private void HabilitarAccionesAdministrativas()
        {
            iconButton4.Enabled = true;
            iconButton5.Enabled = true;
            iconButton6.Enabled = true;
        }

        private Form activeForm = null;
        private void openPanel2(Form panel2)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = panel2;
            panel2.TopLevel = false;
            panel2.FormBorderStyle = FormBorderStyle.None;
            panel2.Dock = DockStyle.Fill;
            panel2Form.Controls.Add(panel2);
            panel2Form.Tag = panel2;
            panel2.BringToFront();
            panel2.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            openPanel2(new FormClientes());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            openPanel2(new FormListarProductos(false));
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            openPanel2(new FormVentas());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            openPanel2(new FormProductos());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            openPanel2(new FormReportes());
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            openPanel2(new FormUsuarios());
        }
    }
}
