
namespace TP_CAI_HW.Interfaz
{
    partial class FrmProductos
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
            this._btnIngresarProducto = new System.Windows.Forms.Button();
            this._btnConsultarProducto = new System.Windows.Forms.Button();
            this._lblProductos = new System.Windows.Forms.Label();
            this._btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _btnIngresarProducto
            // 
            this._btnIngresarProducto.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this._btnIngresarProducto.Location = new System.Drawing.Point(78, 107);
            this._btnIngresarProducto.Name = "_btnIngresarProducto";
            this._btnIngresarProducto.Size = new System.Drawing.Size(131, 36);
            this._btnIngresarProducto.TabIndex = 1;
            this._btnIngresarProducto.Text = "Ingresar Producto";
            this._btnIngresarProducto.UseVisualStyleBackColor = true;
            // 
            // _btnConsultarProducto
            // 
            this._btnConsultarProducto.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this._btnConsultarProducto.Location = new System.Drawing.Point(229, 107);
            this._btnConsultarProducto.Name = "_btnConsultarProducto";
            this._btnConsultarProducto.Size = new System.Drawing.Size(131, 36);
            this._btnConsultarProducto.TabIndex = 2;
            this._btnConsultarProducto.Text = "Consultar Producto";
            this._btnConsultarProducto.UseVisualStyleBackColor = true;
            // 
            // _lblProductos
            // 
            this._lblProductos.AutoSize = true;
            this._lblProductos.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold);
            this._lblProductos.Location = new System.Drawing.Point(128, 32);
            this._lblProductos.Name = "_lblProductos";
            this._lblProductos.Size = new System.Drawing.Size(178, 32);
            this._lblProductos.TabIndex = 3;
            this._lblProductos.Text = "PRODUCTOS";
            // 
            // _btnSalir
            // 
            this._btnSalir.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this._btnSalir.Location = new System.Drawing.Point(78, 173);
            this._btnSalir.Name = "_btnSalir";
            this._btnSalir.Size = new System.Drawing.Size(282, 36);
            this._btnSalir.TabIndex = 4;
            this._btnSalir.Text = "Salir";
            this._btnSalir.UseVisualStyleBackColor = true;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 273);
            this.Controls.Add(this._btnSalir);
            this.Controls.Add(this._lblProductos);
            this.Controls.Add(this._btnConsultarProducto);
            this.Controls.Add(this._btnIngresarProducto);
            this.Name = "FrmProductos";
            this.Text = "Hardware Springfield - Productos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnIngresarProducto;
        private System.Windows.Forms.Button _btnConsultarProducto;
        private System.Windows.Forms.Label _lblProductos;
        private System.Windows.Forms.Button _btnSalir;
    }
}