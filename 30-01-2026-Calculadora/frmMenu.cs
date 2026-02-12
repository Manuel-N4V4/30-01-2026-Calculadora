using _30_01_2026_Calculadora.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _30_01_2026_Calculadora
{
    public partial class frmMenu : Form
    {
        frmRegistro registro = new frmRegistro();
        frmTemporizadores reloj = new frmTemporizadores();
        frmBurbuja burbuja = new frmBurbuja();
        frmCalculadora calculadora = new frmCalculadora();

        public frmMenu()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void burbujaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void calculadoraSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calculadora.Show();
        }

        private void burbujaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            burbuja.Show();
        }

        private void salidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliendo...", "SALIR");
            this.Close();
        }

        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registro.Show();
        }

        private void temporizadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reloj.Show();
        }

        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditor editor = new frmEditor();
            editor.Show();
        }
    }
}
