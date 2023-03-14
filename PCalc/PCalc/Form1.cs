using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCalc
{
    public partial class Form1 : Form
    { double vNum1, vNum2, resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void Txt2_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(Txt2.Text, out vNum2))
            {
                MessageBox.Show("Insira um valor válido");
            }
        }

        private void Btn3_Click(object sender, EventArgs e)

        {
            resultado = vNum1 + vNum2;
            Txt3.Text = resultado.ToString("N2");

            if (!Double.TryParse(Txt1.Text, out vNum1))
            {
                MessageBox.Show("Insira um valor válido");
                Txt1.Focus();

                resultado = vNum1 + vNum2;
                Txt3.Text = resultado.ToString("N2");
            }
            if (!Double.TryParse(Txt2.Text, out vNum2))
            {
                MessageBox.Show("Insira um valor válido");
                Txt1.Focus();

                resultado = vNum1 + vNum2;
                Txt3.Text = resultado.ToString("N2");
            }

        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            resultado = vNum1 - vNum2;
            Txt3.Text = resultado.ToString("N2");

            if (!Double.TryParse(Txt1.Text, out vNum1))
            {
                MessageBox.Show("Primeiro valor inválido");
                Txt1.Focus();

                resultado = vNum1 - vNum2;
                Txt3.Text = resultado.ToString("N2");
            }
            if (!Double.TryParse(Txt2.Text, out vNum2))
            {
                MessageBox.Show("Segundo valor inválido");
                Txt2.Focus();

                resultado = vNum1 - vNum2;
                Txt3.Text = resultado.ToString("N2");
            }

        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            resultado = vNum1 * vNum2;
            Txt3.Text = resultado.ToString("N2");

            if (!Double.TryParse(Txt1.Text, out vNum1))
            {
                MessageBox.Show("Segundo valor inválido");
                Txt1.Focus();

                resultado = vNum1 * vNum2;
                Txt3.Text = resultado.ToString("N2");
            }
            if (!Double.TryParse(Txt2.Text, out vNum2))
            {
                MessageBox.Show("Segundo valor inválido");
                Txt2.Focus();

                resultado = vNum1 * vNum2;
                Txt3.Text = resultado.ToString("N2");
            }

        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            resultado = vNum1 / vNum2;
            Txt3.Text = resultado.ToString("N2");

            if (!Double.TryParse(Txt1.Text, out vNum1))
            {
                MessageBox.Show("Segundo valor inválido");
                Txt1.Focus();

                resultado = vNum1 / vNum2;
                Txt3.Text = resultado.ToString("N2");
            }
            if (!Double.TryParse(Txt2.Text, out vNum2))
            {
                MessageBox.Show("Segundo valor inválido");
                Txt2.Focus();

                resultado = vNum1 / vNum2;
                Txt3.Text = resultado.ToString("N2");
            }
            if (vNum2 == 0)
            { MessageBox.Show("Impossivel dividir por 0!");
                Txt1.Focus();
            }
        }

        private void Txt1_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(Txt1.Text, out vNum1))
            {
                MessageBox.Show("Insira um valor válido");
            }
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Txt1.Clear();
            Txt2.Clear();
            Txt3.Clear();
        }
    }
}
