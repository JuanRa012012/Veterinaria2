namespace Veterinaria2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        clsConexion clsConexion = new clsConexion();

        private void button2_Click(object sender, EventArgs e)
        {
            clsConexion.Abrir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsConexion.Cerrar();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Especies especies = new Especies();
            especies.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Login().Show();
        }
    }

}
