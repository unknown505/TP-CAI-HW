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
using TP_CAI_HW.Entidades.Dominio;

namespace TP_CAI_HW.Interfaz
{
    public partial class FrmConsultarClientes : Form
    {
        private ClientesNegocio _serviciosCliente;

        public object IdCliente { get; private set; }
        public object Nombre { get; private set; }

        public FrmConsultarClientes(FrmClientes Owner)
        {
            this.Owner = Owner;
            _serviciosCliente = new ClientesNegocio();
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
        private void FrmConsultarClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }

        private void FrmConsultarClientes_Load(object sender, EventArgs e)
        {
            _cboBoxCliente.DataSource = null;
            _cboBoxCliente.DataSource = _serviciosCliente.TraerClientes();
            _cboBoxCliente.DisplayMember = "ClienteCompleto";
            _cboBoxCliente.SelectedIndex = -1;


          
        }
    }
}
