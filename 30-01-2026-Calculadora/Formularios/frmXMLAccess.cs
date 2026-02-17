using System.Xml.Linq;

namespace _30_01_2026_Calculadora.Formularios
{
    public partial class frmXMLAccess : Form
    {

        public frmXMLAccess()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            XElement xml = new XElement("Personas");

            for (int i = 0; i < dgvPersonas.Rows.Count - 1; i++)
            {
                xml.Add(
                    new XElement("Persona",
                    new XAttribute("ID", dgvPersonas.Rows[i].Cells[0].Value),
                    new XElement("Nombre", dgvPersonas.Rows[i].Cells[1].Value),
                    new XElement("Telefono", dgvPersonas.Rows[i].Cells[2].Value)));
            }
            try
            {
                xml.Save("Archivo.xml");
                MessageBox.Show("Guardado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
