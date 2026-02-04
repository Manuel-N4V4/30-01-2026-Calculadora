using _30_01_2026_Calculadora.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _30_01_2026_Calculadora
{
    public partial class frmBurbuja : Form
    {
        public frmBurbuja()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ordenamientos burbuja = new Ordenamientos();
            int[] ordenado = new int[gdvDesordenado.RowCount];

            for(int i=0;i<gdvDesordenado.RowCount-1;i++)
            {
                ordenado[i] = Convert.ToInt32(gdvDesordenado.Rows[i].Cells[0].Value);
            }
            burbuja.Burbuja(ordenado);

            gdvOrdenado.DataSource = ordenado;// DEFINE EL TAMAÑO DE LAS FILAS DEL DataGridView

            for(int i=0;i<ordenado.Length;i++)
            {
                gdvOrdenado.Rows[i].Cells[0].Value = ordenado[i];
            }
        }
    }
}

// int [] ordenado = new int[gdvDesordenado.RowCount];
