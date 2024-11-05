using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace partial1
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
                const double capacidadDVDEnMB = 4.7 * 1024;


                int archivos = int.Parse(e1.Text);
                int megas = int.Parse(e2.Text);

                double espacioTotalOcupado = archivos * megas;



               
                double cantidadArchivosQueCaben = capacidadDVDEnMB / megas;

               
                int archivosQueCaben = (int)Math.Floor(cantidadArchivosQueCaben);
                if (espacioTotalOcupado <= capacidadDVDEnMB)
                {
                    string texto = $"en un dvd caven{archivosQueCaben} archivos de tamano {megas} MB";
                    listBox1.Items.Add(texto);

                }
                else
                {
                    string texto = $"solo caven {archivosQueCaben}archivos  de: {megas} MB, se excedio";
                    listBox1.Items.Add(texto);
                }





            }
            catch (FormatException)
            {
                MessageBox.Show(" porfavor ingresa numeros validos", "error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {

                MessageBox.Show("ocurrio un error" + ex.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            e1.Clear();
            e2.Clear();
        }
    }
}

