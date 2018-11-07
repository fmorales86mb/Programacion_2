using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioColecciones
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.EnCompetencia = false;
            this.VueltasRestantes = 0;
            this.CantidadCombustible = 0;
        }

        public short CantidadCombustible { get => cantidadCombustible; set => cantidadCombustible = value; }
        public bool EnCompetencia { get => enCompetencia; set => enCompetencia = value; }
        public short VueltasRestantes { get => vueltasRestantes; set => vueltasRestantes = value; }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Escudería: " + this.escuderia);
            sb.AppendLine("Nro: " + this.numero.ToString());
            sb.AppendLine("Compitiendo " + this.EnCompetencia.ToString());
            sb.AppendLine("Vueltas Restantes: " + this.VueltasRestantes.ToString());
            sb.AppendLine("Cantidad de Combustible: " + this.CantidadCombustible.ToString());
            sb.AppendLine();
            return sb.ToString();
        }

        public static bool operator ==(AutoF1 auto1, AutoF1 auto2)
        {
            return (auto1.numero == auto2.numero && auto1.escuderia == auto2.escuderia);
        }

        public static bool operator !=(AutoF1 auto1, AutoF1 auto2)
        {
            return !(auto1 == auto2); 
        }
    }
}
