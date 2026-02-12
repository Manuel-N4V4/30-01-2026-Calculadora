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
        bool saved = false;
        string path = "";
        public frmEditor()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ofpEditor.ShowDialog() == DialogResult.OK)
            {
                // ESTUDIAR STREMREADER DE C#
                if(File.Exists(ofpEditor.FileName))
                {
                    rtbEditor.Text = File.ReadAllText(ofpEditor.FileName);
                }
            }
        }

        private void cuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saved == false)
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
        
    }
}
