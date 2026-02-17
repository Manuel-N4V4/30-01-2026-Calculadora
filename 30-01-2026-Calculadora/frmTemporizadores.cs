using CSCore.SoundOut;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _30_01_2026_Calculadora
{
    public partial class frmTemporizadores : Form
    {
        string alarma1 = null;

        //SoundPlayer sp = new SoundPlayer(@"C:\Users\jmanu\source\repos\30-01-2026-Calculadora\30-01-2026-Calculadora\Sonidos\5-Years-Time.wav");
        SoundPlayer sp = new SoundPlayer(@"C:\Users\jmanu\source\repos\30-01-2026-Calculadora\30-01-2026-Calculadora\Sonidos\Regular-Show-Gary-vs-David-BEST-Clean-Extended-Mix.wav");
        public frmTemporizadores()
        {
            InitializeComponent();
        }
        private void tmrHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            if (lblHora.Text == alarma1)
            {
                sp.Play();
            }
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void alarma1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alarma1 = Interaction.InputBox("¿A que hora sonara la ALARMA?", "Sistema", "XX:XX:XX x.x.");
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            sp.Stop();
        }

        private void frmTemporizadores_Load(object sender, EventArgs e)
        {

        }

        private void establecerToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
