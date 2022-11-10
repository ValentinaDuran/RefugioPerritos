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

        private void CargarPerritoEnDGV() 
        {
           List<Perrito> perritos = reglasDeNegocio.GetPerritos();
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
            formCargarPerritos.ShowDialog();
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