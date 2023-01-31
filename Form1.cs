using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaCedis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Clases.GuardarCapturasDatos procesos = new Clases.GuardarCapturasDatos();
            procesos.mostraDatos(DataDatos);
            procesos.seleccion(combo_Nro);


        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) && (!char.IsNumber(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtNroProvee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void bttAgregar_Click(object sender, EventArgs e)
        {
            Clases.GuardarCapturasDatos procesosDatos = new Clases.GuardarCapturasDatos();
            procesosDatos.Guardar_Datos(txtCodigo, txtDescripcion, combo_Nro, CheckLista);
            limpiar();
            procesosDatos.mostraDatos(DataDatos);

        }

        private void DataDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Clases.GuardarCapturasDatos procesosDatos = new Clases.GuardarCapturasDatos();
                procesosDatos.SeleccionarDatos(DataDatos, txtId, txtCodigo, txtDescripcion, combo_Nro, CheckLista);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void limpiar() 
        {
            txtId.Text = "";
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            combo_Nro.Text = "";
            CheckLista.Text = "";

        }

        private void bttModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Clases.GuardarCapturasDatos procesosDatos = new Clases.GuardarCapturasDatos();
                procesosDatos.Actualizar(txtId,txtCodigo,txtDescripcion,combo_Nro,CheckLista);
                limpiar();
                procesosDatos.mostraDatos(DataDatos);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error", ex.Message);
            }
        }

        private void bttEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Clases.GuardarCapturasDatos guardarCapturasDatos = new Clases.GuardarCapturasDatos();
                guardarCapturasDatos.Eliminar(txtId);
                guardarCapturasDatos.mostraDatos(DataDatos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PicCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
