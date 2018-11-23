using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clases
{

    /*
     Clase ManejadorTrenes
 Constructores:
o Dos parámetros: recibe un id (int) y el callback (IArribo<int>).
i. Deberá instanciar el atributo Hilo pasándole el método Ejecutar.
ii. Iniciará al atributo Hilo.
 Atributo:
o random (static random). El mismo se inicializará en un constructor de clase.
o hilo (Thread) será el que ejecutará el método Ejecutar.
 Métodos:
o Ejecutar frenará el código durante un tiempo aleatorio de entre 1 y 5 segundos. Luego
de transcurrir este tiempo, utilizará el método Arribar del callback pasando como
parámetro el atributo id
    */
    public class ManejadorTrenes
    {
        private IArribo<int> callback;
        private Thread hilo;
        private int id;
        private static Random random;

        private void Ejecutar()
        {
            int time = random.Next(1000, 5000);
            Thread.Sleep(time);

            this.callback.Arribar(this.id);
        }

        static ManejadorTrenes()
        {
            random = new Random();
        }

        public ManejadorTrenes(int id, IArribo<int> callback)
        {
            this.id = id;
            this.callback = callback;

            this.hilo = new Thread(this.Ejecutar);
            this.hilo.Start();
        }
    }

}
