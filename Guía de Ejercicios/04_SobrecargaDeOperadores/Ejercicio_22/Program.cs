using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaSobrecarga;

namespace Ejercicio_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_22";

            NumeroBinario bin = "100101";
            NumeroDecimal dec = 133;

            Console.WriteLine(string.Format("{0} (2) -> {1} (10)",
                (string)bin, Conversor.BinarioDecimal((string)bin).ToString()));
            Console.WriteLine(string.Format("{0} (10) -> {1} (2)",
                ((double)dec).ToString(), Conversor.DecimalBinario((double)dec)));

            Console.ReadKey();
        }
    }
}
