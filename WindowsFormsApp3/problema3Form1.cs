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
    public partial class LbLab3 : Form
    {
        public LbLab3()
        {
            InitializeComponent();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            // Verificar que todos los cuadros estén completos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCedula.Text) || string.IsNullOrWhiteSpace(txtDepositar.Text))
            {
                MessageBox.Show("Complete todos los campos para poder seguir.");
                return;
            }

            // Verificar que el monto a depositar sea de 2000.00 o mayor
            if (decimal.TryParse(txtDepositar.Text, out decimal montoDeposito))
            {
                if (montoDeposito < 2000.00m)
                {
                    MessageBox.Show("El mínimo para abrir la cuenta es de B/2000.00");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un monto válido.");
                return;
            }

            // Verificar la entrada de plazo (en meses) en el TextBox
            if (!int.TryParse(txtPlazo.Text, out int meses) || (meses != 12 && meses != 24 && meses != 36 && meses != 48 && meses != 60))
            {
                MessageBox.Show("Ingrese un plazo válido (12, 24, 36, 48 o 60 meses).");
                return;
            }

            // Obtener la tasa de interés anual según el plazo
            decimal tasaInteresAnual = ObtenerTasaInteres(meses);

            // Calcular el monto acumulado usando la fórmula de interés compuesto A = P * (1 + r)^n
            int anios = meses / 12; // Convertir meses a años
            decimal tasaInteresPeriodo = tasaInteresAnual / 100; // Convertir la tasa a decimal
            decimal montoAcumulado = montoDeposito * (decimal)Math.Pow((double)(1 + tasaInteresPeriodo), anios);

            // Mostrar el monto acumulado
            MessageBox.Show($"El monto acumulado al final de {meses} meses será de B/{montoAcumulado:F2}");
        }


        private decimal ObtenerTasaInteres(int meses)
        {
            switch (meses)
            {
                case 12: return 4m;
                case 24: return 4.5m;
                case 36: return 4.55m;
                case 48: return 4.75m;
                case 60: return 5m;
                default: return 0m; // Caso por defecto
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            // Convertir todo el texto a mayúsculas y eliminar caracteres que no sean letras
            txtNombre.Text = new string(txtNombre.Text.Where(char.IsLetter).ToArray()).ToUpper();
            // Mover el cursor al final del texto
            txtNombre.SelectionStart = txtNombre.Text.Length;
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

        private void LbLab3_Load(object sender, EventArgs e)
        {

        }
    }
}
