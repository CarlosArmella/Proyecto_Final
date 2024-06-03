
namespace Proyecto_Final
{
    partial class FormListarProductos
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
            this.btnOrdNombre = new System.Windows.Forms.Button();
            this.btnOrdPrecio = new System.Windows.Forms.Button();
            this.btnOrdCodigo = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVProductos)).BeginInit();
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
            this.ColumPrecio});
            this.dtGVProductos.Location = new System.Drawing.Point(55, 90);
            this.dtGVProductos.Name = "dtGVProductos";
            this.dtGVProductos.RowHeadersWidth = 51;
            this.dtGVProductos.RowTemplate.Height = 24;
            this.dtGVProductos.Size = new System.Drawing.Size(1121, 299);
            this.dtGVProductos.TabIndex = 25;
            this.dtGVProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVProductos_CellClick);
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
            // btnOrdNombre
            // 
            this.btnOrdNombre.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOrdNombre.AutoSize = true;
            this.btnOrdNombre.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdNombre.Location = new System.Drawing.Point(509, 421);
            this.btnOrdNombre.Name = "btnOrdNombre";
            this.btnOrdNombre.Size = new System.Drawing.Size(215, 46);
            this.btnOrdNombre.TabIndex = 29;
            this.btnOrdNombre.Text = "Ordenar X Nombre";
            this.btnOrdNombre.UseVisualStyleBackColor = true;
            this.btnOrdNombre.Click += new System.EventHandler(this.btnOrdNombre_Click);
            // 
            // btnOrdPrecio
            // 
            this.btnOrdPrecio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOrdPrecio.AutoSize = true;
            this.btnOrdPrecio.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdPrecio.Location = new System.Drawing.Point(762, 421);
            this.btnOrdPrecio.Name = "btnOrdPrecio";
            this.btnOrdPrecio.Size = new System.Drawing.Size(215, 46);
            this.btnOrdPrecio.TabIndex = 28;
            this.btnOrdPrecio.Text = "Ordenar X Precio";
            this.btnOrdPrecio.UseVisualStyleBackColor = true;
            this.btnOrdPrecio.Click += new System.EventHandler(this.btnOrdPrecio_Click);
            // 
            // btnOrdCodigo
            // 
            this.btnOrdCodigo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOrdCodigo.AutoSize = true;
            this.btnOrdCodigo.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdCodigo.Location = new System.Drawing.Point(257, 421);
            this.btnOrdCodigo.Name = "btnOrdCodigo";
            this.btnOrdCodigo.Size = new System.Drawing.Size(215, 46);
            this.btnOrdCodigo.TabIndex = 27;
            this.btnOrdCodigo.Text = "Ordenar X Codigo";
            this.btnOrdCodigo.UseVisualStyleBackColor = true;
            this.btnOrdCodigo.Click += new System.EventHandler(this.btnOrdCodigo_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(237, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(897, 27);
            this.textBox1.TabIndex = 30;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(115, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 26);
            this.label1.TabIndex = 31;
            this.label1.Text = "Buscar:";
            // 
            // FormListarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1224, 508);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnOrdNombre);
            this.Controls.Add(this.btnOrdPrecio);
            this.Controls.Add(this.btnOrdCodigo);
            this.Controls.Add(this.dtGVProductos);
            this.Name = "FormListarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormListarProductos";
            ((System.ComponentModel.ISupportInitialize)(this.dtGVProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtGVProductos;
        private System.Windows.Forms.Button btnOrdNombre;
        private System.Windows.Forms.Button btnOrdPrecio;
        private System.Windows.Forms.Button btnOrdCodigo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumPrecio;
        private System.Windows.Forms.Label label1;
    }
}