using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// para archivos txt.
using System.IO;

namespace Ejercicio_56
{
    public partial class frmPrincipal : Form
    {
        private string pathFile;

        public frmPrincipal()
        {
            InitializeComponent();
            pathFile = string.Empty;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirArchivoTxt();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!GuardarArchivoTxt())
                GuardarComoArchivoTxt();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarComoArchivoTxt();
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            MostrarCaracteres();
        }

        /// <summary>
        /// Cuenta sólo la cantidad de caracteres del texto, sin espacios, y los muestra en el StripStatus.
        /// </summary>
        private void MostrarCaracteres()
        {
            string txtAux = richTextBox.Text.Trim();
            int caracteres = txtAux.Length;
            string txtCaracteres = string.Format("{0} caracteres", caracteres.ToString());
            toolStripStatusCaracteres.Text = txtCaracteres;
        }

        /// <summary>
        /// Abre un archivo txt seleccionado por el usuario e imprime el texto en pantalla.
        /// </summary>
        private void AbrirArchivoTxt()
        {
            StreamReader reader;            

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pathFile = openFileDialog.FileName;

                reader = File.OpenText(pathFile);
                richTextBox.Text = reader.ReadToEnd();

                reader.Close();
            }
        }

        /// <summary>
        /// Guarda el txt en un archivo si es que se había abierto uno. 
        /// </summary>
        /// <returns>True si guardó, False si no</returns>
        private bool GuardarArchivoTxt()
        {
            bool guardado = false;

            if (File.Exists(pathFile))
            {
                StreamWriter writer = new StreamWriter(pathFile);
                writer.Write(richTextBox.Text);
                writer.Close();
                guardado = true;
            }

            return guardado;            
        }

        /// <summary>
        /// Guarda el texto en un archivo.
        /// </summary>
        /// <param name="path">Ruta del archivo.</param>
        /// <returns>True si abrió, False si no.</returns>
        private bool GuardarArchivoTxt(string path)
        {
            bool guardado = false;

            
            
                StreamWriter writer = new StreamWriter(path);
                writer.Write(richTextBox.Text);
                writer.Close();
                guardado = true;
            

            return guardado;
        }

        /// <summary>
        /// Guarda el txt en un archvio en la ubicacion y con el nombre que decida el usuario.
        /// </summary>
        private void GuardarComoArchivoTxt()
        {            
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {                
                pathFile = saveFileDialog.FileName;
                GuardarArchivoTxt(pathFile);                
            }
        }
    }
}
