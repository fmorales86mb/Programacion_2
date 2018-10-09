using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public enum PeriodicidadDePagos
    {
        Mensual,
        Bimestral,
        Trimestral
    }
    public enum TipoDePrestamo
    {
        Pesos,
        Dolares,
        Todos
    }

    public abstract class Prestamo
    {
        protected float monto;
        protected DateTime vencimiento;

        public float Monto
        {
            get
            {
                return this.monto;
            }
        }
        public DateTime Vencimiento
        {
            get
            {
                return this.vencimiento;
            }
            set
            {
                this.vencimiento = DateTime.Compare(value, DateTime.Now) > 0 ? value : DateTime.Now;                
            }
        }

        public Prestamo(float monto, DateTime vencimiento)
        {
            this.monto = monto;
            this.Vencimiento = vencimiento;
        }
        public abstract void ExtenderPlazo(DateTime nuevoVencimiento);
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine("Monto: " + this.Monto);
            sb.AppendLine("Vencimiento: " + this.Vencimiento);

            return sb.ToString();
        }
        public static int OrdenarPorFecha(Prestamo p1, Prestamo p2)
        {
            return DateTime.Compare(p1.Vencimiento, p2.Vencimiento);            
        }
    }
}
