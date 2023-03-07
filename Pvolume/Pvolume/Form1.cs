using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pvolume
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        double altura, raio;
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox3_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox3.Text, out raio))
            {
                MessageBox.Show("Raio Inválido");
                textBox3.Focus();
            }
            else if (raio <= 0)
            {
                MessageBox.Show("O raio deve ser maior que zero.");
                textBox3.Focus();
            }
        }

        private void TextBox2_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox2.Text, out altura))
            {
                MessageBox.Show("Altura Inválida");
                textBox2.Focus();
            }
            else if (altura <= 0)
            {
                MessageBox.Show("A altura deve ser maior que zero.");
                textBox2.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
            {
                SendKeys.Send("{TAB}"); e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
            {
                SendKeys.Send("{TAB}"); e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double volume;
            volume = Math.PI * Math.Pow(raio, 2) * altura;
            textBox1.Text = volume.ToString("N2");
        }
    }
}
