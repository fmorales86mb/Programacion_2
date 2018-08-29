using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaObjetos
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100; // ver si debería ser un atributo estático
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor ()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            if (tinta + this.tinta <= cantidadTintaMaxima &&
                tinta + this.tinta >= 0)
            {
                this.tinta += tinta;
            }            
        }

        public void Recargar()
        {
            SetTinta((short)(cantidadTintaMaxima - this.tinta));
        }

        public bool Pintar(int gasto, out string dibujo)
        {
            bool pudoPintar = false;
            string dibujoEnProceso = string.Empty;
            int tintaInicial = this.tinta;
            int gastoReal;

            if (this.tinta > 0) pudoPintar = true;
            SetTinta((short)(gasto * (-1)));

            gastoReal = tintaInicial - this.tinta;

            for(int i =0; i<gastoReal;i++)
            {
                dibujoEnProceso += "*";
            }

            dibujo = dibujoEnProceso;
            return pudoPintar;
        }


    }
}
