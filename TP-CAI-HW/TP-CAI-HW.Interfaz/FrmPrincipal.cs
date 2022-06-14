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
            _frmClientes = new FrmClientes(this);
            _frmProductos = new FrmProductos(this);
            _frmProveedores = new FrmProveedores(this);
            _frmVentas = new FrmVentas(this);                     
            _frmReportes = new FrmReportes(this);

            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            _frmProductos.Show();
            this.Hide();

        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            _frmProveedores.Show();
            this.Hide();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            _frmClientes.Show();
            this.Hide();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            _frmVentas.Show();
            this.Hide();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            _frmReportes.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show("Este botón aún no está terminado.", "Error", buttons);
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
