
namespace PracticaCedis
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtNumero_Proveedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bttAgregar = new System.Windows.Forms.Button();
            this.bttModificar = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.datosProveedor = new System.Windows.Forms.DataGridView();
            this.bttEliminar = new System.Windows.Forms.Button();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.picRegreso = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datosProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRegreso)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(51, 83);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(274, 23);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(51, 178);
            this.txtEmpresa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(274, 23);
            this.txtEmpresa.TabIndex = 1;
            this.txtEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpresa_KeyPress);
            // 
            // txtNumero_Proveedor
            // 
            this.txtNumero_Proveedor.Location = new System.Drawing.Point(51, 270);
            this.txtNumero_Proveedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumero_Proveedor.Name = "txtNumero_Proveedor";
            this.txtNumero_Proveedor.Size = new System.Drawing.Size(274, 23);
            this.txtNumero_Proveedor.TabIndex = 3;
            this.txtNumero_Proveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_Proveedor_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Numero_Proveedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Empresa";
            // 
            // bttAgregar
            // 
            this.bttAgregar.BackColor = System.Drawing.Color.White;
            this.bttAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttAgregar.Location = new System.Drawing.Point(9, 311);
            this.bttAgregar.Name = "bttAgregar";
            this.bttAgregar.Size = new System.Drawing.Size(85, 23);
            this.bttAgregar.TabIndex = 9;
            this.bttAgregar.Text = "AGREGAR";
            this.bttAgregar.UseVisualStyleBackColor = false;
            this.bttAgregar.Click += new System.EventHandler(this.bttAgregar_Click);
            // 
            // bttModificar
            // 
            this.bttModificar.BackColor = System.Drawing.Color.White;
            this.bttModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttModificar.Location = new System.Drawing.Point(137, 311);
            this.bttModificar.Name = "bttModificar";
            this.bttModificar.Size = new System.Drawing.Size(96, 23);
            this.bttModificar.TabIndex = 10;
            this.bttModificar.Text = "MODIFICAR";
            this.bttModificar.UseVisualStyleBackColor = false;
            this.bttModificar.Click += new System.EventHandler(this.bttModificar_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(48, 277);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 15);
            this.lblFecha.TabIndex = 12;
            // 
            // datosProveedor
            // 
            this.datosProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datosProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datosProveedor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.datosProveedor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.datosProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosProveedor.Location = new System.Drawing.Point(391, 83);
            this.datosProveedor.Name = "datosProveedor";
            this.datosProveedor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.datosProveedor.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.datosProveedor.Size = new System.Drawing.Size(421, 183);
            this.datosProveedor.TabIndex = 13;
            this.datosProveedor.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datosProveedor_CellContentDoubleClick);
            this.datosProveedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datosProveedor_CellDoubleClick);
            // 
            // bttEliminar
            // 
            this.bttEliminar.BackColor = System.Drawing.Color.White;
            this.bttEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttEliminar.Location = new System.Drawing.Point(274, 311);
            this.bttEliminar.Name = "bttEliminar";
            this.bttEliminar.Size = new System.Drawing.Size(79, 23);
            this.bttEliminar.TabIndex = 11;
            this.bttEliminar.Text = "ELIMINAR";
            this.bttEliminar.UseVisualStyleBackColor = false;
            this.bttEliminar.Click += new System.EventHandler(this.bttEliminar_Click);
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(9, 9);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(0, 15);
            this.lbl_Id.TabIndex = 14;
            this.lbl_Id.Visible = false;
            // 
            // picRegreso
            // 
            this.picRegreso.Image = ((System.Drawing.Image)(resources.GetObject("picRegreso.Image")));
            this.picRegreso.Location = new System.Drawing.Point(19, 3);
            this.picRegreso.Name = "picRegreso";
            this.picRegreso.Size = new System.Drawing.Size(29, 21);
            this.picRegreso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRegreso.TabIndex = 15;
            this.picRegreso.TabStop = false;
            this.picRegreso.Click += new System.EventHandler(this.picRegreso_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Regresar";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(824, 340);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picRegreso);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.datosProveedor);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.bttEliminar);
            this.Controls.Add(this.bttModificar);
            this.Controls.Add(this.bttAgregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumero_Proveedor);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.txtNombre);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Formulario Proveedores";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datosProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRegreso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.TextBox txtNumero_Proveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bttAgregar;
        private System.Windows.Forms.Button bttModificar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DataGridView datosProveedor;
        private System.Windows.Forms.Button bttEliminar;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.PictureBox picRegreso;
        private System.Windows.Forms.Label label3;
    }
}