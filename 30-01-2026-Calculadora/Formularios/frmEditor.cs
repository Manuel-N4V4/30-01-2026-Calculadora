using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _30_01_2026_Calculadora
{
    public partial class frmEditor : Form
    {
        string texto;
        int contPalabras = 0;
        bool saved = false;
        string path = "";
        public frmEditor()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofpEditor.ShowDialog() == DialogResult.OK)
            {
                // ESTUDIAR STREMREADER DE C#
                if (File.Exists(ofpEditor.FileName))
                {
                    rtbEditor.Text = File.ReadAllText(ofpEditor.FileName);
                }
            }
        }

        private void cuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saved == false)
            {
                Guardar();
                saved = true;
            }
            else
            {
                using (StreamWriter archivo = new StreamWriter(path))
                {
                    archivo.Write(rtbEditor.Text);
                }
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void Guardar()
        {
            if (sfdEditor.ShowDialog() == DialogResult.OK)
            {
                path = sfdEditor.FileName;
                using (StreamWriter archivo = new StreamWriter(path))
                {
                    archivo.Write(rtbEditor.Text);
                }
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbEditor.Clear();
            saved = false;
            path = "";
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void rtbEditor_TextChanged(object sender, EventArgs e)
        {
            // asdsa
            texto = rtbEditor.Text;
            string[] palabras = texto.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            //tssStatu.Text = $"{palabras.Length} Palabras";
            tssStatu.Text = palabras.Length.ToString() + " Palabras";
        }

        private void tssStatu_Click(object sender, EventArgs e)
        {
            string[] parrafos = texto.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            MessageBox.Show("Estadisticas:\n\n Palabras: "
                + tssStatu.Text + "\n Contador de letras: "
                + texto.Length.ToString() + "\n Parrafos: "
                + parrafos.Length.ToString()
                + "\n \nContador de palabras");
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ftdEditor.ShowDialog() == DialogResult.OK)
            {
                rtbEditor.Font = ftdEditor.Font;
            }

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cldEditor.ShowDialog() == DialogResult.OK)
            {
                rtbEditor.ForeColor = cldEditor.Color;
            }
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnsMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmEditor_Load(object sender, EventArgs e)
        {

        }
    }
}
