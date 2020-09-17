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
        bool inicio = true;
        string c = "!";
        double resultado = 0;
        string proc = "";
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cero.FlatStyle = FlatStyle.Standard;
            Cero.BackColor = Color.Red;
        }


        private void Bot1_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                Pantallax.Text = "";
                Pantallax.Text = "1";
                textBox1.Text = "1";
                inicio = false;
            }
            else
            {
                Pantallax.Text = Pantallax.Text + "1";
                textBox1.Text += "1";
                inicio = false;
            }
            Comprobar();
        }

        private void Bot2_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                Pantallax.Text = "";
                Pantallax.Text = "2";
                textBox1.Text = "2";
                inicio = false;
            }
            else
            {
                Pantallax.Text = Pantallax.Text + "2";
                textBox1.Text += "2";
                inicio = false;
            }
            Comprobar();
        }

        private void Bot3_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                Pantallax.Text = "";
                Pantallax.Text = "3";
                textBox1.Text = "3";
                inicio = false;
            }
            else
            {
                Pantallax.Text = Pantallax.Text + "3";
                textBox1.Text += "3";
                inicio = false;
            }
            Comprobar();
        }

        private void Bot4_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                Pantallax.Text = "";
                Pantallax.Text = "4";
                textBox1.Text = "4";
                inicio = false;
            }
            else
            {
                Pantallax.Text = Pantallax.Text + "4";
                textBox1.Text += "4";
                inicio = false;
            }
            Comprobar();
        }

        private void Bot5_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                Pantallax.Text = "";
                Pantallax.Text = "5";
                textBox1.Text = "5";
                inicio = false;
            }
            else
            {
                Pantallax.Text = Pantallax.Text + "5";
                textBox1.Text += "5";
                inicio = false;
            }
            Comprobar();
        }

        private void Bot6_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                Pantallax.Text = "";
                Pantallax.Text = "6";
                textBox1.Text = "6";
                inicio = false;
            }
            else
            {
                Pantallax.Text = Pantallax.Text + "6";
                textBox1.Text += "6";
                inicio = false;
            }
            Comprobar();
        }

        private void Bot7_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                Pantallax.Text = "";
                Pantallax.Text = "7";
                textBox1.Text = "7";
                inicio = false;
            }
            else
            {
                Pantallax.Text = Pantallax.Text + "7";
                textBox1.Text += "7";
                inicio = false;
            }
            Comprobar();
        }

        private void Bot8_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                Pantallax.Text = "";
                Pantallax.Text = "8";
                textBox1.Text = "8";
                inicio = false;
            }
            else
            {
                Pantallax.Text = Pantallax.Text + "8";
                textBox1.Text += "8";
                inicio = false;
            }
            Comprobar();
        }

        private void Bot9_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                Pantallax.Text = "";
                Pantallax.Text = "9";
                textBox1.Text = "9";
                inicio = false;
            }
            else
            {
                Pantallax.Text = Pantallax.Text + "9";
                textBox1.Text += "9";
                inicio = false;
            }
            Comprobar();
        }

        private void Bot0_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                Pantallax.Text = "";
                Pantallax.Text = "0";
                textBox1.Text = "0";
                inicio = false;
            }
            else
            {
                Pantallax.Text = Pantallax.Text + "0";
                textBox1.Text += "0";
                inicio = false;
            }
            Comprobar();
        }

        private void Mas_Click(object sender, EventArgs e)
        {
            c = "+";
            textBox1.Text += c;
            this.Pantallax.Clear();
            this.Pantallax.Focus();
        }

        private void Igual_Click(object sender, EventArgs e)
        {

            Pantallax.Text = Convert.ToString(resultado);
            textBox1.Clear();
            resultado = 0;
            c = "!";
        }

        private void Divi_Click(object sender, EventArgs e)
        {
            c = "/";
            textBox1.Text += c;
            this.Pantallax.Clear();
            this.Pantallax.Focus();
        }

        private void Menos_Click(object sender, EventArgs e)
        {
            c = "-";
            textBox1.Text += c;
            this.Pantallax.Clear();
            this.Pantallax.Focus();
        }

        private void Multi_Click(object sender, EventArgs e)
        {
            c = "x";
            textBox1.Text += c;
            this.Pantallax.Clear();
            this.Pantallax.Focus();
        }

        private void Cero_Click(object sender, EventArgs e)
        {
            
            Pantallax.Clear();
            textBox1.Clear();
            resultado = 0;
        }

        private void Comprobar()
        {
            
            switch (c)
            {
                case "+":
                    //textBox1.Text = Display.Text;
                    resultado = resultado + Convert.ToDouble(this.Pantallax.Text);
                    break;

                case "-":
                    resultado = resultado - Convert.ToDouble(this.Pantallax.Text);
                    break;

                case "x":
                    resultado = resultado * Convert.ToDouble(this.Pantallax.Text);
                    break;

                case "/":
                    resultado = resultado / Convert.ToDouble(this.Pantallax.Text);
                    break;
                case "!":
                    resultado = Convert.ToDouble(this.Pantallax.Text);
                    break;
                case "^":
                    double aux = resultado;
                    for (int i = 0; i < Convert.ToDouble(this.Pantallax.Text) - 1; i++)
                    {
                        aux *= resultado;
                    }
                    resultado = aux;
                    break;
                case "r":
                    Pantallax.Text += 2;
                    //double a = resultado;
                   
                   // a = Math.Sqrt(a);
                    //resultado = Math.Sqrt(Convert.ToDouble(this.Pantallax.Text));
                    resultado = 2;
                    break;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pote_Click(object sender, EventArgs e)
        {
            c = "^";
            textBox1.Text += c;
            this.Pantallax.Clear();
            this.Pantallax.Focus();
        }

        private void Raiz_Click(object sender, EventArgs e)
        {
            c = "r";
           // textBox1.Text += c;
            this.Pantallax.Clear();
            this.Pantallax.Focus();
        }
    }
}
