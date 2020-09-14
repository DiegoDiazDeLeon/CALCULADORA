using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public List<string> lista = new List<string>();
        Calcula calcula = new Calcula();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void Bot1_Click(object sender, EventArgs e)
        {
            textBox2.Text = Bot1.Text;
            lista.Add("1");
        }

        private void Bot2_Click(object sender, EventArgs e)
        {
            textBox2.Text = Bot2.Text;
            lista.Add("2");
        }

        private void Bot3_Click(object sender, EventArgs e)
        {
            textBox2.Text = Bot3.Text;
            lista.Add("3");
        }

        private void Bot4_Click(object sender, EventArgs e)
        {
            textBox2.Text = Bot4.Text;
            lista.Add("4");
        }

        private void Bot5_Click(object sender, EventArgs e)
        {
            textBox2.Text = Bot5.Text;
            lista.Add("5");
        }

        private void Bot6_Click(object sender, EventArgs e)
        {
            textBox2.Text = Bot6.Text;
            lista.Add("6");
        }

        private void Bot7_Click(object sender, EventArgs e)
        {
            textBox2.Text = Bot7.Text;
            lista.Add("7");
        }

        private void Bot8_Click(object sender, EventArgs e)
        {
            textBox2.Text = Bot8.Text;
            lista.Add("8");
        }

        private void Bot9_Click(object sender, EventArgs e)
        {
            textBox2.Text = Bot9.Text;
            lista.Add("9");
        }

        private void Bot0_Click(object sender, EventArgs e)
        {
            textBox2.Text = Bot0.Text;
            lista.Add("0");
        }

        private void Mas_Click(object sender, EventArgs e)
        {
            textBox2.Text = Mas.Text;
            lista.Add(" + ");
        }

        private void Igual_Click(object sender, EventArgs e)
        {
            lista.Add(" = ");
            for (int i = 0; i < lista.Count; i++)
            {
                textBox1.Text += lista[i];
            }
        }

        private void Divi_Click(object sender, EventArgs e)
        {
            textBox2.Text = Divi.Text;
            lista.Add(" / ");
        }

        private void Menos_Click(object sender, EventArgs e)
        {
            textBox2.Text = Menos.Text;
            lista.Add(" - ");
        }

        private void Multi_Click(object sender, EventArgs e)
        {
            textBox2.Text = Multi.Text;
            lista.Add(" x ");
        }

        private void Cero_Click(object sender, EventArgs e)
        {
            lista.Clear();
            textBox1.Text = " ";
        }
    }
}
