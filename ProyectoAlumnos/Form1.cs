namespace ProyectoAlumnos
{
    public partial class Form1 : Form
    {
        RepositorioAlumnos repo = new RepositorioAlumnos();
        public Form1()
        {
            InitializeComponent();
        }

        public void refrescar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = repo.Listar();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.Nombre = textBox1.Text;
            alumno.Nota = int.Parse(textBox2.Text);

            string mensaje = repo.Agregar(alumno);
            MessageBox.Show(mensaje);
            refrescar();
        }
    }
}
