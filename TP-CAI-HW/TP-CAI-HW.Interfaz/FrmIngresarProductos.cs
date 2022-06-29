using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_CAI_HW.Negocio;
using TP_CAI_HW.Entidades;
using TP_CAI_HW.Entidades.Enum;

namespace TP_CAI_HW.Interfaz
{
    public partial class FrmIngresarProductos : Form
    {
        private ProveedoresNegocio _serviciosProveedores;
        private ProductosNegocio _serviciosProductos;

        public FrmIngresarProductos(FrmProductos Owner)
        {
            this.Owner = Owner;
            _serviciosProveedores = new ProveedoresNegocio();
            _serviciosProductos = new ProductosNegocio();
            InitializeComponent();
        }
        private void FrmIngresarProductos_Load(object sender, EventArgs e)
        {
            _cboBoxCategoria.DataSource = null;
            _cboBoxCategoria.DataSource = Enum.GetValues(typeof(Categorias));
            _cboBoxCategoria.SelectedIndex = -1;

            _cboBoxProveedor.DataSource = null;
            _cboBoxProveedor.DataSource = _serviciosProveedores.TraerProveedores();
            _cboBoxProveedor.SelectedIndex = -1;
            _cboBoxProveedor.DisplayMember = "Nombre";
        }
        private void _btnLimpiar_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void _btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                double precio = Validadores.StringToDouble(_txtPrecio.Text);
                int stock = Validadores.StringToInt(_txtStock.Text);
                Validadores.IsNullOrEmpy(_txtNombre.Text);
                string nombre = _txtNombre.Text;
                Validadores.ValidarComboBox(_cboBoxCategoria, _lblCategoria);
                int idCategoria = (int)_cboBoxCategoria.SelectedItem;
                Validadores.ValidarComboBox(_cboBoxProveedor, _lblProveedor);
                int idProveedor = ((Proveedores)_cboBoxProveedor.SelectedItem).IdProveedor;
                _serviciosProductos.IngresarProducto(nombre, idCategoria, idProveedor, precio, stock);
                MessageBox.Show(String.Format($"Se ha ingresado el producto \"{nombre}\" correctamente."));
                Clean();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void Clean()
        {
            _txtNombre.Text = string.Empty;
            _txtPrecio.Text = string.Empty;
            _txtStock.Text = string.Empty;
            _cboBoxCategoria.SelectedIndex = -1;
            _cboBoxProveedor.SelectedIndex = -1;
        }

    }
}