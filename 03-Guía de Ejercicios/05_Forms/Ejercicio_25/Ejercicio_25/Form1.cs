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
using ConversorNumerico;

namespace Ejercicio_25
{
    public partial class frmConversor : Form
    {
        private const string StrPatronDecimal = @"^\-*\d+\,?\d*$"; //coma de separador
        private const string StrPatronBinario = @"^\-*[10]+\.?[10]*$";

        public frmConversor()
        {
            InitializeComponent();
        }

        private void btnBinToDec_Click(object sender, EventArgs e)
        {
            string strDec = ValidateTxt(txtBinario.Text, true) ?
                (Conversor.BinarioDecimal(txtBinario.Text)).ToString() :
                string.Empty;

            txtResultadoDec.Text = strDec;
        }

        private void btnDecToBin_Click(object sender, EventArgs e)
        {
            double nro;

            string strBin = ValidateTxt(txtDecimal.Text, false) ?
                Conversor.DecimalBinario(double.TryParse(txtDecimal.Text, out nro) ? nro : 0) :
                string.Empty;

            txtResultadoBin.Text = strBin;
        }

        /// <summary>
        /// Valida si el string cumple con el patron de bin o dec.
        /// </summary>
        /// <param name="strVal">String a evaluar.</param>
        /// <param name="isBin">True si se evalua como Binario. False si se evalua como Decimal</param>
        /// <returns>True si es válido.</returns>
        private bool ValidateTxt(string strVal, bool isBin)
        {
            string patron = isBin ? StrPatronBinario : StrPatronDecimal;
            Regex expresion = new Regex(patron);
            return expresion.IsMatch(strVal);
        }
    }
}
