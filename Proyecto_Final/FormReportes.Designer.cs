
namespace Proyecto_Final
{
    partial class FormReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtGVProductos = new System.Windows.Forms.DataGridView();
            this.ColumCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtGVClientes = new System.Windows.Forms.DataGridView();
            this.ColumCi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.btnEliminarReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGVProductos
            // 
            this.dtGVProductos.AllowUserToOrderColumns = true;
            this.dtGVProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumCodigo,
            this.ColumNombre,
            this.ColumDescripcion,
            this.ColumPrecio,
            this.ColumCantidad});
            this.dtGVProductos.Enabled = false;
            this.dtGVProductos.Location = new System.Drawing.Point(600, 85);
            this.dtGVProductos.Name = "dtGVProductos";
            this.dtGVProductos.RowHeadersWidth = 51;
            this.dtGVProductos.RowTemplate.Height = 24;
            this.dtGVProductos.Size = new System.Drawing.Size(593, 325);
            this.dtGVProductos.TabIndex = 25;
            // 
            // ColumCodigo
            // 
            this.ColumCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumCodigo.HeaderText = "Codigo";
            this.ColumCodigo.MinimumWidth = 6;
            this.ColumCodigo.Name = "ColumCodigo";
            // 
            // ColumNombre
            // 
            this.ColumNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumNombre.HeaderText = "Nombre";
            this.ColumNombre.MinimumWidth = 6;
            this.ColumNombre.Name = "ColumNombre";
            // 
            // ColumDescripcion
            // 
            this.ColumDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumDescripcion.HeaderText = "Descripcion";
            this.ColumDescripcion.MinimumWidth = 6;
            this.ColumDescripcion.Name = "ColumDescripcion";
            // 
            // ColumPrecio
            // 
            this.ColumPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumPrecio.HeaderText = "Precio";
            this.ColumPrecio.MinimumWidth = 6;
            this.ColumPrecio.Name = "ColumPrecio";
            // 
            // ColumCantidad
            // 
            this.ColumCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumCantidad.HeaderText = "Cantidad";
            this.ColumCantidad.MinimumWidth = 6;
            this.ColumCantidad.Name = "ColumCantidad";
            // 
            // dtGVClientes
            // 
            this.dtGVClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtGVClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumCi,
            this.dataGridViewTextBoxColumn1,
            this.ColumDireccion,
            this.ColumTelefono});
            this.dtGVClientes.Location = new System.Drawing.Point(22, 85);
            this.dtGVClientes.Name = "dtGVClientes";
            this.dtGVClientes.RowHeadersWidth = 51;
            this.dtGVClientes.RowTemplate.Height = 24;
            this.dtGVClientes.Size = new System.Drawing.Size(540, 325);
            this.dtGVClientes.TabIndex = 42;
            this.dtGVClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVClientes_CellClick);
            // 
            // ColumCi
            // 
            this.ColumCi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumCi.HeaderText = "CI";
            this.ColumCi.MinimumWidth = 6;
            this.ColumCi.Name = "ColumCi";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // ColumDireccion
            // 
            this.ColumDireccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumDireccion.HeaderText = "Direccion";
            this.ColumDireccion.MinimumWidth = 6;
            this.ColumDireccion.Name = "ColumDireccion";
            // 
            // ColumTelefono
            // 
            this.ColumTelefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumTelefono.HeaderText = "Telefono";
            this.ColumTelefono.MinimumWidth = 6;
            this.ColumTelefono.Name = "ColumTelefono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 34);
            this.label1.TabIndex = 43;
            this.label1.Text = "Quien Compro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(594, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 34);
            this.label2.TabIndex = 44;
            this.label2.Text = "Que Compro";
            // 
            // labelFecha
            // 
            this.labelFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFecha.AutoSize = true;
            this.labelFecha.BackColor = System.Drawing.Color.White;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(522, 446);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(86, 29);
            this.labelFecha.TabIndex = 45;
            this.labelFecha.Text = "Fecha:";
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.Color.White;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(935, 446);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(74, 29);
            this.labelTotal.TabIndex = 46;
            this.labelTotal.Text = "Total:";
            // 
            // btnEliminarReporte
            // 
            this.btnEliminarReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarReporte.AutoSize = true;
            this.btnEliminarReporte.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarReporte.Location = new System.Drawing.Point(32, 430);
            this.btnEliminarReporte.Name = "btnEliminarReporte";
            this.btnEliminarReporte.Size = new System.Drawing.Size(259, 55);
            this.btnEliminarReporte.TabIndex = 47;
            this.btnEliminarReporte.Text = "Eliminar Reporte";
            this.btnEliminarReporte.UseVisualStyleBackColor = true;
            this.btnEliminarReporte.Click += new System.EventHandler(this.btnEliminarReporte_Click);
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1224, 508);
            this.Controls.Add(this.btnEliminarReporte);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtGVClientes);
            this.Controls.Add(this.dtGVProductos);
            this.Name = "FormReportes";
            this.Text = "FormReportes";
            ((System.ComponentModel.ISupportInitialize)(this.dtGVProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGVProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCantidad;
        private System.Windows.Forms.DataGridView dtGVClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumTelefono;
        private System.Windows.Forms.Button btnEliminarReporte;
    }
}