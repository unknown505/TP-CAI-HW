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
    public partial class FrmConsultarProveedores : Form
    {
        public FrmConsultarProveedores(FrmProveedores Owner)
        {
            this.Owner = Owner;
            InitializeComponent();
        }

        private void _btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void _btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void FrmConsultarProveedores_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
