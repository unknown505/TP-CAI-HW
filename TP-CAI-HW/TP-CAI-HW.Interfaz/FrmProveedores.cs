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
    public partial class FrmProveedores : Form
    {
        private FrmIngresarProveedores _frmIngresarProveedores;
        private FrmConsultarProveedores _frmConsultarProveedores;
        public FrmProveedores(FrmPrincipal Owner)
        {
            _frmIngresarProveedores = new FrmIngresarProveedores(this);
            _frmConsultarProveedores = new FrmConsultarProveedores(this);
            this.Owner = Owner;
            InitializeComponent();
        }

        private void _btnIngresarProveedor_Click(object sender, EventArgs e)
        {
            _frmIngresarProveedores.Show();
            this.Hide();
        }

        private void _btnConsultarProveedor_Click(object sender, EventArgs e)
        {
            _frmConsultarProveedores.Show();
            this.Hide();
        }

        private void _btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void FrmProveedores_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
