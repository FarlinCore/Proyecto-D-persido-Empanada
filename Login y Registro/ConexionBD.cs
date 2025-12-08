using System;
using System.Data;
using System.Data.SqlClient;

namespace Login_y_Registro 
{
    public class ConexionBD
    {

        private string cadenaConexion = "Data Source=DESKTOP-B2FIVUA;Initial Catalog=bd_de_persido_empanada;Integrated Security=True";

        public SqlConnection conexion;

        public ConexionBD()
        {
            conexion = new SqlConnection(cadenaConexion);
        }

        // Función para ABRIR conexión
        public SqlConnection AbrirConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }
                return conexion;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al abrir la BD: " + ex.Message);
            }
        }

        // Función para CERRAR conexión
        public SqlConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
            return conexion;
        }
    }
}