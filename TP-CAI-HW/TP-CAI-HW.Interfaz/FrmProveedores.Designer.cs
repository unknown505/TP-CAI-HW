﻿
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
            this._btnSalir = new System.Windows.Forms.Button();
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
            // FrmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 273);
            this.Controls.Add(this._btnSalir);
            this.Controls.Add(this._lblProveedores);
            this.Controls.Add(this._btnConsultarProveedor);
            this.Controls.Add(this._btnIngresarProveedor);
            this.Name = "FrmProveedores";
            this.Text = "Hardware Springfield - Proveedores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnIngresarProveedor;
        private System.Windows.Forms.Button _btnConsultarProveedor;
        private System.Windows.Forms.Label _lblProveedores;
        private System.Windows.Forms.Button _btnSalir;
    }
}