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
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
            // asigno un manejador inocuo para que se construya el evento. Sino rompe al ser llamado sin asignacion.
            miEvento += this.Dummy;
        }

        // evento del tipo del delegado creado a nivel namespace.
        public event mensaje miEvento;
       
        /// <summary>
        /// Método que no hace nada.
        /// </summary>
        /// <param name="mje">respeta la firma del delegado.</param>
        public void Dummy(string mje)
        { }

        private void btnLlenar_Click(object sender, EventArgs e)
        {
            // Hacen lo mismo. Lanza el evento.
            //miEvento(this.textBox1.Text);

            // lanzo el evento. lo van a tomar todos los métodos que fueron sumados al evento.
            miEvento.Invoke(this.textBox1.Text);
            
        }
    }
}
