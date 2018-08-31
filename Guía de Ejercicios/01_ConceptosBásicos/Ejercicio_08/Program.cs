using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaGuiaEjercicios;

namespace Ejercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_08";
            bool flag = false;
            string continuar = string.Empty;
            string nombre;
            double valorHora;
            int antiguedad;
            int horas;
            ReciboSueldo recibo;
            List<ReciboSueldo> listaRecibos = new List<ReciboSueldo>();

            do
            {
                Console.Clear();
                nombre = string.Empty;
                valorHora = 0;
                antiguedad = 0;
                horas = 0;

                // Ingreso y valido valores.
                if (ConceptosBasicos.PedirSoloLetras("Ingrese nombre: ", "Valor erroneo.", ref nombre) &&
                    ConceptosBasicos.PedirDouble("Ingrese valor por hora: ", "Valor erroneo.", ref valorHora) &&
                    ConceptosBasicos.PedirEntero("Ingrese años de antiguedad: ", "Valor erroneo.", ref antiguedad) &&
                    ConceptosBasicos.PedirEntero("Ingrese cantidad de horas del mes: ", "Valor erroneo.", ref horas))
                {
                    recibo = new ReciboSueldo(valorHora, nombre, antiguedad, horas);
                    listaRecibos.Add(recibo);
                }

                Console.WriteLine();
                if(ConceptosBasicos.PedirSoloLetras("¿Ingresar otro recibo? (S/N)", "Valor erroneo.", ref continuar))
                {
                    if (continuar.ToUpper() == "S") flag = true;
                    else flag = false;
                }

            } while (flag);

            Console.Clear();
            for(int i=0; i<listaRecibos.Count(); i++)
            {
                listaRecibos[i].Imprimir();
            }

            Console.ReadKey();
        }
    }

    class ReciboSueldo
    {
        public double ValorHora { get; set; }
        public string NombreEmpleado { get; set; }
        public int Antiguedad { get; set; }
        public int Horas { get; set; }
        public double Bruto { get { return CalculoBruto(); } } 
        public double Neto { get { return Bruto - Descuento; } }
        public double Descuento { get { return Bruto * PorcentajeDescuento; } }
        private double PorcentajeDescuento { get { return 0.13; } }

        private double CalculoBruto()
        {
            double total;
            total = (ValorHora * Horas) + (150 * Antiguedad);
            return total;
        }

        public void Imprimir()
        {
            Console.WriteLine("********** Recibo De Sueldo *************");
            Console.WriteLine("Nombre del empleado: " + NombreEmpleado);
            Console.WriteLine("Antiguedad: " + Antiguedad);
            Console.WriteLine("Valor de la hora: " + ValorHora);
            Console.WriteLine("Sueldo bruto: " + Bruto);
            Console.WriteLine("Descuentos: " + Descuento);
            Console.WriteLine("Neto a cobrar: " + Neto);
            Console.WriteLine("");
        }
        
        public ReciboSueldo(double valorHora, string nombreEmpleado, int antiguedad, int horas)
        {
            ValorHora = valorHora;
            NombreEmpleado = nombreEmpleado;
            Antiguedad = antiguedad;
            Horas = horas;
        }

        public ReciboSueldo() { }
    }
}
