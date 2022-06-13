
namespace TP_CAI_HW.Interfaz
{
    partial class FrmClientes
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
            this._btnIngresarCliente = new System.Windows.Forms.Button();
            this._btnConsultarCliente = new System.Windows.Forms.Button();
            this._lblClientes = new System.Windows.Forms.Label();
            this._btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _btnIngresarCliente
            // 
            this._btnIngresarCliente.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this._btnIngresarCliente.Location = new System.Drawing.Point(78, 107);
            this._btnIngresarCliente.Name = "_btnIngresarCliente";
            this._btnIngresarCliente.Size = new System.Drawing.Size(131, 36);
            this._btnIngresarCliente.TabIndex = 1;
            this._btnIngresarCliente.Text = "Ingresar Cliente";
            this._btnIngresarCliente.UseVisualStyleBackColor = true;
            this._btnIngresarCliente.Click += new System.EventHandler(this._btnIngresarCliente_Click);
            // 
            // _btnConsultarCliente
            // 
            this._btnConsultarCliente.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this._btnConsultarCliente.Location = new System.Drawing.Point(229, 107);
            this._btnConsultarCliente.Name = "_btnConsultarCliente";
            this._btnConsultarCliente.Size = new System.Drawing.Size(131, 36);
            this._btnConsultarCliente.TabIndex = 2;
            this._btnConsultarCliente.Text = "Consultar Cliente";
            this._btnConsultarCliente.UseVisualStyleBackColor = true;
            this._btnConsultarCliente.Click += new System.EventHandler(this._btnConsultarCliente_Click);
            // 
            // _lblClientes
            // 
            this._lblClientes.AutoSize = true;
            this._lblClientes.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold);
            this._lblClientes.Location = new System.Drawing.Point(153, 32);
            this._lblClientes.Name = "_lblClientes";
            this._lblClientes.Size = new System.Drawing.Size(135, 32);
            this._lblClientes.TabIndex = 3;
            this._lblClientes.Text = "CLIENTES";
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
            this._btnSalir.Click += new System.EventHandler(this._btnSalir_Click);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 273);
            this.Controls.Add(this._btnSalir);
            this.Controls.Add(this._lblClientes);
            this.Controls.Add(this._btnConsultarCliente);
            this.Controls.Add(this._btnIngresarCliente);
            this.Name = "FrmClientes";
            this.Text = "Hardware Springfield - Clientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnIngresarCliente;
        private System.Windows.Forms.Button _btnConsultarCliente;
        private System.Windows.Forms.Label _lblClientes;
        private System.Windows.Forms.Button _btnSalir;
    }
}