using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms; 
namespace Login_y_Registro.Data
{
    public static class ConexionDB // la creamos static para no necesitar objetos para los metodos
    {
        // aqui pondremos la cadena de conexion
        private static string Cadena_conexion = "Data Source=SR_TECH\\SQLEXPRESS;Initial Catalog=dbase_sist_persido;Integrated Security=True;Trust Server Certificate=True";
        //metodo para abrir la conexion 
        public static SqlConnection GetConexion()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Cadena_conexion);
                conexion.Open();
                MessageBox.Show("Conectado con exito");
                return conexion;
            }
            catch (Exception  ex)
            {
                MessageBox.Show("Error al conectar a la base de datos :" + ex.Message);
                return null;
            }
        }
    }
}
