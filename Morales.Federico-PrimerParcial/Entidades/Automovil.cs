using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        private ConsoleColor color;
        private static int valorHora;

        static Automovil()
        {
            Automovil.valorHora = 50;
        }
        public Automovil(string patente, ConsoleColor color) : base(patente) 
        {
            this.color = color;
        }
        public Automovil(string patente, ConsoleColor color, int valorHora) : this(patente, color)
        {
            Automovil.valorHora = valorHora;
        }

        /// <summary>
        /// Retorna todos los datos del Automovil.
        /// </summary>
        /// <returns></returns>
        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ImprimirTicket());
            sb.AppendLine("Color: " + this.color.ToString());
            sb.AppendLine("Valor por Hora: " + Automovil.valorHora.ToString());

            return sb.ToString();
        }
        /// <summary>
        /// Evalua si el objeto pasado como parámetro es del tipo Automovil.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return (obj is Automovil);            
        }
        /// <summary>
        /// Retorna todos los datos del Automovil y agrega el costo de la estadía.
        /// </summary>
        /// <returns></returns>
        public override string ImprimirTicket()
        {
            TimeSpan dif = DateTime.Now - this.ingreso;
            int difHoras = dif.Hours;
            int costoEstadia = difHoras * Automovil.valorHora;

            StringBuilder sb = new StringBuilder();

            sb.Append(this.ConsultarDatos());
            sb.AppendLine("Costo de Estadía: " + costoEstadia.ToString());

            return sb.ToString();
        }
    }
}
