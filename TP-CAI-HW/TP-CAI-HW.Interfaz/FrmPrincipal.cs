using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_CAI_HW.Interfaz
{
    public partial class FrmPrincipal : Form
    {
        private FrmClientes _frmClientes;
        private FrmProductos _frmProductos;
        private FrmProveedores _frmProveedores;
        private FrmVentas _frmVentas;        
        private FrmReportes _frmReportes;


        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            _frmProductos = new FrmProductos(this);
            _frmProductos.Show();
            this.Hide();

        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            _frmProveedores = new FrmProveedores(this);
            _frmProveedores.Show();
            this.Hide();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            _frmClientes = new FrmClientes(this);
            _frmClientes.Show();
            this.Hide();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            _frmVentas = new FrmVentas(this);
            _frmVentas.Show();
            this.Hide();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            _frmReportes = new FrmReportes(this);
            _frmReportes.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "¿Quiere salir del sistema?";
            string title = "Test";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {

            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
