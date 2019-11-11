using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Clases
{
    public class Cliente
    {
        


        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private String apellido;

        public  String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        private int cedula;

        public int Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        private String direccion;


        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }





    }
}
