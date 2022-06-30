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
    public partial class FrmConsultarProveedores : Form
    {
        private ProveedoresNegocio _serviciosProveedores;
        public FrmConsultarProveedores(FrmProveedores Owner)
        {
            this.Owner = Owner;
            _serviciosProveedores = new ProveedoresNegocio();
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
        private void FrmConsultarProveedores_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }

        private void FrmConsultarProveedores_Load(object sender, EventArgs e)
        {
            _cboBoxProveedor.DataSource = null;
            _cboBoxProveedor.DataSource = _serviciosProveedores.TraerProveedores();
            _cboBoxProveedor.DisplayMember = "ProveedorCompleto";
            _cboBoxProveedor.SelectedIndex = -1;
        }
    }
}
