using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FrmCentralita
{
    public partial class frmMenu : Form
    {
        private Centralita central;

        public frmMenu()
        {
            InitializeComponent();           
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            frmLlamador llamador = new frmLlamador();
            llamador.ShowDialog(this);
        }
    }
}
