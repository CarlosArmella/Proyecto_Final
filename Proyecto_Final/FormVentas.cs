using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class FormVentas : Form
    {
        Producto obj1;
        int contador;
        double total;
        public FormVentas()
        {
            InitializeComponent();
            Datos.venta = new List<Producto>();
            contador = 0;
        }

        private void btnSeleccionarProducto_Click(object sender, EventArgs e)
        {
            FormListarProductos ventana = new FormListarProductos(true);
            ventana.ShowDialog();
            if(Datos.objAux == null)
            {
                txtNombreProducto.Text = "Ninguno";
            }
            else
            {
                txtNombreProducto.Text = Datos.objAux.Nombre;
            }
        }
        private void btnAgregarLista_Click(object sender, EventArgs e)
        {
            if (txtNombreProducto.Text == "Ninguno")
            {
                MessageBox.Show("Debe seleccionar un Producto para agregar a la lista", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                contador++;
                obj1 = new Producto();
                obj1 = Datos.objAux;
                obj1.Cantidad = int.Parse(numericUpDown1.Value.ToString());
                Datos.venta.Add(obj1);
                ListarVentas();
                txtNombreProducto.Text = "Ninguno";
                numericUpDown1.Value = 1;
            }
            obj1 = null;
            Datos.objAux = null;
        }
        private void btnEliminarLista_Click(object sender, EventArgs e)
        {
            if (obj1 != null)
            {
                contador--;
                Datos.venta.Remove(obj1);
                ListarVentas();
                MessageBox.Show("Se quito un producto de la lista.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Producto de la lista para quitar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            obj1 = null;
        }      
        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            FormListarClientes ventana = new FormListarClientes();
            ventana.ShowDialog();
            if (Datos.objAuxC == null)
            {
                txtCliente.Text = "Desconocido";
            }
            else
            {
                txtCliente.Text = Datos.objAuxC.Nombre;
            }
        }
        private void btnRealizarCompra_Click(object sender, EventArgs e)
        {
            if (contador == 0)
            {
                MessageBox.Show("Agregue como minimo un producto a la lista antes de comprar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtCliente.Text == "Desconocido")
                {
                    Datos.objAuxC = new Cliente();
                    Datos.objAuxC.Ci = 10000000;
                    Datos.objAuxC.Nombre = "Desconocido";
                    Datos.objAuxC.Direccion = "Desconocido";
                    Datos.objAuxC.Telefono = 10000000;
                }
                Reporte ob = new Reporte();
                ob.Fecha = DateTime.Now.ToString();
                ob.Cont = contador;
                ob.Total = total;
                ob.Cli = Datos.objAuxC;
                ob.Pro = Datos.venta;
                ob.Agregar();

                LimpiarVenta();
                MessageBox.Show("Compra realizada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LimpiarVenta()
        {
            txtCliente.Text = "Desconocido";
            txtTotal.Clear();
            Datos.venta = new List<Producto>();
            ListarVentas();
            contador = 0;
        }
        private void dtGVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            obj1 = (Producto)dtGVentas.CurrentRow.Tag;
        }
        private void ListarVentas()
        {
            total = 0;
            List<Producto> list = Datos.venta;
            dtGVentas.Rows.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                obj1 = list[i];
                dtGVentas.Rows.Add(obj1.Codigo, obj1.Nombre, obj1.Descripcion, obj1.Precio.ToString(), obj1.Cantidad.ToString());
                dtGVentas.Rows[i].Tag = obj1;
                total += obj1.Precio * obj1.Cantidad;
            }
            txtTotal.Text = total.ToString();
        }

        

    }
}
