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
            editarToolStripMenuItem = new ToolStripMenuItem();
            fuenteToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            stsEditor = new StatusStrip();
            tssStatus = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            tssStatu = new ToolStripStatusLabel();
            ofpEditor = new OpenFileDialog();
            sfdEditor = new SaveFileDialog();
            ftdEditor = new FontDialog();
            colorDialog1 = new ColorDialog();
            cldEditor = new ColorDialog();
            rtbEditor = new RichTextBox();
            mnsMenuStrip.SuspendLayout();
            stsEditor.SuspendLayout();
            SuspendLayout();
            // 
            // mnsMenuStrip
            // 
            mnsMenuStrip.ImageScalingSize = new Size(20, 20);
            mnsMenuStrip.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, editarToolStripMenuItem });
            mnsMenuStrip.Location = new Point(0, 0);
            mnsMenuStrip.Name = "mnsMenuStrip";
            mnsMenuStrip.Size = new Size(552, 28);
            mnsMenuStrip.TabIndex = 0;
            mnsMenuStrip.Text = "menuStrip1";
            mnsMenuStrip.ItemClicked += mnsMenuStrip_ItemClicked;
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, abrirToolStripMenuItem, cuardarToolStripMenuItem, guardarComoToolStripMenuItem, toolStripSeparator1, salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(73, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            archivoToolStripMenuItem.Click += archivoToolStripMenuItem_Click;
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
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fuenteToolStripMenuItem, colorToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(62, 24);
            editarToolStripMenuItem.Text = "Editar";
            editarToolStripMenuItem.Click += editarToolStripMenuItem_Click;
            // 
            // fuenteToolStripMenuItem
            // 
            fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            fuenteToolStripMenuItem.Size = new Size(136, 26);
            fuenteToolStripMenuItem.Text = "Fuente";
            fuenteToolStripMenuItem.Click += fuenteToolStripMenuItem_Click;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(136, 26);
            colorToolStripMenuItem.Text = "Color";
            colorToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // stsEditor
            // 
            stsEditor.ImageScalingSize = new Size(20, 20);
            stsEditor.Items.AddRange(new ToolStripItem[] { tssStatus, toolStripStatusLabel1, tssStatu });
            stsEditor.Location = new Point(0, 279);
            stsEditor.Name = "stsEditor";
            stsEditor.Size = new Size(552, 26);
            stsEditor.TabIndex = 1;
            stsEditor.Text = "statusStrip1";
            // 
            // tssStatus
            // 
            tssStatus.Name = "tssStatus";
            tssStatus.Size = new Size(0, 20);
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 20);
            toolStripStatusLabel1.Click += toolStripStatusLabel1_Click;
            // 
            // tssStatu
            // 
            tssStatu.Name = "tssStatu";
            tssStatu.Size = new Size(78, 20);
            tssStatu.Text = "0 palabras";
            tssStatu.Click += tssStatu_Click;
            // 
            // ofpEditor
            // 
            ofpEditor.Filter = "\"Archivo de texto\"|*.txt";
            // 
            // sfdEditor
            // 
            sfdEditor.Filter = "\"Archivo de texto\"|.txt";
            // 
            // ftdEditor
            // 
            ftdEditor.Apply += fontDialog1_Apply;
            // 
            // rtbEditor
            // 
            rtbEditor.Location = new Point(9, 33);
            rtbEditor.Name = "rtbEditor";
            rtbEditor.Size = new Size(531, 243);
            rtbEditor.TabIndex = 2;
            rtbEditor.Text = "";
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
            stsEditor.ResumeLayout(false);
            stsEditor.PerformLayout();
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
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private OpenFileDialog ofpEditor;
        private SaveFileDialog sfdEditor;
        private ToolStripStatusLabel tssStatus;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel tssStatu;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem fuenteToolStripMenuItem;
        private FontDialog ftdEditor;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ColorDialog colorDialog1;
        private ColorDialog cldEditor;
        private RichTextBox rtbEditor;
    }
}