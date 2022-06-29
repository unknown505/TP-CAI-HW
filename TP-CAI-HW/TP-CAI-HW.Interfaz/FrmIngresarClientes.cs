using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_CAI_HW.Entidades;
using TP_CAI_HW.Negocio;

namespace TP_CAI_HW.Interfaz
{
    public partial class FrmIngresarClientes : Form
    {
        private ClientesNegocio _serviciosClientes;

        public FrmIngresarClientes(FrmClientes Owner)
        {
            this.Owner = Owner;
            _serviciosClientes = new ClientesNegocio();
            InitializeComponent();
        }

        private void FrmIngresarClientes_Load(object sender, EventArgs e)
        {

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
                Validadores.IsNullOrEmpy(_txtDireccion.Text);
                string direccion = _txtDireccion.Text;
                Validadores.IsNullOrEmpy(_txtTelefono.Text);
                string telefono = _txtTelefono.Text;
                Validadores.IsNullOrEmpy(_txtMail.Text);
                string mail = _txtMail.Text;
                int dni = Validadores.StringToInt(_txtDNI.Text);
                Validadores.MayoriaDeEdad(_dateTimePickerFechaNacimiento.Value);
                DateTime fechaNacimiento = _dateTimePickerFechaNacimiento.Value;
                _serviciosClientes.IngresarCliente(nombre, apellido, direccion, telefono, mail, dni, fechaNacimiento);
                MessageBox.Show(String.Format($"Se ha ingresado el cliente \"{nombre}, {apellido} \" correctamente."));
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

        private void FrmIngresarClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }

        private void Clean()
        {
            _txtNombre.Text = string.Empty;
            _txtApellido.Text = string.Empty;
            _txtDireccion.Text = string.Empty;
            _txtMail.Text = string.Empty;
            _txtDNI.Text = string.Empty;
            _txtTelefono.Text = string.Empty;
            _dateTimePickerFechaNacimiento.Value = DateTime.Now;
        }

    }
}
