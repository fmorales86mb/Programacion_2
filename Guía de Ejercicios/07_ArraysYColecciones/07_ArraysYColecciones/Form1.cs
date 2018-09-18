using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblioColecciones;

namespace _07_ArraysYColecciones
{
    public partial class frmDiccionario : Form
    {       
        public frmDiccionario()
        {
            InitializeComponent();            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            
        }

        private Dictionary<string, int> LevantarPalabras(string texto)
        {
            Dictionary<string, int> diccionario = new Dictionary<string, int>();
            string[] palabras = texto.Split(' ');

            for(int i = 0; i<palabras.Length; i++)
            {
                if (diccionario.ContainsKey(palabras[i])) diccionario[palabras[i]]++;
                else diccionario.Add(palabras[i], 1);                
            }

            return diccionario;
        }

        private Dictionary<string, int> OrdenarDiccionario(Dictionary<string, int> diccionario)
        {
            Dictionary<string, int>.KeyCollection keys = diccionario.Keys;
            
        }
    }
}
