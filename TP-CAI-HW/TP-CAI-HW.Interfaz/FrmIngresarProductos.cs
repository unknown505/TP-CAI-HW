using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_CAI_HW.Entidades.Enum;
using TP_CAI_WH.Negocio;

namespace TP_CAI_HW.Interfaz
{
    public partial class FrmIngresarProductos : Form
    {
        private ProveedoresNegocio _serviciosProveedores;

        public FrmIngresarProductos(FrmProductos Owner)
        {            
            this.Owner = Owner;
            _serviciosProveedores = new ProveedoresNegocio();
            InitializeComponent();
        }

        private void _btnLimpiar_Click(object sender, EventArgs e)
        {
            _txtNombre.Text = string.Empty;
            _txtPrecio.Text = string.Empty;
            _txtStock.Text = string.Empty;
            _cboBoxCategoria.SelectedIndex = -1;
            _cboBoxProveedor.SelectedIndex = -1;
        }

        private void _btnIngresar_Click(object sender, EventArgs e)
        {

        }

        private void _btnAtras_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }

        private void FrmIngresarProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }

        private void FrmIngresarProductos_Load(object sender, EventArgs e)
        {


            _cboBoxCategoria.DataSource = null;
            _cboBoxCategoria.DataSource = Enum.GetValues(typeof(Categorias));
            _cboBoxCategoria.SelectedIndex = -1;

            _cboBoxProveedor.DataSource = null;
            _cboBoxProveedor.DataSource = _serviciosProveedores.TraerProveedores();
            _cboBoxProveedor.SelectedIndex = -1;
        }
    }
}
