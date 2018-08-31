using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaGuiaEjercicios;

namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_07";
            int day = 0;
            int month = 0;
            int year = 0;
            string linea;
            bool flag = false;
            int acumuladorDias;
            
            // Tomo y valido datos.
            Console.WriteLine("Ingrese su fecha de nacimiento:");
            Console.Write("Día: ");
            linea = Console.ReadLine();
            if (!string.IsNullOrEmpty(linea) && int.TryParse(linea, out day) && !flag) flag = true;
            Console.Write("Mes: ");
            linea = Console.ReadLine();
            if (!string.IsNullOrEmpty(linea) && int.TryParse(linea, out month) && flag) flag = true;
            Console.Write("Año: ");
            linea = Console.ReadLine();
            if (!string.IsNullOrEmpty(linea) && int.TryParse(linea, out year) && flag) flag = true;

            if (!flag) Console.WriteLine("Datos incorrectos.");
            else
            {
                DateTime fechaNacimiento = new DateTime(year, month, day);
                for (acumuladorDias = 0; fechaNacimiento.Date<DateTime.Now.Date; fechaNacimiento = fechaNacimiento.AddDays(1))
                {
                    acumuladorDias++;                    
                }

                Console.WriteLine("La persona vivió "+acumuladorDias.ToString() + " días.");


                
                /*for (int i = year; i <= DateTime.Now.Year; i++)
                {
                    // Dìas del primer año.
                    if (i == year && year!=DateTime.Now.Year)
                    {
                        for (int m = month; m <= 12; m++)
                        {
                            acumuladorDias += DiasPorMes(m, i);
                        }
                    }
                    // Dìas del año actual
                    else if (i == DateTime.Now.Year)
                    {
                        for (int n = 1; n <= DateTime.Now.Month; n++)
                        {
                            // Dìas del mes actual
                            if (n == DateTime.Now.Month)
                            {
                                for (int d = 1; d < DateTime.Now.Day; d++)
                                {
                                    acumuladorDias++;

                                }
                            }
                            else
                            {
                                acumuladorDias += DiasPorMes(n, i);
                            }
                        }
                    }
                    // Días por año
                    else
                    {
                        if (ConceptosBasicos.IsBisiesto(i)) acumuladorDias += 366;
                        else acumuladorDias += 365;
                    }
                }*/
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Evalua la cantidad de días de determinado mes. Contempla años bisiestos.
        /// </summary>
        /// <param name="mes">Mes a evaluar</param>
        /// <param name="anio"></param>
        /// <returns>Cantidad de días del mes</returns>
        static int DiasPorMes (int mes, int anio)
        {
            int diasDelMes;
            switch (mes)
            {
                case 1:
                    diasDelMes = 30;
                    break;
                case 2:
                    if (ConceptosBasicos.IsBisiesto(anio)) diasDelMes = 29;
                    else diasDelMes = 28;
                    break;
                case 3:
                    diasDelMes = 30;
                    break;
                case 4:
                    diasDelMes = 30;
                    break;
                case 5:
                    diasDelMes = 30;
                    break;
                case 6:
                    diasDelMes = 30;
                    break;
                case 7:
                    diasDelMes = 30;
                    break;
                case 8:
                    diasDelMes = 30;
                    break;
                case 9:
                    diasDelMes = 30;
                    break;
                case 10:
                    diasDelMes = 30;
                    break;
                case 11:
                    diasDelMes = 30;
                    break;
                case 12:
                    diasDelMes = 30;
                    break;                   
                default:
                    diasDelMes = 0;
                    break;
            }

            return diasDelMes;
        }
    }
}
