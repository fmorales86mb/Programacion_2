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
        private string StrExpresionDecimal = @"^\-*\d+\.?\d*$";
        private string StrExpresionBinaria = "";
        Regex ExpresionDecimal;

        public frmConversor()
        {
            InitializeComponent();            
        }

        private void btnBinToDec_Click(object sender, EventArgs e)
        {

        }

        private void btnDecToBin_Click(object sender, EventArgs e)
        {

        }

        private bool ValidateTxt(string strVal, bool isBin)
        {
            bool esValido = false;

            return esValido;
        }
    }
}
