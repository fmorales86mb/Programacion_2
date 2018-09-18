using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using biblioClase8;

namespace Clase8
{
    public partial class btnCreaProductos : Form
    {
        public btnCreaProductos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto prod1 = new Producto(1, "teclado", 32.5);
            Producto prod2 = new Producto(2, "mouse", 50.5);

            Factura factura = new Factura();
            factura[1] = prod1;
            factura[2] = prod2;
            factura.Moneda = TipoMoneda.Dolar;
            txtTotal.Text = factura.Total.ToString();
            
        }
    }
}
