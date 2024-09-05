using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Problema2Form1 : Form
    {
        public Problema2Form1()
        {
            InitializeComponent();
        }

<<<<<<< HEAD:WindowsFormsApp3/Problema2Form1.cs
        private int i, j, y, x, numeroAlRevesInt, numeroAlDerechoInt, resultado1, resultado2;

        private void button1_Click(object sender, EventArgs e)
        {
            for (i = 0; i <= Convert.ToInt32(textBox1.Text); i++)
            {
                //para cada numero natural hasta el numero del usuario

                for (j = 0; j <= textBox1.TextLength-1; j++)
                {   //revisar numero desde indice 0/izquierda

                    numeroAlDerechoString = String.Join("", textBox1.Text[j]);
                    //unir todos los caracteres del textbox de izquierda a derecha

                    resultado1 = Convert.ToInt32(numeroAlDerechoString);

                }

                for (x = textBox1.TextLength-1; x >= 0; x--)
                {   //revisar numero desde el ultimo indice/derecha

                    numeroAlRevesString = String.Join("", textBox1.Text[x]);
                    //unir todos los caracteres del textbox de derecha a izquierda

                    resultado2 = Convert.ToInt32(numeroAlRevesString);


                }

                if (resultado1 == resultado2)
                {
                    //si se lee igual desde derecha y desde izquierda

                    listBox1.Items.Add(resultado1);
                    //no deberia importar si el numero sale de numeroAlDerechoString o de
                    //numeroAlRevesString

                }

            }
        }

        private int[] arregloOriginal;
        private int[] arregloCopia;

        private string entrada, numeroAlRevesString, numeroAlDerechoString;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

=======
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 nuevoForm = new Form2();
            nuevoForm.Show();
            this.Hide();
>>>>>>> c9d28b296167b1a6bd1660776324dc59d9d858a1:WindowsFormsApp3/Form1.cs
        }
    }
}
