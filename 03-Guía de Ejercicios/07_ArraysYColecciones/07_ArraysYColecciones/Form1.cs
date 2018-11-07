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
            Dictionary<string, int> diccionario = LevantarPalabras(rtxtDiccionario.Text);
            diccionario = OrdenarDiccionario(diccionario);
            List<string> keys = diccionario.Keys.ToList();

            string mensaje = string.Format("1º '{0}' con {1} apariciones. \n2º '{2}' con {3} apariciones. \n3º '{4}' con {5} apariciones.", keys[0], diccionario[keys[0]],
                keys[1], diccionario[keys[1]], keys[2], diccionario[keys[2]]);

            MessageBox.Show(mensaje, "Top 3");
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
            List<int> listaValues = diccionario.Values.ToList();
            List<string> listaKeys = diccionario.Keys.ToList();
            Dictionary<string, int> SortDicc = new Dictionary<string, int>();
            int valueAux;
            string keyAux;

            for(int i = 0; i<listaValues.Count - 1; i++)
            {
                for(int j=i+1; j<listaValues.Count; j++)
                {
                    if (listaValues[i]<listaValues[j])
                    {
                        valueAux = listaValues[i];
                        listaValues[i] = listaValues[j];
                        listaValues[j] = valueAux;

                        keyAux = listaKeys[i];
                        listaKeys[i] = listaKeys[j];
                        listaKeys[j] = keyAux;
                    }
                }
            }

            for (int i = 0; i<listaKeys.Count; i++)
            {
                SortDicc.Add(listaKeys[i], listaValues[i]);
            }

            return SortDicc;
        }
    }
}
