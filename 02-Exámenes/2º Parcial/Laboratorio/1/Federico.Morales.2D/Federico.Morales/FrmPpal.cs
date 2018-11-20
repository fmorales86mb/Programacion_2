using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Federico.Morales
{
    public partial class FrmPpal : Form
    {
        private LosHilos hilos;

        public FrmPpal()
        {
            InitializeComponent();
            hilos = new LosHilos();
            hilos.avisoFin += this.MostrarMensajeFin;
        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            try
            {
                this.hilos += 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.hilos.Bitacora);
        }

        public void MostrarMensajeFin(string mensaje)
        {
            MessageBox.Show(mensaje);
        }
    }
}
