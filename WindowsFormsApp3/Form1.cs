using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int i, j, y, x, numeroAlRevesInt, numeroAlDerechoInt, resultado1, resultado2;
        private int[] arregloOriginal;
        private int[] arregloCopia;

        private string entrada, numeroAlRevesString, numeroAlDerechoString;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (i = 0; i == Convert.ToInt32(textBox1.Text); i++) {
                //para cada numero natural hasta el numero del usuario

                for (j = 0; j == textBox1.TextLength; j++)
                {
                    numeroAlDerechoString = String.Join("", textBox1.Text[j]);

                    resultado1 = Convert.ToInt32(numeroAlDerechoString);

                }

                for (x = textBox1.TextLength; x == 0; x--)
                {

                   numeroAlRevesString = String.Join ("", textBox1.Text[x]);

                   resultado2 = Convert.ToInt32(numeroAlRevesString);


                }

                if (resultado1 == resultado2) { 

                    listBox1.Items.Add(numeroAlDerechoString);
                    //no deberia importar si el numero sale de numeroAlDerechoString o de
                    //numeroAlRevesString
                
                }

            }
        }
    }
}
