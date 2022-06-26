
namespace TP_CAI_HW.Interfaz
{
    partial class FrmConsultarClientes
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
            this._cboBoxCliente = new System.Windows.Forms.ComboBox();
            this._btnAtras = new System.Windows.Forms.Button();
            this._btnConsultar = new System.Windows.Forms.Button();
            this._lblClienteAConsultar = new System.Windows.Forms.Label();
            this._lblCliente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _cboBoxCliente
            // 
            this._cboBoxCliente.FormattingEnabled = true;
            this._cboBoxCliente.Location = new System.Drawing.Point(152, 77);
            this._cboBoxCliente.Name = "_cboBoxCliente";
            this._cboBoxCliente.Size = new System.Drawing.Size(154, 21);
            this._cboBoxCliente.TabIndex = 52;
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
            // _lblClienteAConsultar
            // 
            this._lblClienteAConsultar.AutoSize = true;
            this._lblClienteAConsultar.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblClienteAConsultar.Location = new System.Drawing.Point(111, 20);
            this._lblClienteAConsultar.Name = "_lblClienteAConsultar";
            this._lblClienteAConsultar.Size = new System.Drawing.Size(140, 19);
            this._lblClienteAConsultar.TabIndex = 49;
            this._lblClienteAConsultar.Text = "Cliente a Consultar";
            // 
            // _lblCliente
            // 
            this._lblCliente.AutoSize = true;
            this._lblCliente.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this._lblCliente.Location = new System.Drawing.Point(59, 78);
            this._lblCliente.Name = "_lblCliente";
            this._lblCliente.Size = new System.Drawing.Size(47, 16);
            this._lblCliente.TabIndex = 48;
            this._lblCliente.Text = "Cliente";
            // 
            // FrmConsultarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 205);
            this.Controls.Add(this._cboBoxCliente);
            this.Controls.Add(this._btnAtras);
            this.Controls.Add(this._btnConsultar);
            this.Controls.Add(this._lblClienteAConsultar);
            this.Controls.Add(this._lblCliente);
            this.Name = "FrmConsultarClientes";
            this.Text = "Hardware Springfield - Consultar Cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmConsultarClientes_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox _cboBoxCliente;
        private System.Windows.Forms.Button _btnAtras;
        private System.Windows.Forms.Button _btnConsultar;
        private System.Windows.Forms.Label _lblClienteAConsultar;
        private System.Windows.Forms.Label _lblCliente;
    }
}