using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class lbLab3 : Form
    {
        public lbLab3()
        {
            InitializeComponent();

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            //verificar que completen todos los cuadros
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCedula.Text) || string.IsNullOrWhiteSpace(txtDepositar.Text))
            {
                MessageBox.Show("Complete todos los campos para poder seguir.");
                return;

            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            // Convertir todo el texto a mayúsculas y eliminar caracteres que no sean letras
            txtNombre.Text = new string(txtNombre.Text.Where(char.IsLetter).ToArray()).ToUpper();
            // Mover el cursor al final del texto
            txtNombre.SelectionStart = txtNombre.Text.Length;
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDepositar_TextChanged(object sender, EventArgs e)
        {

            // Verificar que solo se ingresen números
            if (!decimal.TryParse(txtDepositar.Text, out _))
            {
                MessageBox.Show("Por favor, ingrese solo números.");
                txtDepositar.Text = ""; // Limpiar el campo si hay un valor inválido
            }



        }
    }
}
