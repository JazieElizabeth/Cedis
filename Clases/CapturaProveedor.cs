using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaCedis.Clases
{
    class CapturaProveedor
    {
        public void mostraProveedores(DataGridView tablaDatos)
        {
            try
            {
                Conexion conectar = new Conexion();
                string query = "CALL cedis.Seleccionar_Proveedor()";
                tablaDatos.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conectar.EstablecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaDatos.DataSource = dt;
                conectar.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("error" + e.ToString());
            }

        }

        public void Guardar_Proveedor(TextBox Nombre, TextBox Empresa, TextBox Numero_Provee)
        {
            try
            {
                Conexion conectar = new Conexion();
                String query = "CALL cedis.Guardar_Proveedor('" + Nombre.Text + "','" + Empresa.Text + "','" + Numero_Provee.Text + "');";
                MySqlCommand comando = new MySqlCommand(query, conectar.EstablecerConexion());
                MySqlDataReader reader = comando.ExecuteReader();
              
                while (reader.Read())
                {
                }
                conectar.CerrarConexion();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }

        }

        public void Seleccionar_Proveedor(DataGridView tablaDatos, Label Id, TextBox Nombre, TextBox Empresa, TextBox Numero_Provee)
        {
            try
            {
                Id.Text = tablaDatos.CurrentRow.Cells[0].Value.ToString();
                Nombre.Text = tablaDatos.CurrentRow.Cells[1].Value.ToString();
                Empresa.Text = tablaDatos.CurrentRow.Cells[2].Value.ToString();
                Numero_Provee.Text = tablaDatos.CurrentRow.Cells[3].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }

        }

        public void ActualizarProveedor(Label Id, TextBox Nombre, TextBox Empresa, TextBox Numero_Provee)
        {
            try
            {
                Conexion conectar = new Conexion();
                String query = "CALL cedis.Actualizar_Proveedor('" + Id.Text + "','" + Nombre.Text + "','" + Empresa.Text + "','" + Numero_Provee.Text + "');";
                MySqlCommand comando = new MySqlCommand(query, conectar.EstablecerConexion());
                MySqlDataReader reader = comando.ExecuteReader();
                MessageBox.Show("Modificado");
                while (reader.Read())
                {

                }
                conectar.CerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }

        }

        public void EliminarProveedor(Label Id_E)
        {
            try
            {
                Conexion conectar = new Conexion();
                String query = "CALL cedis.Eliminar_Proveedor('" + Id_E.Text + "');";
                MySqlCommand comando = new MySqlCommand(query, conectar.EstablecerConexion());
                MySqlDataReader reader = comando.ExecuteReader();
                MessageBox.Show("Eliminado");
                while (reader.Read())
                {

                }
                conectar.CerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }

        }
        public void seleccion(ComboBox comboN)
        {
            try
            {
                comboN.Text = "Nros Proveedores";
                comboN.Items.Clear();
                Conexion conectar = new Conexion();
                MySqlCommand comando = new MySqlCommand("Seleccionar_Proveedor()", conectar.EstablecerConexion());
                MySqlDataReader alm = comando.ExecuteReader();
                while (alm.Read())
                {
                    comboN.Refresh();
                    comboN.Items.Add(alm.GetValue(3).ToString());

                }

            }
            catch (Exception e)
            {
                MessageBox.Show("error" + e.ToString());
            }
        }
    }
}
