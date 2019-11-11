using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Clases
{
    public class Gasolina
    {
        private String tipo;

        public String Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }



        private float cantidadDeGalones;

        public float CantidadDeGalones
        {
            get { return cantidadDeGalones; }
            set { cantidadDeGalones = value; }
        }

        private float precioDeVenta;

        public float PrecioDeVenta
        {
            get
            { 
                if (this.Tipo == "Extra")
                {
                    return 1.5f;
                }
                else
                {
                    return 2;
                }
            }
            
        }

        private float subtotal; 

        public float Subtotal
        {
            get { return CantidadDeGalones * PrecioDeVenta; }
        }

        private float iva;

        public float Iva
        {
            get { return Subtotal * 0.12f; }
        }

        private float total;

        public float Total
        {
            get { return Subtotal + Iva; }
        }




    }
}
