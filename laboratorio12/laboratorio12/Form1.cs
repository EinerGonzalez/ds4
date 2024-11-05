namespace laboratorio12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double valor1 = Convert.ToDouble(n1.Text);
                double valor2 = Convert.ToDouble(n2.Text);

                double semiP = valor1 * valor2;

                resp.Text = semiP.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Porfavor, ingrese solo numeros validos");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n1.Text = "";
            n2.Text = "";
            resp.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
