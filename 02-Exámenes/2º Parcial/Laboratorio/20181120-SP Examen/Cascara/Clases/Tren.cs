using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    /*
     * Clase Tren
 Debe implementar la interface IArribo<int>.
 Constructores:
o De instancia, sin parámetros, deberá asignar el valor de contadorTrenes al id, luego
aumentar en uno dicha variable e instanciará la lista de ManejadorTrenes.
o Estático: asignará un 0 al atributo estático contadorTrenes y path con la ruta a un
archivo "RegistroDeTrenes.txt" en el escritorio.
 Properties:
o Registros (string):
i. Set: genera o agrega información al archivo descripto en path y también
guardará en la tabla trenes de la base de datos usando el método
GuardarArribo.
ii. Get: retornará el contenido del archivo.
o ManejadorTrenes: retorna el atributo manejadorTrenes.
 Método:
o AgregarTren hará los siguientes pasos, en el siguiente orden:
i. Generará un nuevo objeto del tipo Tren.
ii. Le asignará el evento EventoArribo de this al objeto creado (ej:
tren.EventoArribo = this.EventoArribo).
iii. Creará un nuevo ManejadorTrenes y en el constructor le pasará el id del tren y
el tren creado.
o Arribar (Implementación IArribo ) hará los siguientes pasos, en el siguiente orden:
. Creará un mensaje con el siguiente formato: "Llegó el tren {0}.".
i. Guardará el mensaje en la property Registros.
ii. Ejecutará el evento EventoArribo.
 El operador + lanzará la excepción CantidadInvalidaException en el caso de que la cantidad sea
menor a 1. Si cantidad es mayor a 0, deberá agregar tantos trenes como indique dicha cantidad.
     */
    public class Tren:IArribo<int>
    {
        private static int contadorTrenes;
        private int id;
        private List<ManejadorTrenes> manejadorTrenes;
        private static string path;

        public delegate void MyDelegate (string mensaje);

        public List<ManejadorTrenes> ManejadorTrenes
        {
            get
            {
                return this.manejadorTrenes;
            }            
        }

        // ver de agregar try catch
        public string Registros
        {
            get
            {
                try
                {
                    string textoArchivo;
                    Archivos.Leer(path, out textoArchivo);
                    return textoArchivo;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            set
            {
                try
                {
                    Archivos.Guardar(Tren.path, value);
                    Datos.GuardarArribo(this.id, DateTime.Now, value);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        static Tren()
        {
            Tren.contadorTrenes = 0;
            Tren.path = string.Format(@"{0}\RegistroDeTrenes.txt", 
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
        }

        public Tren()
        {
            this.id = Tren.contadorTrenes;
            Tren.contadorTrenes++;
            this.manejadorTrenes = new List<ManejadorTrenes>();
        }

        private Tren AgregarTren()
        {
            Tren nuevoTren = new Tren();

            nuevoTren.EventoArribo = this.EventoArribo;

            Clases.ManejadorTrenes nuevoManejador = new ManejadorTrenes(this.id, nuevoTren);

            return nuevoTren;
        }

        public void Arribar(int id)
        {
            string mensaje = string.Format("Llegó el tren {0}", id);
            this.Registros = mensaje;
            this.EventoArribo.Invoke(mensaje);
        }

        public static Tren operator + (Tren tren, int cantidad)
        {
            if(cantidad<1)
            {
                throw new CantidadInvalidaException("Cantidad invalida");
            }
            else
            {
                for(int i = 0; i<cantidad; i++)
                {
                    tren = tren.AgregarTren();
                }
            }

            return tren;
        }

        public event MyDelegate EventoArribo;
    }
}
