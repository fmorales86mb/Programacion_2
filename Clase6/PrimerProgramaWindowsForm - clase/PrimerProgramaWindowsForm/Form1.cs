using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerProgramaWindowsForm
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Hola Mundo","titulo",
                MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) ==DialogResult.Yes)
            {

                this.btnSalir.Text = "Si";
            }
            else {
                this.btnSalir.Text = "No";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing
            (object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Esta seguro", " Guardar", 
                MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            FrmOwner frmOwner = new FrmOwner();
            FrmPantalla2 frmPantalla2 = new FrmPantalla2();
            FrmPantalla2 frmPantalla3 = new FrmPantalla2();
            FrmPantalla2 frmPantalla4 = new FrmPantalla2();
            frmOwner.Show();
            frmPantalla4.MdiParent = this;
            frmPantalla4.Show();
            frmPantalla2.Show(frmOwner);
            frmPantalla3.Show();
            this.btnMostrar.Text =  frmPantalla2.atributoString;

            frmPantalla2.Owner.Text = ""                ;
            

        }
    }
}
