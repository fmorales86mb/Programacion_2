using Clases;
using System;
using System.Windows.Forms;

namespace PreParcialLabo_II
{
    public partial class Form1 : Form
    {
        private Tren trenes;

        public Form1()
        {
            InitializeComponent();
            trenes = new Tren();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trenes.EventoArribo += this.InformarArribo;
        }

        private void btnArrancarTren_Click(object sender, EventArgs e)
        {            
            try
            {                                
                trenes += (int)this.numericUpDown1.Value;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnArribos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(trenes.VerTren());
        }

        private void InformarArribo(string mensaje)
        {
            MessageBox.Show(mensaje);
        }
    }
}
