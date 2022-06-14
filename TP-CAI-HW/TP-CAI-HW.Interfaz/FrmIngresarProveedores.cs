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
    public partial class FrmIngresarProveedores : Form
    {
        public FrmIngresarProveedores(FrmProveedores Owner)
        {
            this.Owner = Owner;
            InitializeComponent();
        }

        private void _btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void _btnIngresar_Click(object sender, EventArgs e)
        {

        }

        private void _btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void FrmIngresarProveedores_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
