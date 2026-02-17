using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _30_01_2026_Calculadora
{
    public partial class frmContador : Form
    {
        int contador = 0;
        public frmContador()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            tkbCapacidad.Enabled = true;
            tmrContador.Interval = tkbCapacidad.Value * 200;
            tmrContador.Enabled = true;
            tmrContador.Start();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            tmrContador.Enabled = false;
            tkbCapacidad.Enabled = false;
        }

        private void tmrContador_Tick(object sender, EventArgs e)
        {
            contador++;
            lblCuenta.Text = contador.ToString();
        }

        private void tkbCapacidad_Scroll(object sender, EventArgs e)
        {
            tmrContador.Interval = tkbCapacidad.Value + 200;
        }
    }
}
