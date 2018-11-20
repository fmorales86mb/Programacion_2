using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Entidades
{
    public class LosHilos : IRespuesta<int>
    {
        // Atributos
        private int id;
        private List<InfoHilo> misHilos;

        public delegate void AvisoFin(string mensaje);
        public event AvisoFin avisoFin;

        // Propiedades
        public string Bitacora
        {
            get
            {
                StreamReader reader = null;
                string texto = string.Empty;

                string fileName = "bitacora.txt";
                string url = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string urlFile = url + @"\" + fileName;

                if (File.Exists(urlFile))
                {

                    try
                    {
                        reader = File.OpenText(urlFile);
                        texto = reader.ReadToEnd();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        reader.Close();
                    } 
                }

                return texto;
            }
            set
            {
                StreamWriter writer = null;

                string fileName = "bitacora.txt";
                string url = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string urlFile = url + @"\" + fileName;

                try
                {
                    
                    writer = new StreamWriter(urlFile, true);
                    writer.WriteLine(value);
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    writer.Close();
                }
            }
        }

        // Constructores
        public LosHilos()
        {
            this.id = 0;
            this.misHilos = new List<InfoHilo>();
        }

        // Métodos
        private static LosHilos AgregarHilo(LosHilos hilos)
        {
            hilos.id++;
            InfoHilo info = new InfoHilo(hilos.id, hilos);
            hilos.misHilos.Add(info);

            return hilos;
        }

        public void RespuestaHilo(int id)
        {
            string mensaje = string.Format("Terminó el hilo {0}", id, ToString());
            this.Bitacora = mensaje;
            this.avisoFin.Invoke(mensaje);
        }

        // Operadores
        public static LosHilos operator +(LosHilos hilos, int cantidad)
        {
            if (cantidad < 1)
            {
                throw new CantidadInvalidaException();
            }
            else
            {
                for (int i = 0; i < cantidad; i++)
                {
                    hilos = LosHilos.AgregarHilo(hilos);
                }
            }

            return hilos;
        }
    }
}
