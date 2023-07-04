using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CalculadoraForm : Form
    {
        public CalculadoraForm()
        {
            InitializeComponent();
            OpcioncomboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CapturarDatos();
        }

        private void CapturarDatos()
        {
            decimal resultado = 0;
            decimal numero1 = Convert.ToDecimal(Numero1numericUpDown1.Value);
            decimal numero2 = Convert.ToDecimal(Numero2numericUpDown1.Value);

            try
            {
                switch (OpcioncomboBox1.SelectedIndex)
                {
                    case 0:
                        resultado = numero1 + numero2; //sumando los numeros
                        break;
                    case 1:
                        resultado = numero1 - numero2; //restando los numeros
                        break;
                    case 2:
                        resultado = numero1 * numero2; //multiplacion los numeros
                        break;
                    case 3:
                        resultado = numero1 / numero2; //division los numeros
                        break;

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error 0." + e.Message);
               
            }
           

            Resultadolabel4.Text = "RESULTADO ES:"+resultado.ToString();
        }

        private void OpcioncomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapturarDatos();
        }
    }
}
