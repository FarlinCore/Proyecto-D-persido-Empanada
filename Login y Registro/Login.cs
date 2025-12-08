namespace Login_y_Registro
{
    public partial class Login : Form
    {
        public Login()
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

        }

        private void btningresar_Click(object sender, EventArgs e)
        {

        }

        private void btnregistrarse_Click(object sender, EventArgs e)
        {
            Registro f2 = new Registro();
            f2.Owner = this;
            f2.Show();
            this.Hide();
        }
    }
}
