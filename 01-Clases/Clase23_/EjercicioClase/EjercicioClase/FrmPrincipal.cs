using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioClase
{
    // afuera de las clases para que sea visible para todas las clases del namespace
    public delegate void mensaje(string texto); 

    public partial class FrmPrincipal : Form
    {
        

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm1 form1 = new Frm1();
            form1.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm2 frm2 = new Frm2();

            foreach(Form f in this.OwnedForms)
            {
                if (f is Frm1)
                {
                    ((Frm1)f).miEvento += frm2.CopiarTxt;
                }
            }

            frm2.Show(this);
        }
    }


}

