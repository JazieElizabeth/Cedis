using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PracticaCedis.Clases
{
    class Conexion
    {
        MySqlConnection conexion = new MySqlConnection();



        string CadenaConexion = "Server=localhost;Port=3306;Database=cedis;Uid=root;password=;";

        public MySqlConnection EstablecerConexion()
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                // MessageBox.Show("Conectado");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            return conexion;
        }

        public void CerrarConexion()
        {
            conexion.Close();
        }

    }
}
