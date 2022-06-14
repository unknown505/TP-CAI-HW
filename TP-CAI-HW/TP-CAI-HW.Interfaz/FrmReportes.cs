﻿using System;
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
    public partial class FrmReportes : Form
    {
        public FrmReportes(FrmPrincipal Owner)
        {
            this.Owner = Owner;
            InitializeComponent();
        }

        private void FrmReportes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void _btnReporteVentasCliente_Click(object sender, EventArgs e)
        {

        }

        private void _btnReporteProductoProveedor_Click(object sender, EventArgs e)
        {

        }

        private void _btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
    }
}
