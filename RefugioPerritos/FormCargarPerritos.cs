using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RefugioPerritos
{
    public partial class FormCargarPerritos : Form
    {
        private ReglasDeNegocio reglasDeNegocio;


        public FormCargarPerritos()
        {
            InitializeComponent();
            reglasDeNegocio = new ReglasDeNegocio();
            CargarRefugioEnCbox();
            //this.cboxRefugios.DropDownStyle = ComboBoxStyle.DropDownList;
            ////string Texto1 = "Refugios";
            //if (cboxRefugios.SelectedIndex = 1)
            //{
            //    cboxRefugios.Text = "Refugios";
            //}
            //cboxRefugios.SelectedIndex = System.Convert.ToInt32 (Texto1);
        }

        private void btnSalirDeCarga_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCargar_Click(object sender, EventArgs e)
        {
            SavePerrito();
            this.Close();
            ((FormVerPerritos)this.Owner).CargarPerritoEnDGV();
        }

        private void SavePerrito() 
        {
            Perrito perrito = new Perrito();
            perrito.nombre_perro = txtNombre.Text;
            perrito.edad_aprox = int.Parse(txtEdadAprox.Text);
            perrito.color_cuerpo = txtPelo.Text;
            perrito.color_ojos = txtOjos.Text;
            perrito.castrado = checkCastrado.Checked;
            //Aca se toma solamente la fecha-mes-año del datetime, pero no la hora
            perrito.fecha_ingreso = datetimeFechaIngreso.Value;
            perrito.NombreRefugioId = cboxRefugios.Text;

            reglasDeNegocio.SavePerrito(perrito);


        }

        private void CargarRefugioEnCbox() 
        {
            List<Refugio> refugios = reglasDeNegocio.GetRefugios();
            cboxRefugios.DataSource = refugios;
            cboxRefugios.ValueMember = "NombreRefugioId";
            cboxRefugios.DisplayMember = "NombreRefugioId";

        }

        private void txtEdadAprox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
