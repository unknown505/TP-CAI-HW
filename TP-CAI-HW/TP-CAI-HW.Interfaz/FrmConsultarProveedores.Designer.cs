﻿
namespace TP_CAI_HW.Interfaz
{
    partial class FrmConsultarProveedores
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
            this._cboBoxProveedor = new System.Windows.Forms.ComboBox();
            this._btnAtras = new System.Windows.Forms.Button();
            this._btnConsultar = new System.Windows.Forms.Button();
            this._lblProveedorAConsultar = new System.Windows.Forms.Label();
            this._lblProveedor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _cboBoxProveedor
            // 
            this._cboBoxProveedor.FormattingEnabled = true;
            this._cboBoxProveedor.Location = new System.Drawing.Point(152, 77);
            this._cboBoxProveedor.Name = "_cboBoxProveedor";
            this._cboBoxProveedor.Size = new System.Drawing.Size(154, 21);
            this._cboBoxProveedor.TabIndex = 52;
            // 
            // _btnAtras
            // 
            this._btnAtras.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this._btnAtras.Location = new System.Drawing.Point(49, 140);
            this._btnAtras.Name = "_btnAtras";
            this._btnAtras.Size = new System.Drawing.Size(90, 35);
            this._btnAtras.TabIndex = 51;
            this._btnAtras.Text = "Atrás";
            this._btnAtras.UseVisualStyleBackColor = true;
            this._btnAtras.Click += new System.EventHandler(this._btnAtras_Click);
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
            // _lblProveedorAConsultar
            // 
            this._lblProveedorAConsultar.AutoSize = true;
            this._lblProveedorAConsultar.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblProveedorAConsultar.Location = new System.Drawing.Point(97, 21);
            this._lblProveedorAConsultar.Name = "_lblProveedorAConsultar";
            this._lblProveedorAConsultar.Size = new System.Drawing.Size(164, 19);
            this._lblProveedorAConsultar.TabIndex = 49;
            this._lblProveedorAConsultar.Text = "Proveedor a Consultar";
            // 
            // _lblProveedor
            // 
            this._lblProveedor.AutoSize = true;
            this._lblProveedor.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this._lblProveedor.Location = new System.Drawing.Point(55, 78);
            this._lblProveedor.Name = "_lblProveedor";
            this._lblProveedor.Size = new System.Drawing.Size(67, 16);
            this._lblProveedor.TabIndex = 48;
            this._lblProveedor.Text = "Proveedor";
            // 
            // FrmConsultarProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 205);
            this.Controls.Add(this._cboBoxProveedor);
            this.Controls.Add(this._btnAtras);
            this.Controls.Add(this._btnConsultar);
            this.Controls.Add(this._lblProveedorAConsultar);
            this.Controls.Add(this._lblProveedor);
            this.Name = "FrmConsultarProveedores";
            this.Text = "Hardware Springfield - Consultar Proveedor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmConsultarProveedores_FormClosing);
            this.Load += new System.EventHandler(this.FrmConsultarProveedores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox _cboBoxProveedor;
        private System.Windows.Forms.Button _btnAtras;
        private System.Windows.Forms.Button _btnConsultar;
        private System.Windows.Forms.Label _lblProveedorAConsultar;
        private System.Windows.Forms.Label _lblProveedor;
    }
}