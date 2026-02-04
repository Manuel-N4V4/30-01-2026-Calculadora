namespace _30_01_2026_Calculadora
{
    partial class frmBurbuja
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
            gdvDesordenado = new DataGridView();
            Desordenado = new DataGridViewTextBoxColumn();
            gdvOrdenado = new DataGridView();
            Ordenado = new DataGridViewTextBoxColumn();
            btnOrdenar = new Button();
            ((System.ComponentModel.ISupportInitialize)gdvDesordenado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gdvOrdenado).BeginInit();
            SuspendLayout();
            // 
            // gdvDesordenado
            // 
            gdvDesordenado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gdvDesordenado.Columns.AddRange(new DataGridViewColumn[] { Desordenado });
            gdvDesordenado.Location = new Point(12, 12);
            gdvDesordenado.Name = "gdvDesordenado";
            gdvDesordenado.RowHeadersWidth = 51;
            gdvDesordenado.Size = new Size(184, 264);
            gdvDesordenado.TabIndex = 0;
            // 
            // Desordenado
            // 
            Desordenado.HeaderText = "Desordenado";
            Desordenado.MinimumWidth = 6;
            Desordenado.Name = "Desordenado";
            Desordenado.Width = 125;
            // 
            // gdvOrdenado
            // 
            gdvOrdenado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gdvOrdenado.Columns.AddRange(new DataGridViewColumn[] { Ordenado });
            gdvOrdenado.Location = new Point(202, 12);
            gdvOrdenado.Name = "gdvOrdenado";
            gdvOrdenado.RowHeadersWidth = 51;
            gdvOrdenado.Size = new Size(182, 264);
            gdvOrdenado.TabIndex = 1;
            // 
            // Ordenado
            // 
            Ordenado.HeaderText = "Ordenado";
            Ordenado.MinimumWidth = 6;
            Ordenado.Name = "Ordenado";
            Ordenado.Width = 125;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(12, 282);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(372, 41);
            btnOrdenar.TabIndex = 2;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += button1_Click;
            // 
            // frmBurbuja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 331);
            Controls.Add(btnOrdenar);
            Controls.Add(gdvOrdenado);
            Controls.Add(gdvDesordenado);
            Name = "frmBurbuja";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)gdvDesordenado).EndInit();
            ((System.ComponentModel.ISupportInitialize)gdvOrdenado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gdvDesordenado;
        private DataGridViewTextBoxColumn Desordenado;
        private DataGridView gdvOrdenado;
        private DataGridViewTextBoxColumn Ordenado;
        private Button btnOrdenar;
    }
}