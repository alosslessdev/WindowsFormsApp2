using Lab_3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Carrasco, Nathan
//Herrera, Francisco
//Wu, Iván

namespace Laboratorio3
{
    public partial class Problema2Form1 : Form
    {

        private ErrorProvider errorProvider = new ErrorProvider();

        public Problema2Form1()
        {
            InitializeComponent();
        }

        private static int i, j, y, x, numeroAlRevesInt, numeroAlDerechoInt, resultado1, resultado2;
        private string numeroAlRevesString, numeroAlDerechoString, inicioDerecha, inicioIzquierda;

        private void botonVer_Click(object sender, EventArgs e)
        {
            try
            {

                for (i = 0; i <= Convert.ToInt32(txtNumero.Text); i++)
                {
                    //para cada numero natural hasta el numero del usuario


                    if (VerificarPalindromo(i))
                    {
                        listaResultado.Items.Add(i);
                    }

                }
            }
            catch {
                errorProvider.SetError(txtNumero, "Solo se permiten letras.");

            }
        }

        static bool VerificarPalindromo(int numero)
        {
            int original = numero;
            int reverso = 0;

            while (numero > 0)
            {
                int digito = numero % 10;
                reverso = reverso * 10 + digito;
                numero /= 10;
            }

            return original == reverso;
        }
    }
}
