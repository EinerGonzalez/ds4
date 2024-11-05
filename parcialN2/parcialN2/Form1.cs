using System.Drawing;

namespace parcialN2
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
                decimal numero = 1.14m;
                decimal nun2 = 4.258m;
                decimal euro = decimal.Parse(te1.Text);
                decimal fijo;
                fijo = euro;
                te3.Text = euro.ToString();
                decimal cambio1 = euro / numero;
                te2.Text = cambio1.ToString();
                decimal cambio2 = cambio1 * nun2;
                te4.Text = cambio2.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("por favor ingresa numero valido");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                decimal numero = 1.14m;
                decimal nun2 = 4.258m;
                decimal peso = decimal.Parse(tp1.Text);
                decimal fijo;
                fijo = peso;
                tp4.Text =peso.ToString();
                decimal cambio1 =  peso/numero;
                tp2.Text = cambio1.ToString();
                decimal cambio2 = cambio1 * numero;
                tp3.Text = cambio2.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("por favor ingresa numero valido");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                

                decimal numero = 0.85m;
                decimal n2 = 4.258m;
                decimal dolar = decimal.Parse(td1.Text);
                decimal fijo;
                fijo = dolar;
                td2.Text = fijo.ToString();
                decimal cambio1 = dolar * numero;
                td3.Text = cambio1.ToString();
                decimal cambio2 = dolar * n2;
                td4.Text = cambio1.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("por favor ingresa numero valido");
            }
        }
    }
}
