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
    public partial class FrmVentas : Form
    {
        private FrmIngresarVentas _frmIngresarVentas;
        private FrmConsultarVentas _frmConsultarVentas;
        public FrmVentas(FrmPrincipal Owner)
        {
            _frmIngresarVentas = new FrmIngresarVentas(this);
            _frmConsultarVentas = new FrmConsultarVentas(this);
            this.Owner = Owner;
            InitializeComponent();
        }

        private void btnIngresarVenta_Click(object sender, EventArgs e)
        {
            _frmIngresarVentas.Show();
            this.Hide();
        }

        private void _btnConsultarVenta_Click(object sender, EventArgs e)
        {
            _frmConsultarVentas.Show();
            this.Hide();
        }

        private void _btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void FrmVentas_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
    }
}
