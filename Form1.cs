using System;

namespace practica_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double pi = 3.141592;
            double radio1, area1, volumen1;
            radio1 = double.Parse(radioCirc.Text);
            area1 = 4 * pi * radio1 * radio1;
            volumen1 = 4 / 3 * pi * Math.Pow(radio1, 3);
            areaCirc.Text = area1.ToString();
            VolumenCirc.Text = volumen1.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}