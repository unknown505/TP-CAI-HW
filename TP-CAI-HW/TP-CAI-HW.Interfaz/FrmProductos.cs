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
    public partial class FrmProductos : Form
    {
        private FrmIngresarProductos _frmIngresarProductos;
        private FrmConsultarProductos _frmConsultarProductos;

        public FrmProductos(FrmPrincipal Owner)
        {
            this.Owner = Owner;
            InitializeComponent();
        }

        private void _btnIngresarProducto_Click(object sender, EventArgs e)
        {
            _frmIngresarProductos = new FrmIngresarProductos(this);
            _frmIngresarProductos.Show();
            this.Hide();
        }

        private void _btnConsultarProducto_Click(object sender, EventArgs e)
        {
            _frmConsultarProductos = new FrmConsultarProductos(this);
            _frmConsultarProductos.Show();
            this.Hide();
        }

        private void _btnAtras_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }

        private void FrmProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }


    }
}
