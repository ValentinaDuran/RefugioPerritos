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
            this.dgvPerros = new System.Windows.Forms.DataGridView();
            this.btVer = new System.Windows.Forms.Button();
            this.btnVerCargaPerrito = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPerros
            // 
            this.dgvPerros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerros.Location = new System.Drawing.Point(94, 132);
            this.dgvPerros.Name = "dgvPerros";
            this.dgvPerros.RowTemplate.Height = 25;
            this.dgvPerros.Size = new System.Drawing.Size(240, 150);
            this.dgvPerros.TabIndex = 16;
            // 
            // btVer
            // 
            this.btVer.Location = new System.Drawing.Point(94, 75);
            this.btVer.Name = "btVer";
            this.btVer.Size = new System.Drawing.Size(75, 23);
            this.btVer.TabIndex = 15;
            this.btVer.Text = "Ver Perritos";
            this.btVer.UseVisualStyleBackColor = true;
            // 
            // btnVerCargaPerrito
            // 
            this.btnVerCargaPerrito.Location = new System.Drawing.Point(407, 75);
            this.btnVerCargaPerrito.Name = "btnVerCargaPerrito";
            this.btnVerCargaPerrito.Size = new System.Drawing.Size(75, 23);
            this.btnVerCargaPerrito.TabIndex = 17;
            this.btnVerCargaPerrito.Text = "Cargar Perrito";
            this.btnVerCargaPerrito.UseVisualStyleBackColor = true;
            this.btnVerCargaPerrito.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormVerPerritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVerCargaPerrito);
            this.Controls.Add(this.dgvPerros);
            this.Controls.Add(this.btVer);
            this.Name = "FormVerPerritos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dgvPerros;
        private Button btVer;
        private Button btnVerCargaPerrito;
    }
}