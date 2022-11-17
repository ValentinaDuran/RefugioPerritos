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
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefugios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRefugios
            // 
            this.dgvRefugios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRefugios.Location = new System.Drawing.Point(30, 109);
            this.dgvRefugios.Name = "dgvRefugios";
            this.dgvRefugios.RowTemplate.Height = 25;
            this.dgvRefugios.Size = new System.Drawing.Size(733, 283);
            this.dgvRefugios.TabIndex = 0;
            // 
            // FormRefugios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RefugioPerritos.Properties.Resources.Patitas_wallpaper;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvRefugios);
            this.Name = "FormRefugios";
            this.Text = "Info de los refugios";
            this.Load += new System.EventHandler(this.FormRefugios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefugios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvRefugios;
    }
}