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

namespace VistaForm
{
    public partial class frmVistaCurso : Form
    {
        private Curso Curso;

        public frmVistaCurso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Divisiones division;
            Enum.TryParse<Divisiones>(cbAlumnoDivisiones.SelectedValue.ToString(), out division);

            Profesor profesor = new Profesor(
                txtProfesorNombre.Text,
                txtProfesorApellido.Text,
                txtProfesorDni.Text,
                dateProfesorIngreso.Value);
            
            Curso = new Curso(
                (short)numCursoAnio.Value,
                //(Divisiones)cbCusroDivisiones.SelectedItem,
                division,
                profesor);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (object.ReferenceEquals(Curso, null))
            {
                MessageBox.Show("No existe Curso para mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                rtxtCurso.Text = (string)Curso;
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(!(object.ReferenceEquals(Curso, null)))
            {
                Divisiones division; 
                Enum.TryParse<Divisiones>(cbAlumnoDivisiones.SelectedValue.ToString(), out division);

                Alumno alumno = new Alumno(
                    txtAlumnoNombre.Text,
                    txtAlumnoApellido.Text,
                    txtAlumnoLegajo.Text,
                    (short)numAlumnoAnio.Value,
                    division);
                    //(Divisiones)cbAlumnoDivisiones.SelectedItem);

                Curso = Curso + alumno;
            }
        }

        private void frmVistaCurso_Load(object sender, EventArgs e)
        {
            cbCusroDivisiones.DataSource = Enum.GetValues(typeof(Divisiones));
            cbAlumnoDivisiones.DataSource = Enum.GetValues(typeof(Divisiones));
        }
    }
}
