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

namespace TP_CAI_HW.Interfaz
{
    public partial class FrmIngresarProveedores : Form
    {
        private ProveedoresNegocio _serviciosProveedores;
        private ProductosNegocio _serviciosProductos;
        public FrmIngresarProveedores(FrmProveedores Owner)
        {
            this.Owner = Owner;
            _serviciosProveedores = new ProveedoresNegocio();
            _serviciosProductos = new ProductosNegocio();
            InitializeComponent();
        }

        private void _btnLimpiar_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void _btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                Validadores.IsNullOrEmpy(_txtNombre.Text);
                string nombre = _txtNombre.Text;
                Validadores.IsNullOrEmpy(_txtApellido.Text);
                string apellido = _txtApellido.Text;
                Validadores.IsNullOrEmpy(_txtMail.Text);
                string mail = _txtMail.Text;
                Validadores.IsNullOrEmpy(_txtCuit.Text);
                string cuit = _txtCuit.Text;
                int producto = ((Productos)_cboBoxProducto.SelectedItem).IdProducto;
                MessageBox.Show(producto.ToString());
                _serviciosProveedores.IngresarProveedor(nombre, apellido, mail, cuit, producto);
                MessageBox.Show(String.Format($"Se ha ingresado el proveedor \"{nombre}, {apellido} \" correctamente."));
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

        private void FrmIngresarProveedores_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }

        private void Clean()
        {
            _txtNombre.Text = string.Empty;
            _txtApellido.Text = string.Empty;
            _txtCuit.Text = string.Empty;
            _txtMail.Text = string.Empty;
            _cboBoxProducto.SelectedIndex = -1;
        }

        private void FrmIngresarProveedores_Load(object sender, EventArgs e)
        {
            _cboBoxProducto.DataSource = null;
            _cboBoxProducto.DataSource = _serviciosProductos.TraerProductos();
            _cboBoxProducto.SelectedIndex = -1;
            _cboBoxProducto.DisplayMember = "Nombre";

        }
    }
}
