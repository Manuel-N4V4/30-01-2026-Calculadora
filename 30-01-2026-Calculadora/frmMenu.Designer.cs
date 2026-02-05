namespace _30_01_2026_Calculadora
{
    partial class frmMenu
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
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            salidaToolStripMenuItem = new ToolStripMenuItem();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            calculadoraSimpleToolStripMenuItem = new ToolStripMenuItem();
            ordenamientoToolStripMenuItem = new ToolStripMenuItem();
            burbujaToolStripMenuItem = new ToolStripMenuItem();
            registrosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, opcionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(601, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salidaToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // salidaToolStripMenuItem
            // 
            salidaToolStripMenuItem.Name = "salidaToolStripMenuItem";
            salidaToolStripMenuItem.Size = new Size(133, 26);
            salidaToolStripMenuItem.Text = "Salida";
            salidaToolStripMenuItem.Click += salidaToolStripMenuItem_Click;
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { calculadoraSimpleToolStripMenuItem, ordenamientoToolStripMenuItem, registrosToolStripMenuItem });
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(107, 24);
            opcionesToolStripMenuItem.Text = "Aplicaciones";
            opcionesToolStripMenuItem.Click += opcionesToolStripMenuItem_Click;
            // 
            // calculadoraSimpleToolStripMenuItem
            // 
            calculadoraSimpleToolStripMenuItem.Name = "calculadoraSimpleToolStripMenuItem";
            calculadoraSimpleToolStripMenuItem.Size = new Size(224, 26);
            calculadoraSimpleToolStripMenuItem.Text = "Calculadora Simple";
            calculadoraSimpleToolStripMenuItem.Click += calculadoraSimpleToolStripMenuItem_Click;
            // 
            // ordenamientoToolStripMenuItem
            // 
            ordenamientoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { burbujaToolStripMenuItem });
            ordenamientoToolStripMenuItem.Name = "ordenamientoToolStripMenuItem";
            ordenamientoToolStripMenuItem.Size = new Size(224, 26);
            ordenamientoToolStripMenuItem.Text = "Ordenamiento";
            // 
            // burbujaToolStripMenuItem
            // 
            burbujaToolStripMenuItem.Name = "burbujaToolStripMenuItem";
            burbujaToolStripMenuItem.Size = new Size(143, 26);
            burbujaToolStripMenuItem.Text = "Burbuja";
            burbujaToolStripMenuItem.Click += burbujaToolStripMenuItem_Click_1;
            // 
            // registrosToolStripMenuItem
            // 
            registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            registrosToolStripMenuItem.Size = new Size(224, 26);
            registrosToolStripMenuItem.Text = "Registros";
            registrosToolStripMenuItem.Click += registrosToolStripMenuItem_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 194);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMenu";
            Text = "frmMenu";
            Load += frmMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem salidaToolStripMenuItem;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem calculadoraSimpleToolStripMenuItem;
        private ToolStripMenuItem ordenamientoToolStripMenuItem;
        private ToolStripMenuItem burbujaToolStripMenuItem;
        private ToolStripMenuItem registrosToolStripMenuItem;
    }
}