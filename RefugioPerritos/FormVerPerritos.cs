namespace RefugioPerritos
{
    public partial class FormVerPerritos : Form
    {
        private ReglasDeNegocio reglasDeNegocio;
        public FormVerPerritos()
        {
            InitializeComponent();
            reglasDeNegocio = new ReglasDeNegocio();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarPerritoEnDGV();
        }

        public void CargarPerritoEnDGV(string buscarPerro = null) 
        {
           List<Perrito> perritos = reglasDeNegocio.GetPerritos(buscarPerro);
            dgvPerros.DataSource = perritos;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        #region Eventos
        //Boton ver carga perrito
        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormCargarPerritosDialog();
        }
        #endregion


        private void AbrirFormCargarPerritosDialog() 
        {
            FormCargarPerritos formCargarPerritos = new FormCargarPerritos();
            formCargarPerritos.ShowDialog(this);
        }
        
        

        private void dgvPerros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)dgvPerros.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (cell.Value.ToString() == "Eliminar")
            {
                EliminarPerrito(int.Parse(dgvPerros.Rows[e.RowIndex].Cells[0].Value.ToString()));
                CargarPerritoEnDGV();
            }
        }

        private void EliminarPerrito(int DNI)
        {
            reglasDeNegocio.DeletePerrito(DNI);
        }

        private void btVer_Click(object sender, EventArgs e)
        {
            CargarPerritoEnDGV(txtBuscarPerrito.Text);
            txtBuscarPerrito.Text = string.Empty;
        }

        private void btVerRefugios_Click(object sender, EventArgs e)
        {
            AbrirFormVerRefugiosDialog();
        }

        private void AbrirFormVerRefugiosDialog()
        {
            FormRefugios formRefugios = new FormRefugios();
            formRefugios.ShowDialog(this);
        }


        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        //private void button1_Click(object sender, EventArgs e)
        //{

        //}

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void label3_Click(object sender, EventArgs e)
        //{

        //}

        //private void textBox5_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void label7_Click(object sender, EventArgs e)
        //{

        //}
    }
}