
using System;
using System.Windows.Forms;

namespace Practica1_GifAnimado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "Hello, " + textBox1.Text + "!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, c, d;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = int.Parse(textBox3.Text);
            d = int.Parse(textBox4.Text);

            textBox5.Text = d.ToString();
            textBox6.Text = c.ToString();
            textBox7.Text = b.ToString();
            textBox8.Text = a.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float valor1 = float.Parse(textBox1.Text);
            float valor2 = float.Parse(textBox2.Text);
            float valor3 = valor1 * valor2 / 2;

            textBox3.Text = valor3.ToString();
        }
    }
}
