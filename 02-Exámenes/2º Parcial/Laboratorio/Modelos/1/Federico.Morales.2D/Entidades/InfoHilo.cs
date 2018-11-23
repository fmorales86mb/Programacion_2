using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Interfaces;

namespace Entidades
{
    public class InfoHilo
    {
        // Atributos
        private IRespuesta<int> callback;
        private Thread hilo;
        private int id;
        private static Random randomizer;

        // Constructores
        static InfoHilo()
        {
            randomizer = new Random();
        }

        public InfoHilo(int id, IRespuesta<int> callback)
        {
            this.id = id;
            this.callback = callback;
            this.hilo = new Thread(this.Ejecutar);
            this.hilo.Start();
        }

        // Métodos
        private void Ejecutar()
        {
            int time = randomizer.Next(1000, 5000);
            Thread.Sleep(time);
            callback.RespuestaHilo(this.id);
        }
    }
}
