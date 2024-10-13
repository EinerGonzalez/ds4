namespace laboratorio_12._2
{
    public partial class resultado : Form
    {
        public resultado()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt2.Text = "";
            n1.Text = "";
            n2.Text = "";
            n3.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double valor1 = Convert.ToDouble(n1.Text);
                double valor2 = Convert.ToDouble(n2.Text);
                double valor3 = Convert.ToDouble(n3.Text);
                double promedio = (valor1 + valor2 + valor3) / 3;
                txt2.Text = promedio.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Porfavor, ingrese solo numeros validos");
            }
        }

        private void n1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
