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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Clases.CapturaProveedor proveedor = new Clases.CapturaProveedor();
            proveedor.mostraProveedores(datosProveedor);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void bttAgregar_Click(object sender, EventArgs e)
        {
            Clases.CapturaProveedor proveedor = new Clases.CapturaProveedor();
            proveedor.Guardar_Proveedor(txtNombre,txtEmpresa,txtNumero_Proveedor);
            proveedor.mostraProveedores(datosProveedor);
        }

        private void picRegreso_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void bttModificar_Click(object sender, EventArgs e)
        {
            Clases.CapturaProveedor proveedor = new Clases.CapturaProveedor();
            proveedor.ActualizarProveedor(lbl_Id,txtNombre,txtEmpresa,txtNumero_Proveedor);
            proveedor.mostraProveedores(datosProveedor);
        }

        private void datosProveedor_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void datosProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Clases.CapturaProveedor proveedor = new Clases.CapturaProveedor();
                proveedor.Seleccionar_Proveedor(datosProveedor, lbl_Id, txtNombre, txtEmpresa, txtNumero_Proveedor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Clases.CapturaProveedor proveedor = new Clases.CapturaProveedor();
                proveedor.EliminarProveedor(lbl_Id);
                proveedor.mostraProveedores(datosProveedor);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error de eliminar", ex.Message);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void txtEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        

        private void txtNumero_Proveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

      
    }
}
