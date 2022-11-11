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
            this.lblBuscarPerro = new System.Windows.Forms.Label();
            this.txtBuscarPerrito = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perritoBindingSource)).BeginInit();
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
            this.dgvPerros.Location = new System.Drawing.Point(33, 139);
            this.dgvPerros.Name = "dgvPerros";
            this.dgvPerros.RowTemplate.Height = 25;
            this.dgvPerros.Size = new System.Drawing.Size(943, 285);
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
            this.btVer.Location = new System.Drawing.Point(901, 88);
            this.btVer.Name = "btVer";
            this.btVer.Size = new System.Drawing.Size(75, 23);
            this.btVer.TabIndex = 15;
            this.btVer.Text = "Ver Perritos";
            this.btVer.UseVisualStyleBackColor = true;
            this.btVer.Click += new System.EventHandler(this.btVer_Click);
            // 
            // btnVerCargaPerrito
            // 
            this.btnVerCargaPerrito.Location = new System.Drawing.Point(901, 49);
            this.btnVerCargaPerrito.Name = "btnVerCargaPerrito";
            this.btnVerCargaPerrito.Size = new System.Drawing.Size(75, 23);
            this.btnVerCargaPerrito.TabIndex = 17;
            this.btnVerCargaPerrito.Text = "Cargar Perrito";
            this.btnVerCargaPerrito.UseVisualStyleBackColor = true;
            this.btnVerCargaPerrito.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblBuscarPerro
            // 
            this.lblBuscarPerro.AutoSize = true;
            this.lblBuscarPerro.Location = new System.Drawing.Point(33, 76);
            this.lblBuscarPerro.Name = "lblBuscarPerro";
            this.lblBuscarPerro.Size = new System.Drawing.Size(73, 15);
            this.lblBuscarPerro.TabIndex = 18;
            this.lblBuscarPerro.Text = "Buscar Perro";
            // 
            // txtBuscarPerrito
            // 
            this.txtBuscarPerrito.Location = new System.Drawing.Point(142, 73);
            this.txtBuscarPerrito.Name = "txtBuscarPerrito";
            this.txtBuscarPerrito.Size = new System.Drawing.Size(334, 23);
            this.txtBuscarPerrito.TabIndex = 19;
            // 
            // FormVerPerritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 450);
            this.Controls.Add(this.txtBuscarPerrito);
            this.Controls.Add(this.lblBuscarPerro);
            this.Controls.Add(this.btnVerCargaPerrito);
            this.Controls.Add(this.dgvPerros);
            this.Controls.Add(this.btVer);
            this.Name = "FormVerPerritos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perritoBindingSource)).EndInit();
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
        private Label lblBuscarPerro;
        private TextBox txtBuscarPerrito;
    }
}