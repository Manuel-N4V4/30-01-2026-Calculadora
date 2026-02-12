namespace _30_01_2026_Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 0, b = 0, resultado = 0;
                a = Convert.ToInt32(txtVariableA.Text);
                b = int.Parse(txtVariableB.Text);

                if (rdbSuma.Checked)
                {
                    resultado = a + b;
                }
                if (rdbResta.Checked)
                {
                    resultado = a - b;
                }
                if (rdbMultiplicacion.Checked)
                {
                    resultado = a * b;
                }
                if (rdbDivision.Checked)
                {
                    resultado = a / b;
                }

                MessageBox.Show("El resultado es: " + resultado.ToString(), "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR en la conversion de los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            txtVariableA.Clear();
            txtVariableB.Text = "";
        }

        private void rdbSuma_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
