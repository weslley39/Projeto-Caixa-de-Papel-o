using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private double convetOnePlace(double number)
        {
            return Math.Truncate(10 * number) / 10;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double areaTotal = Convert.ToInt32(txtAreaTotal.Text);
            double largura = Math.Sqrt(areaTotal);
            double altura = 0;
            double lado = 0;

            //var largura1 = Math.Pow(areaTotal, 2);
            //var largura3 = ( areaTotal * 2) * 2;

            //var linha3 = (4 * 3) - (largura3 * 2) + areaTotal;

            //var valorA = (4 * 3) / (areaTotal / 2);
            //var valorB = (largura3 * 2) / (areaTotal / 2);
            //var valorC = largura1 / (areaTotal / 2);

            //var delta1 = (Math.Pow(valorB, 2) - (4 * valorA * valorC));
            //var x1     = (valorB + Math.Sqrt(delta1)) / 2 * valorA;

            //var delta2 = (Math.Pow(valorB, 2) - (4 * valorA * valorC));
            //var x2     = (valorB - Math.Sqrt(delta2)) / 2 * valorA;

            //var resposta1 = (2 * x1) - (2 * x2);
            //var resposta2 = Math.Sqrt(resposta1);

            double distributiva1 = Math.Pow(largura, 2);
            double distributiva2 = largura * (-2);
            double distributiva3 = (-2) * (largura);
            double distributiva4 = -2 * -2;

            double valorA = distributiva4 * 3;
            double valorB = (distributiva2 + distributiva3) * 2;
            double valorC = distributiva1;

            double delta = Math.Pow(valorB, 2) - (4 * valorA * valorC);
            double valorX1 = ((valorB * -1) + Math.Sqrt(delta)) / (2 * valorA);
            double valorX2 = ((valorB * -1) - Math.Sqrt(delta)) / (2 * valorA);

            double resultado1 = largura - (2 * convetOnePlace(valorX1));
            double resultado2 = largura - (2 * convetOnePlace(valorX2));

            if (resultado1 > resultado2)
            {
                lado = resultado1;
                altura = convetOnePlace(valorX1);
            }
            else
            {
                lado = resultado2;
                altura = convetOnePlace(valorX2);
            }


            txtArea.Text = areaTotal.ToString();
            txtLargura2.Text = areaTotal.ToString();
            txtLargura.Text = largura.ToString();
            txtX1.Text = convetOnePlace(valorX1).ToString("0.##");
            txtX2.Text = convetOnePlace(valorX2).ToString("0.##");
            txtLado.Text = lado.ToString("0.##");
            txtAltura.Text = altura.ToString("0.##");
        }

        private void txtAreaTotal_Leave(object sender, EventArgs e)
        {
            int areaTotal = Convert.ToInt32(txtAreaTotal.Text);

        }

        private void txtAreaTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
