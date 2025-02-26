﻿using System;
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
    public partial class FormReportes : Form
    {
        Reporte obj = new Reporte();
        public FormReportes()
        {
            InitializeComponent();
            List<Reporte> listaRep = Reporte.Listar();
            dtGVClientes.Rows.Clear();
            for (int i = 0; i < listaRep.Count; i++)
            {
                obj = listaRep[i];
                if (obj.Cli.Nombre == "Desconocido")
                {
                    dtGVClientes.Rows.Add("Desconocido", obj.Cli.Nombre, obj.Cli.Direccion, "Desconocido");
                }
                else
                {
                    dtGVClientes.Rows.Add(obj.Cli.Ci.ToString(), obj.Cli.Nombre, obj.Cli.Direccion, obj.Cli.Telefono.ToString());
                }
                dtGVClientes.Rows[i].Tag = obj;
            }
            obj = null;
        }       
        
        private void dtGVClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            obj = (Reporte)dtGVClientes.CurrentRow.Tag;
            if (obj != null)
            {
                List<Producto> lista = obj.Pro;
                dtGVProductos.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    Producto obj = lista[i];
                    dtGVProductos.Rows.Add(obj.Codigo, obj.Nombre, obj.Descripcion, obj.Precio.ToString(), obj.Cantidad.ToString());
                    dtGVProductos.Rows[i].Tag = obj;
                }
                labelFecha.Text = "Fecha: " + obj.Fecha;
                labelTotal.Text = "Total: " + obj.Total.ToString() + " Bs";
            }             
        }
        private void btnEliminarReporte_Click(object sender, EventArgs e)
        {
            if (obj != null)
            {
                obj.Borrar();
                List<Reporte> listaRep = Reporte.Listar();
                dtGVClientes.Rows.Clear();
                for (int i = 0; i < listaRep.Count; i++)
                {
                    obj = listaRep[i];
                    if (obj.Cli.Nombre == "Desconocido")
                    {
                        dtGVClientes.Rows.Add("Desconocido", obj.Cli.Nombre, obj.Cli.Direccion, "Desconocido");
                    }
                    else
                    {
                        dtGVClientes.Rows.Add(obj.Cli.Ci.ToString(), obj.Cli.Nombre, obj.Cli.Direccion, obj.Cli.Telefono.ToString());
                    }
                    dtGVClientes.Rows[i].Tag = obj;
                }
                MessageBox.Show("Reporte eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Reporte de la lista para borrar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dtGVProductos.Rows.Clear();
            labelFecha.Text = "Fecha: ";
            labelTotal.Text = "Total: ";
            obj = null;
        }
        
    }
}
