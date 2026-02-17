namespace _30_01_2026_Calculadora
{
    partial class frmContador
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
            lblCuenta = new Label();
            btnInicio = new Button();
            btnDetener = new Button();
            tkbCapacidad = new TrackBar();
            tmrContador = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)tkbCapacidad).BeginInit();
            SuspendLayout();
            // 
            // lblCuenta
            // 
            lblCuenta.AutoSize = true;
            lblCuenta.Font = new Font("Arial", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCuenta.Location = new Point(128, 23);
            lblCuenta.Name = "lblCuenta";
            lblCuenta.Size = new Size(49, 53);
            lblCuenta.TabIndex = 0;
            lblCuenta.Text = "0";
            // 
            // btnInicio
            // 
            btnInicio.Location = new Point(41, 141);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(94, 29);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnDetener
            // 
            btnDetener.Location = new Point(164, 141);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(94, 29);
            btnDetener.TabIndex = 2;
            btnDetener.Text = "Detener";
            btnDetener.UseVisualStyleBackColor = true;
            btnDetener.Click += btnDetener_Click;
            // 
            // tkbCapacidad
            // 
            tkbCapacidad.Enabled = false;
            tkbCapacidad.Location = new Point(12, 79);
            tkbCapacidad.Maximum = 5;
            tkbCapacidad.Minimum = 1;
            tkbCapacidad.Name = "tkbCapacidad";
            tkbCapacidad.Size = new Size(284, 56);
            tkbCapacidad.TabIndex = 3;
            tkbCapacidad.Value = 1;
            tkbCapacidad.Scroll += tkbCapacidad_Scroll;
            // 
            // tmrContador
            // 
            tmrContador.Interval = 1;
            tmrContador.Tick += tmrContador_Tick;
            // 
            // frmContador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 192);
            Controls.Add(tkbCapacidad);
            Controls.Add(btnDetener);
            Controls.Add(btnInicio);
            Controls.Add(lblCuenta);
            Name = "frmContador";
            Text = "Contador";
            ((System.ComponentModel.ISupportInitialize)tkbCapacidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCuenta;
        private Button btnInicio;
        private Button btnDetener;
        private TrackBar tkbCapacidad;
        private System.Windows.Forms.Timer tmrContador;
    }
}