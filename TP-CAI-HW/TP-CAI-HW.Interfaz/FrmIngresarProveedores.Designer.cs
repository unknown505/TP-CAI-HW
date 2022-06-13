
namespace TP_CAI_HW.Interfaz
{
    partial class FrmIngresarProveedores
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
            this._lblIDProducto = new System.Windows.Forms.Label();
            this._btnLimpiar = new System.Windows.Forms.Button();
            this._btnSalir = new System.Windows.Forms.Button();
            this._btnIngresar = new System.Windows.Forms.Button();
            this._txtMail = new System.Windows.Forms.TextBox();
            this._txtDireccion = new System.Windows.Forms.TextBox();
            this._txtApellido = new System.Windows.Forms.TextBox();
            this._txtNombre = new System.Windows.Forms.TextBox();
            this._lblProveedorAIngresar = new System.Windows.Forms.Label();
            this._lblMail = new System.Windows.Forms.Label();
            this._lblCuit = new System.Windows.Forms.Label();
            this._lblApellido = new System.Windows.Forms.Label();
            this._lblNombre = new System.Windows.Forms.Label();
            this._cboBoxProducto = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // _lblIDProducto
            // 
            this._lblIDProducto.AutoSize = true;
            this._lblIDProducto.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this._lblIDProducto.Location = new System.Drawing.Point(58, 235);
            this._lblIDProducto.Name = "_lblIDProducto";
            this._lblIDProducto.Size = new System.Drawing.Size(59, 16);
            this._lblIDProducto.TabIndex = 32;
            this._lblIDProducto.Text = "Producto";
            // 
            // _btnLimpiar
            // 
            this._btnLimpiar.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this._btnLimpiar.Location = new System.Drawing.Point(61, 291);
            this._btnLimpiar.Name = "_btnLimpiar";
            this._btnLimpiar.Size = new System.Drawing.Size(90, 35);
            this._btnLimpiar.TabIndex = 31;
            this._btnLimpiar.Text = "Limpiar";
            this._btnLimpiar.UseVisualStyleBackColor = true;
            this._btnLimpiar.Click += new System.EventHandler(this._btnLimpiar_Click);
            // 
            // _btnSalir
            // 
            this._btnSalir.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this._btnSalir.Location = new System.Drawing.Point(319, 353);
            this._btnSalir.Name = "_btnSalir";
            this._btnSalir.Size = new System.Drawing.Size(90, 35);
            this._btnSalir.TabIndex = 30;
            this._btnSalir.Text = "Salir";
            this._btnSalir.UseVisualStyleBackColor = true;
            this._btnSalir.Click += new System.EventHandler(this._btnSalir_Click);
            // 
            // _btnIngresar
            // 
            this._btnIngresar.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this._btnIngresar.Location = new System.Drawing.Point(319, 291);
            this._btnIngresar.Name = "_btnIngresar";
            this._btnIngresar.Size = new System.Drawing.Size(90, 35);
            this._btnIngresar.TabIndex = 29;
            this._btnIngresar.Text = "Ingresar";
            this._btnIngresar.UseVisualStyleBackColor = true;
            this._btnIngresar.Click += new System.EventHandler(this._btnIngresar_Click);
            // 
            // _txtMail
            // 
            this._txtMail.Location = new System.Drawing.Point(209, 196);
            this._txtMail.Name = "_txtMail";
            this._txtMail.Size = new System.Drawing.Size(200, 20);
            this._txtMail.TabIndex = 28;
            // 
            // _txtDireccion
            // 
            this._txtDireccion.Location = new System.Drawing.Point(209, 158);
            this._txtDireccion.Name = "_txtDireccion";
            this._txtDireccion.Size = new System.Drawing.Size(200, 20);
            this._txtDireccion.TabIndex = 26;
            // 
            // _txtApellido
            // 
            this._txtApellido.Location = new System.Drawing.Point(209, 123);
            this._txtApellido.Name = "_txtApellido";
            this._txtApellido.Size = new System.Drawing.Size(200, 20);
            this._txtApellido.TabIndex = 25;
            // 
            // _txtNombre
            // 
            this._txtNombre.Location = new System.Drawing.Point(209, 86);
            this._txtNombre.Name = "_txtNombre";
            this._txtNombre.Size = new System.Drawing.Size(200, 20);
            this._txtNombre.TabIndex = 24;
            // 
            // _lblProveedorAIngresar
            // 
            this._lblProveedorAIngresar.AutoSize = true;
            this._lblProveedorAIngresar.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblProveedorAIngresar.Location = new System.Drawing.Point(156, 11);
            this._lblProveedorAIngresar.Name = "_lblProveedorAIngresar";
            this._lblProveedorAIngresar.Size = new System.Drawing.Size(155, 19);
            this._lblProveedorAIngresar.TabIndex = 23;
            this._lblProveedorAIngresar.Text = "Proveedor a Ingresar";
            // 
            // _lblMail
            // 
            this._lblMail.AutoSize = true;
            this._lblMail.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this._lblMail.Location = new System.Drawing.Point(58, 197);
            this._lblMail.Name = "_lblMail";
            this._lblMail.Size = new System.Drawing.Size(31, 16);
            this._lblMail.TabIndex = 22;
            this._lblMail.Text = "Mail";
            // 
            // _lblCuit
            // 
            this._lblCuit.AutoSize = true;
            this._lblCuit.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this._lblCuit.Location = new System.Drawing.Point(58, 159);
            this._lblCuit.Name = "_lblCuit";
            this._lblCuit.Size = new System.Drawing.Size(35, 16);
            this._lblCuit.TabIndex = 20;
            this._lblCuit.Text = "CUIT";
            // 
            // _lblApellido
            // 
            this._lblApellido.AutoSize = true;
            this._lblApellido.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this._lblApellido.Location = new System.Drawing.Point(58, 124);
            this._lblApellido.Name = "_lblApellido";
            this._lblApellido.Size = new System.Drawing.Size(53, 16);
            this._lblApellido.TabIndex = 19;
            this._lblApellido.Text = "Apellido";
            // 
            // _lblNombre
            // 
            this._lblNombre.AutoSize = true;
            this._lblNombre.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this._lblNombre.Location = new System.Drawing.Point(58, 87);
            this._lblNombre.Name = "_lblNombre";
            this._lblNombre.Size = new System.Drawing.Size(54, 16);
            this._lblNombre.TabIndex = 18;
            this._lblNombre.Text = "Nombre";
            // 
            // _cboBoxProducto
            // 
            this._cboBoxProducto.FormattingEnabled = true;
            this._cboBoxProducto.Location = new System.Drawing.Point(209, 234);
            this._cboBoxProducto.Name = "_cboBoxProducto";
            this._cboBoxProducto.Size = new System.Drawing.Size(200, 21);
            this._cboBoxProducto.TabIndex = 33;
            // 
            // FrmIngresarProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 410);
            this.Controls.Add(this._cboBoxProducto);
            this.Controls.Add(this._lblIDProducto);
            this.Controls.Add(this._btnLimpiar);
            this.Controls.Add(this._btnSalir);
            this.Controls.Add(this._btnIngresar);
            this.Controls.Add(this._txtMail);
            this.Controls.Add(this._txtDireccion);
            this.Controls.Add(this._txtApellido);
            this.Controls.Add(this._txtNombre);
            this.Controls.Add(this._lblProveedorAIngresar);
            this.Controls.Add(this._lblMail);
            this.Controls.Add(this._lblCuit);
            this.Controls.Add(this._lblApellido);
            this.Controls.Add(this._lblNombre);
            this.Name = "FrmIngresarProveedores";
            this.Text = "Hardware Springfield - Ingresar Proveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label _lblIDProducto;
        private System.Windows.Forms.Button _btnLimpiar;
        private System.Windows.Forms.Button _btnSalir;
        private System.Windows.Forms.Button _btnIngresar;
        private System.Windows.Forms.TextBox _txtMail;
        private System.Windows.Forms.TextBox _txtDireccion;
        private System.Windows.Forms.TextBox _txtApellido;
        private System.Windows.Forms.TextBox _txtNombre;
        private System.Windows.Forms.Label _lblProveedorAIngresar;
        private System.Windows.Forms.Label _lblMail;
        private System.Windows.Forms.Label _lblCuit;
        private System.Windows.Forms.Label _lblApellido;
        private System.Windows.Forms.Label _lblNombre;
        private System.Windows.Forms.ComboBox _cboBoxProducto;
    }
}