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
        private FrmIngresarClientes _frmIngresarClientes;
        private FrmIngresarProductos _frmIngresarProductos;
        private FrmIngresarProveedores _frmIngresarProveedores;
        private FrmIngresarVentas _frmIngresarVentas;
        private FrmConsultarClientes _frmConsultarClientes;
        private FrmConsultarProductos _frmConsultarProductos;
        private FrmConsultarProveedores _frmConsultarProveedores;
        private FrmConsultarVentas _frmConsultarVentas;
        private FrmReportes _frmReportes;


        public FrmPrincipal()
        {
            _frmClientes = new FrmClientes(this);
            _frmProductos = new FrmProductos(this);
            _frmProveedores = new FrmProveedores(this);
            _frmVentas = new FrmVentas(this);
            _frmIngresarClientes = new FrmIngresarClientes(this);
            _frmIngresarProductos = new FrmIngresarProductos(this);
            _frmIngresarProveedores = new FrmIngresarProveedores(this);
            _frmIngresarVentas = new FrmIngresarVentas(this);
            _frmConsultarClientes = new FrmConsultarClientes(this);
            _frmConsultarProductos = new FrmConsultarProductos(this);
            _frmConsultarProveedores = new FrmConsultarProveedores(this);
            _frmConsultarVentas = new FrmConsultarVentas(this);
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

        }
    }
}
