namespace _30_01_2026_Calculadora
{
    partial class frmTemporizadores
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
            components = new System.ComponentModel.Container();
            lblHora = new Label();
            tmrHora = new System.Windows.Forms.Timer(components);
            mnsAlarma = new MenuStrip();
            establecerToolStripMenuItem = new ToolStripMenuItem();
            alarma1ToolStripMenuItem = new ToolStripMenuItem();
            btnDetener = new Button();
            establecerToolStripMenuItem1 = new ToolStripMenuItem();
            mnsAlarma.SuspendLayout();
            SuspendLayout();
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHora.Location = new Point(12, 55);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(338, 67);
            lblHora.TabIndex = 0;
            lblHora.Text = "00:00:00 xx";
            lblHora.Click += lblHora_Click;
            // 
            // tmrHora
            // 
            tmrHora.Enabled = true;
            tmrHora.Interval = 1000;
            tmrHora.Tick += tmrHora_Tick;
            // 
            // mnsAlarma
            // 
            mnsAlarma.ImageScalingSize = new Size(20, 20);
            mnsAlarma.Items.AddRange(new ToolStripItem[] { establecerToolStripMenuItem });
            mnsAlarma.Location = new Point(0, 0);
            mnsAlarma.Name = "mnsAlarma";
            mnsAlarma.Size = new Size(432, 28);
            mnsAlarma.TabIndex = 1;
            mnsAlarma.Text = "menuStrip1";
            // 
            // establecerToolStripMenuItem
            // 
            establecerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alarma1ToolStripMenuItem, establecerToolStripMenuItem1 });
            establecerToolStripMenuItem.Name = "establecerToolStripMenuItem";
            establecerToolStripMenuItem.Size = new Size(91, 24);
            establecerToolStripMenuItem.Text = "Establecer";
            // 
            // alarma1ToolStripMenuItem
            // 
            alarma1ToolStripMenuItem.Name = "alarma1ToolStripMenuItem";
            alarma1ToolStripMenuItem.Size = new Size(152, 26);
            alarma1ToolStripMenuItem.Text = "Alarma 1";
            alarma1ToolStripMenuItem.Click += alarma1ToolStripMenuItem_Click;
            // 
            // btnDetener
            // 
            btnDetener.Location = new Point(280, 152);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(140, 32);
            btnDetener.TabIndex = 2;
            btnDetener.Text = "Detener";
            btnDetener.UseVisualStyleBackColor = true;
            btnDetener.Click += btnDetener_Click;
            // 
            // establecerToolStripMenuItem1
            // 
            establecerToolStripMenuItem1.Name = "establecerToolStripMenuItem1";
            establecerToolStripMenuItem1.Size = new Size(224, 26);
            establecerToolStripMenuItem1.Text = "Establecer";
            establecerToolStripMenuItem1.Click += establecerToolStripMenuItem1_Click;
            // 
            // frmTemporizadores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 196);
            Controls.Add(btnDetener);
            Controls.Add(lblHora);
            Controls.Add(mnsAlarma);
            MainMenuStrip = mnsAlarma;
            Name = "frmTemporizadores";
            Text = "Reloj";
            Load += frmTemporizadores_Load;
            mnsAlarma.ResumeLayout(false);
            mnsAlarma.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHora;
        private System.Windows.Forms.Timer tmrHora;
        private MenuStrip mnsAlarma;
        private ToolStripMenuItem establecerToolStripMenuItem;
        private ToolStripMenuItem alarma1ToolStripMenuItem;
        private Button btnDetener;
        private ToolStripMenuItem establecerToolStripMenuItem1;
    }
}