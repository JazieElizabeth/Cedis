using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace PracticaCedis.Clases
{
    class GuardarCapturasDatos
    {
        public void mostraDatos(DataGridView tablaDatos)
        {
            try
            {
                Conexion conectar = new Conexion();
                string query = " CALL cedis.Seleccionar()";
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

        public void Guardar_Datos(TextBox Codigo, TextBox Descripcion, ComboBox Numero_Proveedor, CheckedListBox Status)
        {
            try
            {
                Conexion conectar = new Conexion();
                String query = "CALL cedis.Guardar('" + Codigo.Text + "','" + Descripcion.Text + "','" + Numero_Proveedor.Text + "','" + Status.Text + "');";
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

        public void SeleccionarDatos(DataGridView tablaDatos, TextBox Id, TextBox Codigo, TextBox Descripcion, ComboBox Numero_Proveedor, CheckedListBox status)
        {
            try
            {
                Id.Text = tablaDatos.CurrentRow.Cells[0].Value.ToString();
                Codigo.Text = tablaDatos.CurrentRow.Cells[1].Value.ToString();
                Descripcion.Text = tablaDatos.CurrentRow.Cells[2].Value.ToString();
                Numero_Proveedor.Text = tablaDatos.CurrentRow.Cells[3].Value.ToString();
                status.Text = tablaDatos.CurrentRow.Cells[4].Value.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }

        }

        public void Actualizar(TextBox Id, TextBox Codigo, TextBox Descripcion, ComboBox Numero_Proveedor, CheckedListBox status)
        {
            try
            {
                Conexion conectar = new Conexion();
                String query = "CALL cedis.Modificar('" + Id.Text + "','" + Codigo.Text + "','" + Descripcion.Text + "','" + Numero_Proveedor.Text + "','" + status.Text + "');";
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

        public void Eliminar(TextBox Id_P)
        {
            try
            {
                Conexion conectar = new Conexion();
                String query = "CALL cedis.Eliminar('" + Id_P.Text + "');";
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
        public void seleccion(ComboBox comboN) 
        {
            try
            {
                comboN.Items.Clear();
                Conexion conectar = new Conexion();
                MySqlCommand comando = new MySqlCommand("Seleccionar_Proveedor()",conectar.EstablecerConexion());
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
