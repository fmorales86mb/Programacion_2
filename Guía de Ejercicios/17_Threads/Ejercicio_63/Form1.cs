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

namespace Ejercicio_63
{
    public partial class Form1 : Form
    {
        Thread tHora;

        public Form1()
        {
            InitializeComponent();
            lblHora.Text = DateTime.Now.ToString();
            tHora = new Thread(AsignarHora);
        }

        private void AsignarHora()
        {
            DateTime hora;

            while(true)
            {
                hora = DateTime.Now;
                Thread.Sleep(1000);
                MostrarHora(hora);
            }
        }

        private void MostrarHora(DateTime hora)
        {
            if(this.lblHora.InvokeRequired)
            {
                this.lblHora.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.lblHora.Text = hora.ToString();
                }
                );
            }
            else
            {
                this.lblHora.Text = hora.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tHora.Start();
        }
    }
}
