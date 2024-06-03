
namespace Proyecto_Final
{
    partial class FormListarClientes
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
            this.dtGVClientes = new System.Windows.Forms.DataGridView();
            this.ColumCi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGVClientes
            // 
            this.dtGVClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGVClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumCi,
            this.ColumNombre,
            this.ColumDireccion,
            this.ColumTelefono});
            this.dtGVClientes.Location = new System.Drawing.Point(32, 45);
            this.dtGVClientes.Name = "dtGVClientes";
            this.dtGVClientes.RowHeadersWidth = 51;
            this.dtGVClientes.RowTemplate.Height = 24;
            this.dtGVClientes.Size = new System.Drawing.Size(1165, 418);
            this.dtGVClientes.TabIndex = 41;
            this.dtGVClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVClientes_CellClick);
            // 
            // ColumCi
            // 
            this.ColumCi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumCi.HeaderText = "CI";
            this.ColumCi.MinimumWidth = 6;
            this.ColumCi.Name = "ColumCi";
            // 
            // ColumNombre
            // 
            this.ColumNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumNombre.HeaderText = "Nombre";
            this.ColumNombre.MinimumWidth = 6;
            this.ColumNombre.Name = "ColumNombre";
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
            // FormListarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1224, 508);
            this.Controls.Add(this.dtGVClientes);
            this.Name = "FormListarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormListarClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dtGVClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtGVClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumTelefono;
    }
}