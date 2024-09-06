using Lab_3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
	
//Carrasco, Nathan
//Herrera, Francisco
//Wu, Iván
	
    public partial class Problema1 : Form

    {

        private ErrorProvider errorProvider = new ErrorProvider();
        public Problema1()
        {
            InitializeComponent();
        }

        private void btMostrarVocales_Click(object sender, EventArgs e)
        {
            if (tbPalabra.TextLength == 0)
            {
                MessageBox.Show("No se ha ingresado ninguna palabra");
                return;
            }
            //El contenido de lbVoales se limpia si este cuenta con informacion.
            lbVocales.Items.Clear();

            string palabra = tbPalabra.Text;
            string vocales = "aeiouAEIOU";

            for (int i = 0; i < palabra.Length; i++)
            {
                char letra = palabra[i];
                if (vocales.Contains(letra))
                {
                    lbVocales.Items.Add(letra);

                }
            }
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            lbVocales.Items.Clear();
            tbPalabra.Clear();
        }

        private void tbPalabra_TextChanged(object sender, EventArgs e)
        {
            string entrada = tbPalabra.Text;

            // Regex permite unicamente el uso de letras, excluye el uso de numeros y caracters especiales.
            if (!Regex.IsMatch(entrada, @"^[a-zA-Z]*$"))
            {
                errorProvider.SetError(tbPalabra, "Solo se permiten letras.");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void Problema1_Load(object sender, EventArgs e)
        {
            Problema2Form1 problema2Form1 = new Problema2Form1();
            problema2Form1.Show();
            LbLab3 lbLab3 = new LbLab3();
            lbLab3.Show();

        }
    }
}