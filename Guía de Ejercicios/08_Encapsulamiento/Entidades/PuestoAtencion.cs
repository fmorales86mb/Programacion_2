using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Puesto
    {
        Caja1,
        Caja2
    }

    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        public static int NumeroActual { get => numeroActual++; }        

        public bool Atender(Cliente cli)
        {
            Thread.Sleep(1500);
            return true;
        }

        // Constructor de clase, necesariamente estatico y sin modificadores de acceso.
        static PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }
    }
}
