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
    public partial class FormListarClientes : Form
    {
        Cliente obj;
        public FormListarClientes()
        {
            InitializeComponent();
            List<Cliente> lista = Cliente.Listar();

            dtGVClientes.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                obj = lista[i];
                dtGVClientes.Rows.Add(obj.Ci.ToString(), obj.Nombre, obj.Direccion, obj.Telefono.ToString());
                dtGVClientes.Rows[i].Tag = obj;
            }
        }
        
        private void dtGVClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            obj = (Cliente)dtGVClientes.CurrentRow.Tag;
            Datos.objAuxC = new Cliente();
            Datos.objAuxC = obj;
            this.Close();
        }
    }
}
