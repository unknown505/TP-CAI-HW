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
            InitializeComponent();
        }

        private void _btnIngresarCliente_Click(object sender, EventArgs e)
        {
            _frmIngresarClientes = new FrmIngresarClientes(this);
            _frmIngresarClientes.Show();
            this.Hide();
        }

        private void _btnConsultarCliente_Click(object sender, EventArgs e)
        {
            _frmConsultarClientes = new FrmConsultarClientes(this);
            _frmConsultarClientes.Show();
            this.Hide();
        }
        private void _btnAtras_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }
        private void FrmClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }


    }
}
