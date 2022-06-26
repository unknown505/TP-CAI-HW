
namespace TP_CAI_HW.Interfaz
{
    partial class FrmConsultarVentas
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
            this._cboBoxVenta = new System.Windows.Forms.ComboBox();
            this._btnAtras = new System.Windows.Forms.Button();
            this._btnConsultar = new System.Windows.Forms.Button();
            this._lblVentaAConsultar = new System.Windows.Forms.Label();
            this._lblVenta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _cboBoxVenta
            // 
            this._cboBoxVenta.FormattingEnabled = true;
            this._cboBoxVenta.Location = new System.Drawing.Point(152, 77);
            this._cboBoxVenta.Name = "_cboBoxVenta";
            this._cboBoxVenta.Size = new System.Drawing.Size(154, 21);
            this._cboBoxVenta.TabIndex = 47;
            // 
            // _btnAtras
            // 
            this._btnAtras.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this._btnAtras.Location = new System.Drawing.Point(49, 140);
            this._btnAtras.Name = "_btnAtras";
            this._btnAtras.Size = new System.Drawing.Size(90, 35);
            this._btnAtras.TabIndex = 44;
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
            this._btnConsultar.TabIndex = 43;
            this._btnConsultar.Text = "Consultar";
            this._btnConsultar.UseVisualStyleBackColor = true;
            this._btnConsultar.Click += new System.EventHandler(this._btnConsultar_Click);
            // 
            // _lblVentaAConsultar
            // 
            this._lblVentaAConsultar.AutoSize = true;
            this._lblVentaAConsultar.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblVentaAConsultar.Location = new System.Drawing.Point(111, 21);
            this._lblVentaAConsultar.Name = "_lblVentaAConsultar";
            this._lblVentaAConsultar.Size = new System.Drawing.Size(133, 19);
            this._lblVentaAConsultar.TabIndex = 39;
            this._lblVentaAConsultar.Text = "Venta a Consultar";
            // 
            // _lblVenta
            // 
            this._lblVenta.AutoSize = true;
            this._lblVenta.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this._lblVenta.Location = new System.Drawing.Point(55, 78);
            this._lblVenta.Name = "_lblVenta";
            this._lblVenta.Size = new System.Drawing.Size(41, 16);
            this._lblVenta.TabIndex = 37;
            this._lblVenta.Text = "Venta";
            // 
            // FrmConsultarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 205);
            this.Controls.Add(this._cboBoxVenta);
            this.Controls.Add(this._btnAtras);
            this.Controls.Add(this._btnConsultar);
            this.Controls.Add(this._lblVentaAConsultar);
            this.Controls.Add(this._lblVenta);
            this.Name = "FrmConsultarVentas";
            this.Text = "Hardware Springfield - Consultar Venta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmConsultarVentas_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox _cboBoxVenta;
        private System.Windows.Forms.Button _btnAtras;
        private System.Windows.Forms.Button _btnConsultar;
        private System.Windows.Forms.Label _lblVentaAConsultar;
        private System.Windows.Forms.Label _lblVenta;
    }
}