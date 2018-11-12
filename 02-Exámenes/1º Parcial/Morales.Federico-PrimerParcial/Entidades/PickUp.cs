using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PickUp : Vehiculo
    {
        private string modelo;
        private static int valorHora;

        static PickUp()
        {
            PickUp.valorHora = 70;
        }
        public PickUp(string patente, string modelo) : base(patente)
        {
            this.modelo = modelo;
        }
        public PickUp(string patente, string modelo, int valorHora): this(patente, modelo)
        {
            PickUp.valorHora = valorHora;
        }

        /// <summary>
        /// Retorna todos los datos de la PickUp.
        /// </summary>
        /// <returns></returns>
        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ImprimirTicket());
            sb.AppendLine("Modelo: " + this.modelo);
            sb.AppendLine("Valor por Hora: " + PickUp.valorHora.ToString());

            return sb.ToString();
        }
        /// <summary>
        /// Evalua si el objeto pasado como parámetro es del tipo PickUp.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return (obj is PickUp);
        }
        /// <summary>
        /// Retorna todos los datos de la PickUp y agrega el costo de la estadía.
        /// </summary>
        /// <returns></returns>
        public override string ImprimirTicket()
        {
            TimeSpan dif = DateTime.Now - this.ingreso;
            int difHoras = dif.Hours;
            int costoEstadia = difHoras * PickUp.valorHora;

            StringBuilder sb = new StringBuilder();

            sb.Append(this.ConsultarDatos());
            sb.AppendLine("Costo de Estadía: " + costoEstadia.ToString());

            return sb.ToString();
        }
    }
}
