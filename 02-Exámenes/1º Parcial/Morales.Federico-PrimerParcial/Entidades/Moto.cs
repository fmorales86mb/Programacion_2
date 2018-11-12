using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        private int cilindrada;
        private short ruedas;
        private static int valorHora;

        static Moto()
        {
            Moto.valorHora = 30;
        }
        public Moto(string patente, int cilindrada) : base(patente)
        {
            this.cilindrada = cilindrada;
            this.ruedas = 2;
        }
        public Moto (string patente, int cilindrada, short ruedas):this(patente, cilindrada)
        {
            this.ruedas = ruedas;
        }
        public Moto(string patente, int cilindrada, short ruedas, int valorHora):this(patente, cilindrada, ruedas)
        {
            Moto.valorHora = valorHora;
        }

        /// <summary>
        /// Retorna todos los datos de la Moto.
        /// </summary>
        /// <returns></returns>
        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ImprimirTicket());
            sb.AppendLine("Cilindrada: " + this.cilindrada.ToString());
            sb.AppendLine("Ruedas: " + this.ruedas.ToString());
            sb.AppendLine("Valor por Hora: " + Moto.valorHora.ToString());

            return sb.ToString();
        }
        /// <summary>
        /// Evalua si el objeto pasado como parámetro es del tipo Moto.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {                            
            return (obj is Moto);
        }
        /// <summary>
        /// Retorna todos los datos de la Moto y agrega el costo de la estadía.
        /// </summary>
        /// <returns></returns>
        public override string ImprimirTicket()
        {
            TimeSpan dif = DateTime.Now - this.ingreso;
            int difHoras = dif.Hours;
            int costoEstadia = difHoras * Moto.valorHora;

            StringBuilder sb = new StringBuilder();

            sb.Append(this.ConsultarDatos());
            sb.AppendLine("Costo de Estadía: " + costoEstadia.ToString());

            return sb.ToString();
        }
    }
}
