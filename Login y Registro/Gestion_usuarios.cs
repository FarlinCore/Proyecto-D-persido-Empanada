using Login_y_Registro.Data;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_y_Registro
{
    public partial class Gestion_usuarios : Form
    {
        public Gestion_usuarios()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Gestion_usuarios_Load(object sender, EventArgs e)
        {
            Mostrar_Datos();
        }

        private void Mostrar_Datos()
        {
            using (SqlConnection con = ConexionDB.GetConexion())
            {
                if (con != null)
                {
                    try
                    {
                        string sql = "SELECT * FROM usuarios";

                        SqlDataAdapter Da = new SqlDataAdapter(sql, con);

                        DataTable Dt = new DataTable();

                        Da.Fill(Dt);
                        dataGridDb.DataSource = Dt;
                    }

                    catch (Exception ex) 
                    {
                        MessageBox.Show("Error al cargar la base de datos :" + ex.Message);
                       
                    }

                }
            }

        }
    }
}
