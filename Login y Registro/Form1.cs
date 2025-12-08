namespace Login_y_Registro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // PRUEBA DE CONEXIÓN (Borrar después)
            ConexionBD test = new ConexionBD();

            try
            {
                test.AbrirConexion();
                MessageBox.Show("CONEXIÓN EXITOSA CON SQL SERVER!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                test.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
            }
        }

        private void btningresar_Click(object sender, EventArgs e)
        {

        }

        private void btnregistrarse_Click(object sender, EventArgs e)
        {

        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}