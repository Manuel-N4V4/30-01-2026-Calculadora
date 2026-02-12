namespace _30_01_2026_Calculadora
{
    partial class frmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtVariableA = new TextBox();
            txtVariableB = new TextBox();
            btnCalcular = new Button();
            btnReset = new Button();
            groupBox1 = new GroupBox();
            rdbDivision = new RadioButton();
            rdbMultiplicacion = new RadioButton();
            rdbResta = new RadioButton();
            rdbSuma = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtVariableA
            // 
            txtVariableA.Location = new Point(14, 19);
            txtVariableA.Name = "txtVariableA";
            txtVariableA.Size = new Size(125, 27);
            txtVariableA.TabIndex = 0;
            txtVariableA.TextChanged += textBox1_TextChanged;
            // 
            // txtVariableB
            // 
            txtVariableB.Location = new Point(16, 63);
            txtVariableB.Name = "txtVariableB";
            txtVariableB.Size = new Size(125, 27);
            txtVariableB.TabIndex = 1;
            txtVariableB.TextChanged += textBox2_TextChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(295, 19);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += button1_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(297, 65);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 3;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbDivision);
            groupBox1.Controls.Add(rdbMultiplicacion);
            groupBox1.Controls.Add(rdbResta);
            groupBox1.Controls.Add(rdbSuma);
            groupBox1.Location = new Point(155, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(134, 155);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operaciones";
            // 
            // rdbDivision
            // 
            rdbDivision.AutoSize = true;
            rdbDivision.Location = new Point(7, 115);
            rdbDivision.Name = "rdbDivision";
            rdbDivision.Size = new Size(83, 24);
            rdbDivision.TabIndex = 3;
            rdbDivision.TabStop = true;
            rdbDivision.Text = "Division";
            rdbDivision.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicacion
            // 
            rdbMultiplicacion.AutoSize = true;
            rdbMultiplicacion.Location = new Point(7, 85);
            rdbMultiplicacion.Name = "rdbMultiplicacion";
            rdbMultiplicacion.Size = new Size(124, 24);
            rdbMultiplicacion.TabIndex = 2;
            rdbMultiplicacion.TabStop = true;
            rdbMultiplicacion.Text = "Multiplicacion";
            rdbMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // rdbResta
            // 
            rdbResta.AutoSize = true;
            rdbResta.Location = new Point(6, 55);
            rdbResta.Name = "rdbResta";
            rdbResta.Size = new Size(66, 24);
            rdbResta.TabIndex = 1;
            rdbResta.TabStop = true;
            rdbResta.Text = "Resta";
            rdbResta.UseVisualStyleBackColor = true;
            // 
            // rdbSuma
            // 
            rdbSuma.AutoSize = true;
            rdbSuma.Location = new Point(7, 25);
            rdbSuma.Name = "rdbSuma";
            rdbSuma.Size = new Size(67, 24);
            rdbSuma.TabIndex = 0;
            rdbSuma.TabStop = true;
            rdbSuma.Text = "Suma";
            rdbSuma.UseVisualStyleBackColor = true;
            rdbSuma.CheckedChanged += rdbSuma_CheckedChanged;
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 179);
            Controls.Add(groupBox1);
            Controls.Add(btnReset);
            Controls.Add(btnCalcular);
            Controls.Add(txtVariableB);
            Controls.Add(txtVariableA);
            Name = "frmCalculadora";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtVariableA;
        private TextBox txtVariableB;
        private Button btnCalcular;
        private Button btnReset;
        private GroupBox groupBox1;
        private RadioButton rdbDivision;
        private RadioButton rdbMultiplicacion;
        private RadioButton rdbResta;
        private RadioButton rdbSuma;
    }
}
