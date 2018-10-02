using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmPantalla2
{
  public partial class frmPantalla2 : Form
  {

    public string atributoString = "Atributo string";

    public frmPantalla2()
    {
      InitializeComponent();
    }

    private void frmPantalla2_Load(object sender, EventArgs e)
    {
      // esto devuelve un resultado y por lo tanto se cierra.
      //this.DialogResult = DialogResult.Cancel;
    }
  }
}
