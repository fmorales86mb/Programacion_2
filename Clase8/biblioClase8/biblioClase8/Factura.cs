using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioClase8
{
    // enumerador.
    public enum Tipo
    {
        A,
        B,
        C
    }

    public enum TipoMoneda
    {
        Peso,
        Dolar,
        Euro
    }

    public class Factura
    {
        private int numero; //atributo

        public int Numero // propiedad
        {
            get { return this.numero; } // descriptor de acceso
            set { this.numero = value; }
        }

        private DateTime fecha;

        public DateTime Fecha
        {
            get { return this.fecha; }
            set { this.fecha = value; }
        }

        public TipoMoneda Moneda { get => moneda; set => moneda = value; }
        public Tipo TipoFactura { get => tipoFactura; set => tipoFactura = value; }

        // Segun el tipo de moneda de la factura, devuelve el valor total en pesos dolares o euros.
        public double Total
        {
            get
            {
                double tot = 0;

                foreach (Producto p in productos)
                {
                    tot += p.Total;
                }
                Peso pesosTotales = tot;

                switch (Moneda)
                {
                    case TipoMoneda.Dolar:
                        tot = ((Dolar)pesosTotales).GetCantidad();
                        break;
                    case TipoMoneda.Euro:
                        tot = ((Euro)pesosTotales).GetCantidad();
                        break;
                    default:                                            
                        break;
                }
                                
                return tot;
            }
        }

        private TipoMoneda moneda;
       
        // Se va a ingresar y utilizar este atributo sólo atraves del indexador.
        private List<Producto> productos;      

        //Indexador
        public Producto this[int id] //factura[id] = producto
        {
            get
            {
                Producto prod = null;
                for (int indice = 0; indice < this.productos.Count; indice++)
                {
                    if (this.productos[indice].Id == id)
                    {
                        prod = this.productos[indice];
                        break;
                    }
                }
                return prod;
            }
            set
            {
                bool encontrado = false;                
                for(int indice = 0; indice<this.productos.Count;indice++)
                {
                    if (this.productos[indice].Id == id)
                    {
                        this.productos[indice].Cantidad += value.Cantidad;
                        encontrado = true;
                        break;
                    }
                }
                if (!encontrado)
                {
                    this.productos.Add(value);
                }
            }
        }

        private double total;

        private Tipo tipoFactura;        

        public Factura()
        {
            this.productos = new List<Producto>();            
        }
    }
}
