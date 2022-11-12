using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefugioPerritos
{
    public partial class FormRefugios : Form
    {
        private ReglasDeNegocio reglasDeNegocio;
        public FormRefugios()
        {
            InitializeComponent();
            reglasDeNegocio = new ReglasDeNegocio();
        }

        private void FormRefugios_Load(object sender, EventArgs e)
        {
            CargarRefugiosEnDGV();
        }

        public void CargarRefugiosEnDGV() 
        {
            List<Refugio> refugios = reglasDeNegocio.GetRefugiosDGV();
            dgvRefugios.DataSource = refugios;
        }
    }
}
