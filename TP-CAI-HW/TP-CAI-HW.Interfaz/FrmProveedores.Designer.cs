
namespace TP_CAI_HW.Interfaz
{
    partial class FrmProveedores
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
            this._btnIngresarProveedor = new System.Windows.Forms.Button();
            this._btnConsultarProveedor = new System.Windows.Forms.Button();
            this._lblProveedores = new System.Windows.Forms.Label();
            this._btnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _btnIngresarProveedor
            // 
            this._btnIngresarProveedor.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this._btnIngresarProveedor.Location = new System.Drawing.Point(78, 107);
            this._btnIngresarProveedor.Name = "_btnIngresarProveedor";
            this._btnIngresarProveedor.Size = new System.Drawing.Size(131, 36);
            this._btnIngresarProveedor.TabIndex = 1;
            this._btnIngresarProveedor.Text = "Ingresar Proveedor";
            this._btnIngresarProveedor.UseVisualStyleBackColor = true;
            this._btnIngresarProveedor.Click += new System.EventHandler(this._btnIngresarProveedor_Click);
            // 
            // _btnConsultarProveedor
            // 
            this._btnConsultarProveedor.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this._btnConsultarProveedor.Location = new System.Drawing.Point(229, 107);
            this._btnConsultarProveedor.Name = "_btnConsultarProveedor";
            this._btnConsultarProveedor.Size = new System.Drawing.Size(131, 36);
            this._btnConsultarProveedor.TabIndex = 2;
            this._btnConsultarProveedor.Text = "Consultar Proveedor";
            this._btnConsultarProveedor.UseVisualStyleBackColor = true;
            this._btnConsultarProveedor.Click += new System.EventHandler(this._btnConsultarProveedor_Click);
            // 
            // _lblProveedores
            // 
            this._lblProveedores.AutoSize = true;
            this._lblProveedores.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold);
            this._lblProveedores.Location = new System.Drawing.Point(121, 32);
            this._lblProveedores.Name = "_lblProveedores";
            this._lblProveedores.Size = new System.Drawing.Size(203, 32);
            this._lblProveedores.TabIndex = 3;
            this._lblProveedores.Text = "PROVEEDORES";
            // 
            // _btnAtras
            // 
            this._btnAtras.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this._btnAtras.Location = new System.Drawing.Point(78, 173);
            this._btnAtras.Name = "_btnAtras";
            this._btnAtras.Size = new System.Drawing.Size(282, 36);
            this._btnAtras.TabIndex = 4;
            this._btnAtras.Text = "Atrás";
            this._btnAtras.UseVisualStyleBackColor = true;
            this._btnAtras.Click += new System.EventHandler(this._btnAtras_Click);
            // 
            // FrmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 273);
            this.Controls.Add(this._btnAtras);
            this.Controls.Add(this._lblProveedores);
            this.Controls.Add(this._btnConsultarProveedor);
            this.Controls.Add(this._btnIngresarProveedor);
            this.Name = "FrmProveedores";
            this.Text = "Hardware Springfield - Proveedores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmProveedores_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnIngresarProveedor;
        private System.Windows.Forms.Button _btnConsultarProveedor;
        private System.Windows.Forms.Label _lblProveedores;
        private System.Windows.Forms.Button _btnAtras;
    }
}