using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora{
    public partial class btnsuma : Form    {
        double primero;
        double segundo;
        double resultado;
        string operacion;
        public btnsuma(){
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + ".";
        }

        private void ntnsuma_Click(object sender, EventArgs e)
        {
            operacion = "+";
                primero = double.Parse(pantalla.Text);
                pantalla.Clear();
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void btnmultiplica_Click(object sender, EventArgs e)
        {
            operacion = "*";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            operacion = "/";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }
            private void button10_Click(object sender, EventArgs e)
        {

            segundo = double.Parse(pantalla.Text);
                      

                
            switch (operacion){
                case "+":
                    resultado = primero+segundo;
                    pantalla.Text = resultado.ToString();
                    break;

                case "-":
                    resultado = primero-segundo;
                    pantalla.Text = resultado.ToString();
                    break;
        
                case "/":
                    resultado = primero/segundo;
                    pantalla.Text = resultado.ToString();
                    break;

                case "*":
                    resultado = primero * segundo;
                    pantalla.Text = resultado.ToString();
                    break;
            }
        }

            private void button11_Click(object sender, EventArgs e)
            {
                pantalla.Clear();
            }
    }
}
