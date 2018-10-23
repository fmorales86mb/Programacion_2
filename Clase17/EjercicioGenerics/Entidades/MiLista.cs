using System;
using System.Collections;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Utilizar Generics y Arrays construir la clase MiLista que imitará el comportamiento de List.Se deberán crear los métodos:

//Add: agregá un ítem al array.
//Remove: eliminará el primer elemento igual que encuentre.
//Count: propiedad que retornará la cantidad ítems del array.
//Implementar IEnumerable para poder recorrerla con, por ejemplo, foreach.

namespace Entidades
{
    public class MiLista<T> : IEnumerable<T> // implemento la interface.
    {
        private T[] array;

        // Constructor
        public MiLista()
        {
            this.array = new T[0];            
        }
                        
        public void Add(T item)
        {
            Array.Resize(ref this.array, this.array.Length+1);
            this.array[this.array.Length - 1] = item;
        }

        public void Remove (T item)
        {
            // busco el item
            for (int i = 0; i<this.array.Length; i++)
            {
                if (this.array[i].Equals(item))
                {
                    // lo piso y copio el resto
                    for(int j = i+1; j<this.array.Length; j++)
                    {
                        this.array[j - 1] = this.array[j];
                    }
                    // borro el último repetido.
                    Array.Resize(ref this.array, this.array.Length-1);
                    break;
                }
            }
        }

        public int Count 
        {
            get
            {
                return this.array.Length;
            }            
        }

        // para el foreach. Implementación de la interface
        /// <summary>
        /// Permite utilizar el foreach. Fuertemente tipado
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            for(int i = 0; i<this.Count; i++)
            {
                // se utiliza el yield porque no devuelve un solo item, sino que retorna cada uno. Eso lo hace el yield.
                yield return this.array[i];
            }
        }

        /// <summary>
        /// Permite utilizar el foreach. 
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                // se utiliza el yield porque no devuelve un solo item, sino que retorna cada uno. Eso lo hace el yield.
                yield return this.array[i];
            }
        }
    }
}
