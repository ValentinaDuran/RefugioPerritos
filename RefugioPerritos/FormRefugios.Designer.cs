namespace RefugioPerritos
{
    partial class FormRefugios
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
            this.dgvRefugios = new System.Windows.Forms.DataGridView();
            this.pboxInfoRefugioss = new System.Windows.Forms.PictureBox();
            this.btVolverDeInfoRefugios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefugios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxInfoRefugioss)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRefugios
            // 
            this.dgvRefugios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRefugios.Location = new System.Drawing.Point(118, 130);
            this.dgvRefugios.Name = "dgvRefugios";
            this.dgvRefugios.RowTemplate.Height = 25;
            this.dgvRefugios.Size = new System.Drawing.Size(546, 273);
            this.dgvRefugios.TabIndex = 0;
            // 
            // pboxInfoRefugioss
            // 
            this.pboxInfoRefugioss.BackColor = System.Drawing.Color.Transparent;
            this.pboxInfoRefugioss.Image = global::RefugioPerritos.Properties.Resources.TItulo_Refugios;
            this.pboxInfoRefugioss.Location = new System.Drawing.Point(318, -16);
            this.pboxInfoRefugioss.Name = "pboxInfoRefugioss";
            this.pboxInfoRefugioss.Size = new System.Drawing.Size(173, 140);
            this.pboxInfoRefugioss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxInfoRefugioss.TabIndex = 1;
            this.pboxInfoRefugioss.TabStop = false;
            // 
            // btVolverDeInfoRefugios
            // 
            this.btVolverDeInfoRefugios.BackColor = System.Drawing.Color.Transparent;
            this.btVolverDeInfoRefugios.BackgroundImage = global::RefugioPerritos.Properties.Resources.Boton_Volver1;
            this.btVolverDeInfoRefugios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btVolverDeInfoRefugios.FlatAppearance.BorderSize = 0;
            this.btVolverDeInfoRefugios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVolverDeInfoRefugios.Location = new System.Drawing.Point(695, 369);
            this.btVolverDeInfoRefugios.Name = "btVolverDeInfoRefugios";
            this.btVolverDeInfoRefugios.Size = new System.Drawing.Size(83, 69);
            this.btVolverDeInfoRefugios.TabIndex = 2;
            this.btVolverDeInfoRefugios.UseVisualStyleBackColor = false;
            this.btVolverDeInfoRefugios.Click += new System.EventHandler(this.btVolverDeInfoRefugios_Click);
            // 
            // FormRefugios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RefugioPerritos.Properties.Resources.Patitas_wallpaper;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btVolverDeInfoRefugios);
            this.Controls.Add(this.pboxInfoRefugioss);
            this.Controls.Add(this.dgvRefugios);
            this.Name = "FormRefugios";
            this.Text = "Info de los refugios";
            this.Load += new System.EventHandler(this.FormRefugios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefugios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxInfoRefugioss)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvRefugios;
        private PictureBox pboxInfoRefugioss;
        private Button btVolverDeInfoRefugios;
    }
}