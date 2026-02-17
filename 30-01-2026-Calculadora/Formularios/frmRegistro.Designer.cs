namespace _30_01_2026_Calculadora.Formularios
{
    partial class frmRegistro
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dtpFecha = new DateTimePicker();
            button1 = new Button();
            label1 = new Label();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            Nombre = new Label();
            tabPage2 = new TabPage();
            splitContainer1 = new SplitContainer();
            dgvPersonas = new DataGridView();
            btnEliminar = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(11, 20);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(403, 316);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            tabControl1.TabIndexChanged += tabControl1_TabIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dtpFecha);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtApellido);
            tabPage1.Controls.Add(txtNombre);
            tabPage1.Controls.Add(Nombre);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(395, 283);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(17, 144);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(272, 27);
            dtpFecha.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(295, 144);
            button1.Name = "button1";
            button1.Size = new Size(80, 29);
            button1.TabIndex = 4;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 71);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 3;
            label1.Text = "Apellidos";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(17, 92);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(358, 27);
            txtApellido.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(17, 39);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(358, 27);
            txtNombre.TabIndex = 1;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(17, 18);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(64, 20);
            Nombre.TabIndex = 0;
            Nombre.Text = "Nombre";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(splitContainer1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(395, 283);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mostrar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(6, 6);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvPersonas);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnEliminar);
            splitContainer1.Size = new Size(383, 271);
            splitContainer1.SplitterDistance = 208;
            splitContainer1.TabIndex = 1;
            // 
            // dgvPersonas
            // 
            dgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonas.Location = new Point(-28, -92);
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.RowHeadersWidth = 51;
            dgvPersonas.Size = new Size(457, 417);
            dgvPersonas.TabIndex = 0;
            dgvPersonas.CellContentClick += dgvPersonas_CellContentClick;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(136, 13);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 31);
            btnEliminar.TabIndex = 0;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 348);
            Controls.Add(tabControl1);
            Name = "frmRegistro";
            Text = "Registro Alumnos";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DateTimePicker dtpFecha;
        private Button button1;
        private Label label1;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label Nombre;
        private SplitContainer splitContainer1;
        private DataGridView dgvPersonas;
        private Button btnEliminar;
    }
}