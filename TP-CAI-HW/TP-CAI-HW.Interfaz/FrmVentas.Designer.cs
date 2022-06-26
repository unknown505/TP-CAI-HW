
namespace TP_CAI_HW.Interfaz
{
    partial class FrmVentas
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
            this.btnIngresarVenta = new System.Windows.Forms.Button();
            this._btnConsultarVenta = new System.Windows.Forms.Button();
            this._lblVentas = new System.Windows.Forms.Label();
            this._btnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIngresarVenta
            // 
            this.btnIngresarVenta.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarVenta.Location = new System.Drawing.Point(78, 107);
            this.btnIngresarVenta.Name = "btnIngresarVenta";
            this.btnIngresarVenta.Size = new System.Drawing.Size(131, 36);
            this.btnIngresarVenta.TabIndex = 0;
            this.btnIngresarVenta.Text = "Ingresar Venta";
            this.btnIngresarVenta.UseVisualStyleBackColor = true;
            this.btnIngresarVenta.Click += new System.EventHandler(this.btnIngresarVenta_Click);
            // 
            // _btnConsultarVenta
            // 
            this._btnConsultarVenta.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnConsultarVenta.Location = new System.Drawing.Point(229, 107);
            this._btnConsultarVenta.Name = "_btnConsultarVenta";
            this._btnConsultarVenta.Size = new System.Drawing.Size(131, 36);
            this._btnConsultarVenta.TabIndex = 1;
            this._btnConsultarVenta.Text = "Consultar Venta";
            this._btnConsultarVenta.UseVisualStyleBackColor = true;
            this._btnConsultarVenta.Click += new System.EventHandler(this._btnConsultarVenta_Click);
            // 
            // _lblVentas
            // 
            this._lblVentas.AutoSize = true;
            this._lblVentas.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblVentas.Location = new System.Drawing.Point(158, 32);
            this._lblVentas.Name = "_lblVentas";
            this._lblVentas.Size = new System.Drawing.Size(118, 32);
            this._lblVentas.TabIndex = 2;
            this._lblVentas.Text = "VENTAS";
            // 
            // _btnAtras
            // 
            this._btnAtras.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnAtras.Location = new System.Drawing.Point(78, 173);
            this._btnAtras.Name = "_btnAtras";
            this._btnAtras.Size = new System.Drawing.Size(282, 36);
            this._btnAtras.TabIndex = 3;
            this._btnAtras.Text = "Atrás";
            this._btnAtras.UseVisualStyleBackColor = true;
            this._btnAtras.Click += new System.EventHandler(this._btnAtras_Click);
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 273);
            this.Controls.Add(this._btnAtras);
            this.Controls.Add(this._lblVentas);
            this.Controls.Add(this._btnConsultarVenta);
            this.Controls.Add(this.btnIngresarVenta);
            this.Name = "FrmVentas";
            this.Text = "Hardware Springfield - Ventas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmVentas_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarVenta;
        private System.Windows.Forms.Button _btnConsultarVenta;
        private System.Windows.Forms.Label _lblVentas;
        private System.Windows.Forms.Button _btnAtras;
    }
}