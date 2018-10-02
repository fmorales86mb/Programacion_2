using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private List<Alumno> alumnos;
        private short anio;
        private Divisiones division;
        private Profesor profesor;

        public string AnioDivision
        {
            get
            {
                return string.Format("{0}º{1}", this.anio.ToString(), this.division.ToString());
            }
        }

        private Curso()
        {
            alumnos = new List<Alumno>();
        }
        public Curso(short anio, Divisiones division, Profesor profesor): this()
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
        }

        public static explicit operator string(Curso c)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Anio y División: {0}\n", c.AnioDivision);
            sb.AppendLine();

            sb.AppendLine("Profesor:");
            sb.Append(c.profesor.ExponerDatos());
            sb.AppendLine("Alumnos:\n");

            foreach (Alumno a in c.alumnos)
            {
                sb.Append(a.ExponerDatos());
            }

            return sb.ToString();          
        }
        public static bool operator == (Curso c, Alumno a)
        {
            return (c.AnioDivision == a.AnioDivision);
        }
        public static bool operator != (Curso c, Alumno a)
        {
            return !(c == a);
        }
        public static Curso operator +(Curso c, Alumno a)
        {
            if (c == a)
                c.alumnos.Add(a);

            return c;
        }


    }
}
