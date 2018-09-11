using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaSobrecarga;

namespace Conversor
{
    public partial class FrmConversor : Form
    {
        public FrmConversor()
        {
            InitializeComponent();
        }

        private void btnConvertorEuro_Click(object sender, EventArgs e)
        {
            //tomar valor
            string strValor = txtEuro.Text;
            double valor;
            Euro euro;

            //validar
            if (!string.IsNullOrEmpty(strValor) && double.TryParse(strValor, out valor))
            {
                euro = new Euro(valor);

                // convertir y asignar
                txtEuroDolar.Text = ((Dolar)euro).GetCantidad().ToString();
                txtEuroEuro.Text = euro.GetCantidad().ToString();
                txtEuroPeso.Text = ((Peso)euro).GetCantidad().ToString();
            }
        }

        private void btnConvertorDolar_Click(object sender, EventArgs e)
        {
            //tomar valor
            string strValor = txtDolar.Text;
            double valor;
            Dolar dolar;

            //validar
            if (!string.IsNullOrEmpty(strValor) && double.TryParse(strValor, out valor))
            {
                dolar = new Dolar(valor);

                // convertir y asignar
                txtDolarEuro.Text = ((Euro)dolar).GetCantidad().ToString();
                txtDolarDolar.Text = dolar.GetCantidad().ToString();
                txtDolarPeso.Text = ((Peso)dolar).GetCantidad().ToString();
            }
        }

        private void btnConvertorPeso_Click(object sender, EventArgs e)
        {
            //tomar valor
            string strValor = txtPeso.Text;
            double valor;
            Peso peso;

            //validar
            if (!string.IsNullOrEmpty(strValor) && double.TryParse(strValor, out valor))
            {
                peso = new Peso(valor);

                // convertir y asignar
                txtPesoEuro.Text = ((Euro)peso).GetCantidad().ToString();
                txtPesoPeso.Text = peso.GetCantidad().ToString();
                txtPesoDolar.Text = ((Dolar)peso).GetCantidad().ToString();
            }
        }
    }
}
