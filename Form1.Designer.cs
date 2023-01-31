
namespace PracticaCedis
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.CheckLista = new System.Windows.Forms.CheckedListBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.DataDatos = new System.Windows.Forms.DataGridView();
            this.bttEliminar = new System.Windows.Forms.Button();
            this.bttModificar = new System.Windows.Forms.Button();
            this.bttAgregar = new System.Windows.Forms.Button();
            this.lblNroProvee = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.combo_Nro = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PicCerrar = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Estatus actual:";
            // 
            // CheckLista
            // 
            this.CheckLista.FormattingEnabled = true;
            this.CheckLista.Items.AddRange(new object[] {
            "Activo ",
            "Inactivo"});
            this.CheckLista.Location = new System.Drawing.Point(43, 280);
            this.CheckLista.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckLista.Name = "CheckLista";
            this.CheckLista.Size = new System.Drawing.Size(142, 40);
            this.CheckLista.TabIndex = 27;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(43, 321);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(47, 23);
            this.txtId.TabIndex = 26;
            this.txtId.Visible = false;
            // 
            // DataDatos
            // 
            this.DataDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.DataDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataDatos.GridColor = System.Drawing.Color.Black;
            this.DataDatos.Location = new System.Drawing.Point(497, 41);
            this.DataDatos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataDatos.Name = "DataDatos";
            this.DataDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DataDatos.Size = new System.Drawing.Size(510, 253);
            this.DataDatos.TabIndex = 25;
            this.DataDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataDatos_CellDoubleClick);
            // 
            // bttEliminar
            // 
            this.bttEliminar.BackColor = System.Drawing.Color.White;
            this.bttEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttEliminar.Location = new System.Drawing.Point(570, 354);
            this.bttEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bttEliminar.Name = "bttEliminar";
            this.bttEliminar.Size = new System.Drawing.Size(99, 26);
            this.bttEliminar.TabIndex = 24;
            this.bttEliminar.Text = "Eliminar";
            this.bttEliminar.UseVisualStyleBackColor = false;
            this.bttEliminar.Click += new System.EventHandler(this.bttEliminar_Click);
            // 
            // bttModificar
            // 
            this.bttModificar.BackColor = System.Drawing.Color.White;
            this.bttModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttModificar.Location = new System.Drawing.Point(296, 354);
            this.bttModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bttModificar.Name = "bttModificar";
            this.bttModificar.Size = new System.Drawing.Size(99, 26);
            this.bttModificar.TabIndex = 23;
            this.bttModificar.Text = "Modificar";
            this.bttModificar.UseVisualStyleBackColor = false;
            this.bttModificar.Click += new System.EventHandler(this.bttModificar_Click);
            // 
            // bttAgregar
            // 
            this.bttAgregar.BackColor = System.Drawing.Color.White;
            this.bttAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttAgregar.Location = new System.Drawing.Point(22, 354);
            this.bttAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bttAgregar.Name = "bttAgregar";
            this.bttAgregar.Size = new System.Drawing.Size(99, 26);
            this.bttAgregar.TabIndex = 22;
            this.bttAgregar.Text = "Agregar";
            this.bttAgregar.UseVisualStyleBackColor = false;
            this.bttAgregar.Click += new System.EventHandler(this.bttAgregar_Click);
            // 
            // lblNroProvee
            // 
            this.lblNroProvee.AutoSize = true;
            this.lblNroProvee.Location = new System.Drawing.Point(41, 195);
            this.lblNroProvee.Name = "lblNroProvee";
            this.lblNroProvee.Size = new System.Drawing.Size(148, 15);
            this.lblNroProvee.TabIndex = 21;
            this.lblNroProvee.Text = "Numero de proveedor";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(41, 112);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(86, 15);
            this.lblDesc.TabIndex = 20;
            this.lblDesc.Text = "Descripción";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(41, 59);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(53, 15);
            this.lblCodigo.TabIndex = 19;
            this.lblCodigo.Text = "Código";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(43, 132);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDescripcion.MaxLength = 60;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(411, 56);
            this.txtDescripcion.TabIndex = 17;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(43, 82);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(174, 23);
            this.txtCodigo.TabIndex = 16;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // combo_Nro
            // 
            this.combo_Nro.FormattingEnabled = true;
            this.combo_Nro.Location = new System.Drawing.Point(43, 214);
            this.combo_Nro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.combo_Nro.Name = "combo_Nro";
            this.combo_Nro.Size = new System.Drawing.Size(159, 23);
            this.combo_Nro.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(108, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(57, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Agregar proveedores";
            // 
            // PicCerrar
            // 
            this.PicCerrar.Image = ((System.Drawing.Image)(resources.GetObject("PicCerrar.Image")));
            this.PicCerrar.Location = new System.Drawing.Point(255, -1);
            this.PicCerrar.Name = "PicCerrar";
            this.PicCerrar.Size = new System.Drawing.Size(32, 27);
            this.PicCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicCerrar.TabIndex = 32;
            this.PicCerrar.TabStop = false;
            this.PicCerrar.Click += new System.EventHandler(this.PicCerrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(220, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "Cerrar Sesión";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1028, 390);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PicCerrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.combo_Nro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckLista);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.DataDatos);
            this.Controls.Add(this.bttEliminar);
            this.Controls.Add(this.bttModificar);
            this.Controls.Add(this.bttAgregar);
            this.Controls.Add(this.lblNroProvee);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCodigo);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Formulario Datos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox CheckLista;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView DataDatos;
        private System.Windows.Forms.Button bttEliminar;
        private System.Windows.Forms.Button bttModificar;
        private System.Windows.Forms.Button bttAgregar;
        private System.Windows.Forms.Label lblNroProvee;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox combo_Nro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PicCerrar;
        private System.Windows.Forms.Label label3;
    }
}

