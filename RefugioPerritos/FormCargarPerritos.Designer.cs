namespace RefugioPerritos
{
    partial class FormCargarPerritos
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
            this.checkCastrado = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxRefugios = new System.Windows.Forms.ComboBox();
            this.txtPelo = new System.Windows.Forms.TextBox();
            this.txtOjos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btCargar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalirDeCarga = new System.Windows.Forms.Button();
            this.txtEdadAprox = new System.Windows.Forms.TextBox();
            this.datetimeFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // checkCastrado
            // 
            this.checkCastrado.AutoSize = true;
            this.checkCastrado.Location = new System.Drawing.Point(544, 186);
            this.checkCastrado.Name = "checkCastrado";
            this.checkCastrado.Size = new System.Drawing.Size(73, 19);
            this.checkCastrado.TabIndex = 32;
            this.checkCastrado.Text = "Castrado";
            this.checkCastrado.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(441, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 15);
            this.label7.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(544, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "Refugio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "Color Ojos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Color Pelo ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Edad Aproximada ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombre";
            // 
            // cboxRefugios
            // 
            this.cboxRefugios.FormattingEnabled = true;
            this.cboxRefugios.Items.AddRange(new object[] {
            "San Perruno"});
            this.cboxRefugios.Location = new System.Drawing.Point(510, 133);
            this.cboxRefugios.Name = "cboxRefugios";
            this.cboxRefugios.Size = new System.Drawing.Size(121, 23);
            this.cboxRefugios.TabIndex = 24;
            // 
            // txtPelo
            // 
            this.txtPelo.Location = new System.Drawing.Point(165, 179);
            this.txtPelo.Name = "txtPelo";
            this.txtPelo.Size = new System.Drawing.Size(100, 23);
            this.txtPelo.TabIndex = 23;
            // 
            // txtOjos
            // 
            this.txtOjos.Location = new System.Drawing.Point(165, 222);
            this.txtOjos.Name = "txtOjos";
            this.txtOjos.Size = new System.Drawing.Size(100, 23);
            this.txtOjos.TabIndex = 22;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(165, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 21;
            // 
            // btCargar
            // 
            this.btCargar.Location = new System.Drawing.Point(441, 237);
            this.btCargar.Name = "btCargar";
            this.btCargar.Size = new System.Drawing.Size(75, 23);
            this.btCargar.TabIndex = 20;
            this.btCargar.Text = "Cargar";
            this.btCargar.UseVisualStyleBackColor = true;
            this.btCargar.Click += new System.EventHandler(this.btCargar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "CARGAR PERRITOS";
            // 
            // btnSalirDeCarga
            // 
            this.btnSalirDeCarga.Location = new System.Drawing.Point(484, 319);
            this.btnSalirDeCarga.Name = "btnSalirDeCarga";
            this.btnSalirDeCarga.Size = new System.Drawing.Size(75, 23);
            this.btnSalirDeCarga.TabIndex = 33;
            this.btnSalirDeCarga.Text = "Salir";
            this.btnSalirDeCarga.UseVisualStyleBackColor = true;
            this.btnSalirDeCarga.Click += new System.EventHandler(this.btnSalirDeCarga_Click);
            // 
            // txtEdadAprox
            // 
            this.txtEdadAprox.Location = new System.Drawing.Point(165, 125);
            this.txtEdadAprox.Name = "txtEdadAprox";
            this.txtEdadAprox.Size = new System.Drawing.Size(100, 23);
            this.txtEdadAprox.TabIndex = 34;
            this.txtEdadAprox.TextChanged += new System.EventHandler(this.txtEdadAprox_TextChanged);
            // 
            // datetimeFechaIngreso
            // 
            this.datetimeFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimeFechaIngreso.Location = new System.Drawing.Point(86, 317);
            this.datetimeFechaIngreso.Name = "datetimeFechaIngreso";
            this.datetimeFechaIngreso.Size = new System.Drawing.Size(200, 23);
            this.datetimeFechaIngreso.TabIndex = 35;
            // 
            // FormCargarPerritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RefugioPerritos.Properties.Resources.Patitas_wallpaper;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datetimeFechaIngreso);
            this.Controls.Add(this.txtEdadAprox);
            this.Controls.Add(this.btnSalirDeCarga);
            this.Controls.Add(this.checkCastrado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboxRefugios);
            this.Controls.Add(this.txtPelo);
            this.Controls.Add(this.txtOjos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btCargar);
            this.Controls.Add(this.label1);
            this.Name = "FormCargarPerritos";
            this.Text = "Ingresar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox checkCastrado;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cboxRefugios;
        private TextBox txtPelo;
        private TextBox txtOjos;
        private TextBox txtNombre;
        private Button btCargar;
        private Label label1;
        private Button btnSalirDeCarga;
        private TextBox txtEdadAprox;
        private DateTimePicker datetimeFechaIngreso;
    }
}