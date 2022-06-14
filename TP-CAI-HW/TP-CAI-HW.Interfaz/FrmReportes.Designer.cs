
namespace TP_CAI_HW.Interfaz
{
    partial class FrmReportes
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
            this._btnReporteVentasCliente = new System.Windows.Forms.Button();
            this._btnReporteProductoProveedor = new System.Windows.Forms.Button();
            this._btnAtras = new System.Windows.Forms.Button();
            this._lblReportes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _btnReporteVentasCliente
            // 
            this._btnReporteVentasCliente.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this._btnReporteVentasCliente.Location = new System.Drawing.Point(92, 81);
            this._btnReporteVentasCliente.Name = "_btnReporteVentasCliente";
            this._btnReporteVentasCliente.Size = new System.Drawing.Size(204, 47);
            this._btnReporteVentasCliente.TabIndex = 0;
            this._btnReporteVentasCliente.Text = "Reporte de Ventas x Cliente";
            this._btnReporteVentasCliente.UseVisualStyleBackColor = true;
            this._btnReporteVentasCliente.Click += new System.EventHandler(this._btnReporteVentasCliente_Click);
            // 
            // _btnReporteProductoProveedor
            // 
            this._btnReporteProductoProveedor.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this._btnReporteProductoProveedor.Location = new System.Drawing.Point(92, 149);
            this._btnReporteProductoProveedor.Name = "_btnReporteProductoProveedor";
            this._btnReporteProductoProveedor.Size = new System.Drawing.Size(204, 47);
            this._btnReporteProductoProveedor.TabIndex = 1;
            this._btnReporteProductoProveedor.Text = "Reporte de Productos x Proveedor";
            this._btnReporteProductoProveedor.UseVisualStyleBackColor = true;
            this._btnReporteProductoProveedor.Click += new System.EventHandler(this._btnReporteProductoProveedor_Click);
            // 
            // _btnAtras
            // 
            this._btnAtras.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this._btnAtras.Location = new System.Drawing.Point(92, 217);
            this._btnAtras.Name = "_btnAtras";
            this._btnAtras.Size = new System.Drawing.Size(204, 47);
            this._btnAtras.TabIndex = 2;
            this._btnAtras.Text = "Atras";
            this._btnAtras.UseVisualStyleBackColor = true;
            this._btnAtras.Click += new System.EventHandler(this._btnAtras_Click);
            // 
            // _lblReportes
            // 
            this._lblReportes.AutoSize = true;
            this._lblReportes.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold);
            this._lblReportes.Location = new System.Drawing.Point(117, 21);
            this._lblReportes.Name = "_lblReportes";
            this._lblReportes.Size = new System.Drawing.Size(147, 32);
            this._lblReportes.TabIndex = 3;
            this._lblReportes.Text = "REPORTES";
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 291);
            this.Controls.Add(this._lblReportes);
            this.Controls.Add(this._btnAtras);
            this.Controls.Add(this._btnReporteProductoProveedor);
            this.Controls.Add(this._btnReporteVentasCliente);
            this.Name = "FrmReportes";
            this.Text = "Hardware Springfield - Reportes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmReportes_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnReporteVentasCliente;
        private System.Windows.Forms.Button _btnReporteProductoProveedor;
        private System.Windows.Forms.Button _btnAtras;
        private System.Windows.Forms.Label _lblReportes;
    }
}