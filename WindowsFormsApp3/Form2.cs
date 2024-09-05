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
    public partial class Form2 : Form
    {
        public Form2()
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

        
    }
} 