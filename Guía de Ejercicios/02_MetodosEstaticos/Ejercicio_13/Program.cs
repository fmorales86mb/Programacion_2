using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaMetodosEstaticos;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_13";

            string nroBin = "10100001";
            double nroDec = 21;

            Console.WriteLine(string.Format("{0} (2) -> {1} (10)", 
                nroBin, (Conversor.BinarioDecimal(nroBin)).ToString()));

            Console.WriteLine(string.Format("{0} (10) -> {1} (2)",
                nroDec.ToString(), Conversor.DecimalBinario(nroDec)));

            Console.ReadKey();
        }
    }
}
