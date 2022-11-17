namespace RefugioPerritos
{
    partial class FormVerPerritos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvPerros = new System.Windows.Forms.DataGridView();
            this.perritoDNIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreperroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadaproxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorcuerpoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorojosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.castradoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fechaingresoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreRefugioIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.perritoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btVer = new System.Windows.Forms.Button();
            this.btnVerCargaPerrito = new System.Windows.Forms.Button();
            this.txtBuscarPerrito = new System.Windows.Forms.TextBox();
            this.btVerRefugios = new System.Windows.Forms.Button();
            this.pboxTituloIefi = new System.Windows.Forms.PictureBox();
            this.pboxFiltrarPerrito = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perritoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxTituloIefi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFiltrarPerrito)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPerros
            // 
            this.dgvPerros.AutoGenerateColumns = false;
            this.dgvPerros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perritoDNIDataGridViewTextBoxColumn,
            this.nombreperroDataGridViewTextBoxColumn,
            this.edadaproxDataGridViewTextBoxColumn,
            this.colorcuerpoDataGridViewTextBoxColumn,
            this.colorojosDataGridViewTextBoxColumn,
            this.castradoDataGridViewCheckBoxColumn,
            this.fechaingresoDataGridViewTextBoxColumn,
            this.nombreRefugioIdDataGridViewTextBoxColumn,
            this.Eliminar});
            this.dgvPerros.DataSource = this.perritoBindingSource;
            this.dgvPerros.Location = new System.Drawing.Point(33, 198);
            this.dgvPerros.Name = "dgvPerros";
            this.dgvPerros.RowTemplate.Height = 25;
            this.dgvPerros.Size = new System.Drawing.Size(943, 254);
            this.dgvPerros.TabIndex = 16;
            this.dgvPerros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerros_CellContentClick);
            // 
            // perritoDNIDataGridViewTextBoxColumn
            // 
            this.perritoDNIDataGridViewTextBoxColumn.DataPropertyName = "perritoDNI";
            this.perritoDNIDataGridViewTextBoxColumn.HeaderText = "perritoDNI";
            this.perritoDNIDataGridViewTextBoxColumn.Name = "perritoDNIDataGridViewTextBoxColumn";
            // 
            // nombreperroDataGridViewTextBoxColumn
            // 
            this.nombreperroDataGridViewTextBoxColumn.DataPropertyName = "nombre_perro";
            this.nombreperroDataGridViewTextBoxColumn.HeaderText = "nombre_perro";
            this.nombreperroDataGridViewTextBoxColumn.Name = "nombreperroDataGridViewTextBoxColumn";
            // 
            // edadaproxDataGridViewTextBoxColumn
            // 
            this.edadaproxDataGridViewTextBoxColumn.DataPropertyName = "edad_aprox";
            this.edadaproxDataGridViewTextBoxColumn.HeaderText = "edad_aprox";
            this.edadaproxDataGridViewTextBoxColumn.Name = "edadaproxDataGridViewTextBoxColumn";
            // 
            // colorcuerpoDataGridViewTextBoxColumn
            // 
            this.colorcuerpoDataGridViewTextBoxColumn.DataPropertyName = "color_cuerpo";
            this.colorcuerpoDataGridViewTextBoxColumn.HeaderText = "color_cuerpo";
            this.colorcuerpoDataGridViewTextBoxColumn.Name = "colorcuerpoDataGridViewTextBoxColumn";
            // 
            // colorojosDataGridViewTextBoxColumn
            // 
            this.colorojosDataGridViewTextBoxColumn.DataPropertyName = "color_ojos";
            this.colorojosDataGridViewTextBoxColumn.HeaderText = "color_ojos";
            this.colorojosDataGridViewTextBoxColumn.Name = "colorojosDataGridViewTextBoxColumn";
            // 
            // castradoDataGridViewCheckBoxColumn
            // 
            this.castradoDataGridViewCheckBoxColumn.DataPropertyName = "castrado";
            this.castradoDataGridViewCheckBoxColumn.HeaderText = "castrado";
            this.castradoDataGridViewCheckBoxColumn.Name = "castradoDataGridViewCheckBoxColumn";
            // 
            // fechaingresoDataGridViewTextBoxColumn
            // 
            this.fechaingresoDataGridViewTextBoxColumn.DataPropertyName = "fecha_ingreso";
            this.fechaingresoDataGridViewTextBoxColumn.HeaderText = "fecha_ingreso";
            this.fechaingresoDataGridViewTextBoxColumn.Name = "fechaingresoDataGridViewTextBoxColumn";
            // 
            // nombreRefugioIdDataGridViewTextBoxColumn
            // 
            this.nombreRefugioIdDataGridViewTextBoxColumn.DataPropertyName = "NombreRefugioId";
            this.nombreRefugioIdDataGridViewTextBoxColumn.HeaderText = "NombreRefugioId";
            this.nombreRefugioIdDataGridViewTextBoxColumn.Name = "nombreRefugioIdDataGridViewTextBoxColumn";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForLinkValue = true;
            // 
            // perritoBindingSource
            // 
            this.perritoBindingSource.DataSource = typeof(RefugioPerritos.Perrito);
            // 
            // btVer
            // 
            this.btVer.BackColor = System.Drawing.Color.Transparent;
            this.btVer.BackgroundImage = global::RefugioPerritos.Properties.Resources.Boton_Buscar;
            this.btVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btVer.FlatAppearance.BorderSize = 0;
            this.btVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVer.Location = new System.Drawing.Point(494, 103);
            this.btVer.Name = "btVer";
            this.btVer.Size = new System.Drawing.Size(75, 61);
            this.btVer.TabIndex = 15;
            this.btVer.UseVisualStyleBackColor = false;
            this.btVer.Click += new System.EventHandler(this.btVer_Click);
            // 
            // btnVerCargaPerrito
            // 
            this.btnVerCargaPerrito.BackColor = System.Drawing.Color.Transparent;
            this.btnVerCargaPerrito.BackgroundImage = global::RefugioPerritos.Properties.Resources.Boton_Cargar;
            this.btnVerCargaPerrito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVerCargaPerrito.FlatAppearance.BorderSize = 0;
            this.btnVerCargaPerrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerCargaPerrito.Location = new System.Drawing.Point(665, 101);
            this.btnVerCargaPerrito.Name = "btnVerCargaPerrito";
            this.btnVerCargaPerrito.Size = new System.Drawing.Size(75, 63);
            this.btnVerCargaPerrito.TabIndex = 17;
            this.btnVerCargaPerrito.UseVisualStyleBackColor = false;
            this.btnVerCargaPerrito.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBuscarPerrito
            // 
            this.txtBuscarPerrito.Location = new System.Drawing.Point(154, 130);
            this.txtBuscarPerrito.Name = "txtBuscarPerrito";
            this.txtBuscarPerrito.Size = new System.Drawing.Size(334, 23);
            this.txtBuscarPerrito.TabIndex = 19;
            // 
            // btVerRefugios
            // 
            this.btVerRefugios.BackColor = System.Drawing.Color.Transparent;
            this.btVerRefugios.BackgroundImage = global::RefugioPerritos.Properties.Resources.Boton_Info;
            this.btVerRefugios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btVerRefugios.FlatAppearance.BorderSize = 0;
            this.btVerRefugios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVerRefugios.Location = new System.Drawing.Point(33, 12);
            this.btVerRefugios.Name = "btVerRefugios";
            this.btVerRefugios.Size = new System.Drawing.Size(67, 58);
            this.btVerRefugios.TabIndex = 20;
            this.btVerRefugios.UseVisualStyleBackColor = false;
            this.btVerRefugios.Click += new System.EventHandler(this.btVerRefugios_Click);
            // 
            // pboxTituloIefi
            // 
            this.pboxTituloIefi.BackColor = System.Drawing.Color.Transparent;
            this.pboxTituloIefi.Image = global::RefugioPerritos.Properties.Resources.Titutlo_Iefi;
            this.pboxTituloIefi.Location = new System.Drawing.Point(764, 1);
            this.pboxTituloIefi.Name = "pboxTituloIefi";
            this.pboxTituloIefi.Size = new System.Drawing.Size(241, 180);
            this.pboxTituloIefi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxTituloIefi.TabIndex = 21;
            this.pboxTituloIefi.TabStop = false;
            // 
            // pboxFiltrarPerrito
            // 
            this.pboxFiltrarPerrito.BackColor = System.Drawing.Color.Transparent;
            this.pboxFiltrarPerrito.Image = global::RefugioPerritos.Properties.Resources.Label_Filtrar_nombre;
            this.pboxFiltrarPerrito.Location = new System.Drawing.Point(33, 83);
            this.pboxFiltrarPerrito.Name = "pboxFiltrarPerrito";
            this.pboxFiltrarPerrito.Size = new System.Drawing.Size(115, 109);
            this.pboxFiltrarPerrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxFiltrarPerrito.TabIndex = 22;
            this.pboxFiltrarPerrito.TabStop = false;
            // 
            // FormVerPerritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RefugioPerritos.Properties.Resources.Patitas_wallpaper;
            this.ClientSize = new System.Drawing.Size(1017, 477);
            this.Controls.Add(this.pboxFiltrarPerrito);
            this.Controls.Add(this.pboxTituloIefi);
            this.Controls.Add(this.btVerRefugios);
            this.Controls.Add(this.txtBuscarPerrito);
            this.Controls.Add(this.btnVerCargaPerrito);
            this.Controls.Add(this.dgvPerros);
            this.Controls.Add(this.btVer);
            this.Name = "FormVerPerritos";
            this.Text = "Refugio Iefi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perritoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxTituloIefi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFiltrarPerrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dgvPerros;
        private Button btVer;
        private Button btnVerCargaPerrito;
        private BindingSource perritoBindingSource;
        private DataGridViewTextBoxColumn perritoDNIDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreperroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn edadaproxDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn colorcuerpoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn colorojosDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn castradoDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn fechaingresoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreRefugioIdDataGridViewTextBoxColumn;
        private DataGridViewLinkColumn Eliminar;
        private TextBox txtBuscarPerrito;
        private Button btVerRefugios;
        private PictureBox pboxTituloIefi;
        private PictureBox pboxFiltrarPerrito;
    }
}