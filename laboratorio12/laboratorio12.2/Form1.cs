namespace laboratorio12._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            n1.Text = "";
            n2.Text = "";
            n3.Text = "";
            txt1.Text = "";
            txt2.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double valor1 = Convert.ToDouble(n1.Text);
                double valor2 = Convert.ToDouble(n2.Text);
                double valor3 = Convert.ToDouble(n3.Text);
                double semiP = (valor1 + valor2 + valor3) / 2;
                double areaTriangulo = Math.Sqrt(semiP * (semiP - valor1) * (semiP - valor2) * (semiP - valor3));
                txt2.Text = areaTriangulo.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Porfavor, ingrese solo numeros validos");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double valor1 = Convert.ToDouble(n1.Text);
                double valor2 = Convert.ToDouble(n2.Text);
                double valor3 = Convert.ToDouble(n3.Text);
                double semiP = (valor1 + valor2 + valor3) / 2;
              
                txt1.Text = semiP.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Porfavor, ingrese solo numeros validos");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
