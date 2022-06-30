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

namespace TP_CAI_HW.Interfaz
{
    public partial class FrmConsultarProductos : Form
    {
        private ProductosNegocio _serviciosProducto;
        public FrmConsultarProductos(FrmProductos Owner)
        {
            this.Owner = Owner;
            _serviciosProducto = new ProductosNegocio();
            InitializeComponent();
        }

        private void _btnConsultar_Click(object sender, EventArgs e)
        {

        }
        private void _btnAtras_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }
        private void FrmConsultarProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }

        private void FrmConsultarProductos_Load(object sender, EventArgs e)
        {
            _cboBoxProducto.DataSource = null;
            _cboBoxProducto.DataSource = _serviciosProducto.TraerProductos();
            _cboBoxProducto.DisplayMember = "ProductoCompleto";
            _cboBoxProducto.SelectedIndex = -1;
        }
    }
}
