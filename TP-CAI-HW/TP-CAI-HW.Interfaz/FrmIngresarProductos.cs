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
    public partial class FrmIngresarProductos : Form
    {
        public FrmIngresarProductos(FrmProductos Owner)
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


    }
}
