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
    public partial class FrmClientes : Form
    {
        private FrmIngresarClientes _frmIngresarClientes;
        private FrmConsultarClientes _frmConsultarClientes;
        public FrmClientes(FrmPrincipal Owner)
        {
            this.Owner = Owner;
            _frmIngresarClientes = new FrmIngresarClientes(this);
            _frmConsultarClientes = new FrmConsultarClientes(this);            
            InitializeComponent();
        }

        private void _btnIngresarCliente_Click(object sender, EventArgs e)
        {
            _frmIngresarClientes.Show();
            this.Hide();
        }

        private void _btnConsultarCliente_Click(object sender, EventArgs e)
        {
            _frmConsultarClientes.Show();
            this.Hide();
        }

        private void _btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void FrmClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
    }
}
