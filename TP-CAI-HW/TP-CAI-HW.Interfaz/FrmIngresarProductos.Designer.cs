
namespace TP_CAI_HW.Interfaz
{
    partial class FrmIngresarProductos
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
            this._btnLimpiar = new System.Windows.Forms.Button();
            this._btnAtras = new System.Windows.Forms.Button();
            this._btnIngresar = new System.Windows.Forms.Button();
            this._txtPrecio = new System.Windows.Forms.TextBox();
            this._txtStock = new System.Windows.Forms.TextBox();
            this._txtNombre = new System.Windows.Forms.TextBox();
            this._lblProductoAIngresar = new System.Windows.Forms.Label();
            this._lblCategoria = new System.Windows.Forms.Label();
            this._lblProveedor = new System.Windows.Forms.Label();
            this._lblPrecio = new System.Windows.Forms.Label();
            this._lblStock = new System.Windows.Forms.Label();
            this._lblNombre = new System.Windows.Forms.Label();
            this._cboBoxCategoria = new System.Windows.Forms.ComboBox();
            this._cboBoxProveedor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // _btnLimpiar
            // 
            this._btnLimpiar.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this._btnLimpiar.Location = new System.Drawing.Point(61, 280);
            this._btnLimpiar.Name = "_btnLimpiar";
            this._btnLimpiar.Size = new System.Drawing.Size(90, 35);
            this._btnLimpiar.TabIndex = 31;
            this._btnLimpiar.Text = "Limpiar";
            this._btnLimpiar.UseVisualStyleBackColor = true;
            this._btnLimpiar.Click += new System.EventHandler(this._btnLimpiar_Click);
            // 
            // _btnAtras
            // 
            this._btnAtras.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this._btnAtras.Location = new System.Drawing.Point(61, 345);
            this._btnAtras.Name = "_btnAtras";
            this._btnAtras.Size = new System.Drawing.Size(90, 35);
            this._btnAtras.TabIndex = 30;
            this._btnAtras.Text = "Atrás";
            this._btnAtras.UseVisualStyleBackColor = true;
            this._btnAtras.Click += new System.EventHandler(this._btnAtras_Click);
            // 
            // _btnIngresar
            // 
            this._btnIngresar.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this._btnIngresar.Location = new System.Drawing.Point(319, 280);
            this._btnIngresar.Name = "_btnIngresar";
            this._btnIngresar.Size = new System.Drawing.Size(90, 35);
            this._btnIngresar.TabIndex = 29;
            this._btnIngresar.Text = "Ingresar";
            this._btnIngresar.UseVisualStyleBackColor = true;
            this._btnIngresar.Click += new System.EventHandler(this._btnIngresar_Click);
            // 
            // _txtPrecio
            // 
            this._txtPrecio.Location = new System.Drawing.Point(209, 216);
            this._txtPrecio.Name = "_txtPrecio";
            this._txtPrecio.Size = new System.Drawing.Size(200, 20);
            this._txtPrecio.TabIndex = 26;
            // 
            // _txtStock
            // 
            this._txtStock.Location = new System.Drawing.Point(209, 181);
            this._txtStock.Name = "_txtStock";
            this._txtStock.Size = new System.Drawing.Size(200, 20);
            this._txtStock.TabIndex = 25;
            // 
            // _txtNombre
            // 
            this._txtNombre.Location = new System.Drawing.Point(209, 78);
            this._txtNombre.Name = "_txtNombre";
            this._txtNombre.Size = new System.Drawing.Size(200, 20);
            this._txtNombre.TabIndex = 24;
            // 
            // _lblProductoAIngresar
            // 
            this._lblProductoAIngresar.AutoSize = true;
            this._lblProductoAIngresar.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblProductoAIngresar.Location = new System.Drawing.Point(156, 11);
            this._lblProductoAIngresar.Name = "_lblProductoAIngresar";
            this._lblProductoAIngresar.Size = new System.Drawing.Size(147, 19);
            this._lblProductoAIngresar.TabIndex = 23;
            this._lblProductoAIngresar.Text = "Producto a Ingresar";
            // 
            // _lblCategoria
            // 
            this._lblCategoria.AutoSize = true;
            this._lblCategoria.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this._lblCategoria.Location = new System.Drawing.Point(58, 147);
            this._lblCategoria.Name = "_lblCategoria";
            this._lblCategoria.Size = new System.Drawing.Size(61, 16);
            this._lblCategoria.TabIndex = 22;
            this._lblCategoria.Text = "Categoria";
            // 
            // _lblProveedor
            // 
            this._lblProveedor.AutoSize = true;
            this._lblProveedor.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this._lblProveedor.Location = new System.Drawing.Point(58, 112);
            this._lblProveedor.Name = "_lblProveedor";
            this._lblProveedor.Size = new System.Drawing.Size(67, 16);
            this._lblProveedor.TabIndex = 21;
            this._lblProveedor.Text = "Proveedor";
            // 
            // _lblPrecio
            // 
            this._lblPrecio.AutoSize = true;
            this._lblPrecio.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this._lblPrecio.Location = new System.Drawing.Point(58, 217);
            this._lblPrecio.Name = "_lblPrecio";
            this._lblPrecio.Size = new System.Drawing.Size(43, 16);
            this._lblPrecio.TabIndex = 20;
            this._lblPrecio.Text = "Precio";
            // 
            // _lblStock
            // 
            this._lblStock.AutoSize = true;
            this._lblStock.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this._lblStock.Location = new System.Drawing.Point(58, 182);
            this._lblStock.Name = "_lblStock";
            this._lblStock.Size = new System.Drawing.Size(40, 16);
            this._lblStock.TabIndex = 19;
            this._lblStock.Text = "Stock";
            // 
            // _lblNombre
            // 
            this._lblNombre.AutoSize = true;
            this._lblNombre.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this._lblNombre.Location = new System.Drawing.Point(58, 79);
            this._lblNombre.Name = "_lblNombre";
            this._lblNombre.Size = new System.Drawing.Size(54, 16);
            this._lblNombre.TabIndex = 18;
            this._lblNombre.Text = "Nombre";
            // 
            // _cboBoxCategoria
            // 
            this._cboBoxCategoria.FormattingEnabled = true;
            this._cboBoxCategoria.Location = new System.Drawing.Point(209, 146);
            this._cboBoxCategoria.Name = "_cboBoxCategoria";
            this._cboBoxCategoria.Size = new System.Drawing.Size(200, 21);
            this._cboBoxCategoria.TabIndex = 32;
            // 
            // _cboBoxProveedor
            // 
            this._cboBoxProveedor.FormattingEnabled = true;
            this._cboBoxProveedor.Location = new System.Drawing.Point(209, 111);
            this._cboBoxProveedor.Name = "_cboBoxProveedor";
            this._cboBoxProveedor.Size = new System.Drawing.Size(200, 21);
            this._cboBoxProveedor.TabIndex = 33;
            // 
            // FrmIngresarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 410);
            this.Controls.Add(this._cboBoxProveedor);
            this.Controls.Add(this._cboBoxCategoria);
            this.Controls.Add(this._btnLimpiar);
            this.Controls.Add(this._btnAtras);
            this.Controls.Add(this._btnIngresar);
            this.Controls.Add(this._txtPrecio);
            this.Controls.Add(this._txtStock);
            this.Controls.Add(this._txtNombre);
            this.Controls.Add(this._lblProductoAIngresar);
            this.Controls.Add(this._lblCategoria);
            this.Controls.Add(this._lblProveedor);
            this.Controls.Add(this._lblPrecio);
            this.Controls.Add(this._lblStock);
            this.Controls.Add(this._lblNombre);
            this.Name = "FrmIngresarProductos";
            this.Text = "Hardware Springfield - Ingresar Producto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmIngresarProductos_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnLimpiar;
        private System.Windows.Forms.Button _btnAtras;
        private System.Windows.Forms.Button _btnIngresar;
        private System.Windows.Forms.TextBox _txtPrecio;
        private System.Windows.Forms.TextBox _txtStock;
        private System.Windows.Forms.TextBox _txtNombre;
        private System.Windows.Forms.Label _lblProductoAIngresar;
        private System.Windows.Forms.Label _lblCategoria;
        private System.Windows.Forms.Label _lblProveedor;
        private System.Windows.Forms.Label _lblPrecio;
        private System.Windows.Forms.Label _lblStock;
        private System.Windows.Forms.Label _lblNombre;
        private System.Windows.Forms.ComboBox _cboBoxCategoria;
        private System.Windows.Forms.ComboBox _cboBoxProveedor;
    }
}