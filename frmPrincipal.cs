using Vista;

namespace Parcial2_YacopinoSofia
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnGestionClientes_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmClientes formClientes = new frmClientes();

            formClientes.ShowDialog();

            this.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}




