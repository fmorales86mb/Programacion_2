using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MagnitudesTermicas;

namespace Conversor
{
    public partial class FrmConversor : Form
    {
        public FrmConversor()
        {
            InitializeComponent();
        }

        private void btnConvertorFahernheit_Click(object sender, EventArgs e)
        {
            //tomar valor
            string strValor = txtFahrenheit.Text;
            double valor;
            Fahrenheit f;

            //validar
            if (!string.IsNullOrEmpty(strValor) && double.TryParse(strValor, out valor))
            {
                f = new Fahrenheit(valor);

                // convertir y asignar
                txtFahrenheitCelsius.Text = Math.Round(((Celsius)f).GetGrados(), 2).ToString();
                txtFahrenheitFahrenheit.Text = Math.Round(f.GetGrados(), 2).ToString();
                txtFahrenheitKelvin.Text = Math.Round(((Kelvin)f).GetGrados(), 2).ToString();
            }
        }

        private void btnConvertorCelsius_Click(object sender, EventArgs e)
        {
            //tomar valor
            string strValor = txtCelsius.Text;
            double valor;
            Celsius c;

            //validar
            if (!string.IsNullOrEmpty(strValor) && double.TryParse(strValor, out valor))
            {
                c = new Celsius(valor);

                // convertir y asignar
                txtCelsiusFahrenheit.Text = Math.Round(((Fahrenheit)c).GetGrados(),2).ToString();
                txtClesiusCelsius.Text = Math.Round(c.GetGrados(),2).ToString();
                txtCelsiusKelvin.Text = Math.Round(((Kelvin)c).GetGrados(),2).ToString();
            }
        }

        private void btnConvertorKelvin_Click(object sender, EventArgs e)
        {
            //tomar valor
            string strValor = txtKelvin.Text;
            double valor;
            Kelvin k;

            //validar
            if (!string.IsNullOrEmpty(strValor) && double.TryParse(strValor, out valor))
            {
                k = new Kelvin(valor);

                // convertir y asignar
                txtKelvinCelsius.Text = Math.Round(((Celsius)k).GetGrados(),2).ToString();
                txtKelvinKelvin.Text = Math.Round(k.GetGrados(),2).ToString();
                txtKelvinFahrenheit.Text = Math.Round(((Fahrenheit)k).GetGrados(),2).ToString();
            }
        }
    }
}
