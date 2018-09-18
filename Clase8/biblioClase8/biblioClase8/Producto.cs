using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioClase8
{
    public class Producto
    {
        private int id;
        // es lo mismo que id pùblico. 
        public int Id 
        {
            get { return this.id; }
            set { this.id = value; }
        }

        private string nombre; 

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        private double precio; //solo escritura setea percio         

        public double Precio
        {
            set
            {
                this.precio = value;
                this.iva = this.precio * 0.21;
            }
        }

        private double iva; // sin propiedades

        //total solo lectura devuelve precio total.
        private double total;

        public double Total
        {
            get
            {
                return this.precio + this.iva;
            }
        }        

        private int cantidad;

        public int Cantidad { get => cantidad; set => cantidad = value; }

        public Producto(int id, string nombre, double precio)
        {
            Id = id;            
            Nombre = nombre;
            Precio = precio;
            Cantidad = 0;
        }
    }
}
