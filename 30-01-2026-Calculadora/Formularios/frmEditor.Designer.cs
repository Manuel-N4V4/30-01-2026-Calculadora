namespace _30_01_2026_Calculadora
{
    partial class frmEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mnsMenuStrip = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            cuardarToolStripMenuItem = new ToolStripMenuItem();
            guardarComoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            salirToolStripMenuItem = new ToolStripMenuItem();
            stsEditor = new StatusStrip();
            rtbEditor = new RichTextBox();
            ofpEditor = new OpenFileDialog();
            sfdEditor = new SaveFileDialog();
            mnsMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // mnsMenuStrip
            // 
            mnsMenuStrip.ImageScalingSize = new Size(20, 20);
            mnsMenuStrip.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            mnsMenuStrip.Location = new Point(0, 0);
            mnsMenuStrip.Name = "mnsMenuStrip";
            mnsMenuStrip.Size = new Size(552, 28);
            mnsMenuStrip.TabIndex = 0;
            mnsMenuStrip.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, abrirToolStripMenuItem, cuardarToolStripMenuItem, guardarComoToolStripMenuItem, toolStripSeparator1, salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(73, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(224, 26);
            nuevoToolStripMenuItem.Text = "Nuevo";
            nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(224, 26);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // cuardarToolStripMenuItem
            // 
            cuardarToolStripMenuItem.Name = "cuardarToolStripMenuItem";
            cuardarToolStripMenuItem.Size = new Size(224, 26);
            cuardarToolStripMenuItem.Text = "Cuardar";
            cuardarToolStripMenuItem.Click += cuardarToolStripMenuItem_Click;
            // 
            // guardarComoToolStripMenuItem
            // 
            guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            guardarComoToolStripMenuItem.Size = new Size(224, 26);
            guardarComoToolStripMenuItem.Text = "Guardar Como";
            guardarComoToolStripMenuItem.Click += guardarComoToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(221, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(224, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // stsEditor
            // 
            stsEditor.ImageScalingSize = new Size(20, 20);
            stsEditor.Location = new Point(0, 283);
            stsEditor.Name = "stsEditor";
            stsEditor.Size = new Size(552, 22);
            stsEditor.TabIndex = 1;
            stsEditor.Text = "statusStrip1";
            // 
            // rtbEditor
            // 
            rtbEditor.Location = new Point(0, 31);
            rtbEditor.Name = "rtbEditor";
            rtbEditor.Size = new Size(550, 239);
            rtbEditor.TabIndex = 2;
            rtbEditor.Text = "";
            // 
            // ofpEditor
            // 
            ofpEditor.Filter = "\"Archivo de texto\"|*.txt";
            // 
            // sfdEditor
            // 
            sfdEditor.Filter = "\"Archivo de texto\"|.txt";
            // 
            // frmEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 305);
            Controls.Add(rtbEditor);
            Controls.Add(stsEditor);
            Controls.Add(mnsMenuStrip);
            MainMenuStrip = mnsMenuStrip;
            Name = "frmEditor";
            Text = "Editor de Texto";
            mnsMenuStrip.ResumeLayout(false);
            mnsMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnsMenuStrip;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem cuardarToolStripMenuItem;
        private ToolStripMenuItem guardarComoToolStripMenuItem;
        private StatusStrip stsEditor;
        private RichTextBox rtbEditor;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private OpenFileDialog ofpEditor;
        private SaveFileDialog sfdEditor;
    }
}