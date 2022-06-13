
namespace TP_CAI_HW.Interfaz
{
    partial class FrmConsultarProductos
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
            this._cboBoxProducto = new System.Windows.Forms.ComboBox();
            this._btnSalir = new System.Windows.Forms.Button();
            this._btnConsultar = new System.Windows.Forms.Button();
            this._lblProductoAConsultar = new System.Windows.Forms.Label();
            this._lblProducto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _cboBoxProducto
            // 
            this._cboBoxProducto.FormattingEnabled = true;
            this._cboBoxProducto.Location = new System.Drawing.Point(152, 77);
            this._cboBoxProducto.Name = "_cboBoxProducto";
            this._cboBoxProducto.Size = new System.Drawing.Size(154, 21);
            this._cboBoxProducto.TabIndex = 52;
            // 
            // _btnSalir
            // 
            this._btnSalir.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this._btnSalir.Location = new System.Drawing.Point(49, 140);
            this._btnSalir.Name = "_btnSalir";
            this._btnSalir.Size = new System.Drawing.Size(90, 35);
            this._btnSalir.TabIndex = 51;
            this._btnSalir.Text = "Salir";
            this._btnSalir.UseVisualStyleBackColor = true;
            this._btnSalir.Click += new System.EventHandler(this._btnSalir_Click);
            // 
            // _btnConsultar
            // 
            this._btnConsultar.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this._btnConsultar.Location = new System.Drawing.Point(216, 140);
            this._btnConsultar.Name = "_btnConsultar";
            this._btnConsultar.Size = new System.Drawing.Size(90, 35);
            this._btnConsultar.TabIndex = 50;
            this._btnConsultar.Text = "Consultar";
            this._btnConsultar.UseVisualStyleBackColor = true;
            this._btnConsultar.Click += new System.EventHandler(this._btnConsultar_Click);
            // 
            // _lblProductoAConsultar
            // 
            this._lblProductoAConsultar.AutoSize = true;
            this._lblProductoAConsultar.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblProductoAConsultar.Location = new System.Drawing.Point(104, 21);
            this._lblProductoAConsultar.Name = "_lblProductoAConsultar";
            this._lblProductoAConsultar.Size = new System.Drawing.Size(156, 19);
            this._lblProductoAConsultar.TabIndex = 49;
            this._lblProductoAConsultar.Text = "Producto a Consultar";
            // 
            // _lblProducto
            // 
            this._lblProducto.AutoSize = true;
            this._lblProducto.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this._lblProducto.Location = new System.Drawing.Point(58, 78);
            this._lblProducto.Name = "_lblProducto";
            this._lblProducto.Size = new System.Drawing.Size(59, 16);
            this._lblProducto.TabIndex = 48;
            this._lblProducto.Text = "Producto";
            // 
            // FrmConsultarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 205);
            this.Controls.Add(this._cboBoxProducto);
            this.Controls.Add(this._btnSalir);
            this.Controls.Add(this._btnConsultar);
            this.Controls.Add(this._lblProductoAConsultar);
            this.Controls.Add(this._lblProducto);
            this.Name = "FrmConsultarProductos";
            this.Text = "Hardware Springfield - Consultar Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox _cboBoxProducto;
        private System.Windows.Forms.Button _btnSalir;
        private System.Windows.Forms.Button _btnConsultar;
        private System.Windows.Forms.Label _lblProductoAConsultar;
        private System.Windows.Forms.Label _lblProducto;
    }
}