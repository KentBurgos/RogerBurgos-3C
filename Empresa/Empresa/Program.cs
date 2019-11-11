using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa.Clases;

namespace Empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            Console.WriteLine("Ingrese su nombre:");
            cliente.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese apellido:");
            cliente.Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese su número de cédula:");
            cliente.Cedula = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese dirección:");
            cliente.Direccion = Console.ReadLine();

            Gasolina gasolina = new Gasolina();
            Console.WriteLine("Cuál gasolina desea: ");
            gasolina.Tipo = Console.ReadLine();
            
            Console.WriteLine("Cuantos galones desea llevar");
            gasolina.CantidadDeGalones = float.Parse(Console.ReadLine());


            Console.WriteLine("***********EMPRESA***********\n" +
            "______________________________\n" +
                "El Sr(a) "+cliente.Nombre+" "+cliente.Apellido);
            Console.WriteLine("Su cédula es: "+cliente.Cedula);
            Console.WriteLine("La direccion es: "+cliente.Direccion);
            Console.WriteLine("______________________________\n" +
                "Gasolina: "+gasolina.Tipo);
            Console.WriteLine("Galones: "+gasolina.CantidadDeGalones);
            Console.WriteLine("Valor de gasolina: "+gasolina.PrecioDeVenta);
            Console.WriteLine("______________________________\n" +
                "Subtotal: " + gasolina.Subtotal);
            Console.WriteLine("Iva: "+gasolina.Iva);
            Console.WriteLine("Total: " + gasolina.Total);
            Console.WriteLine("______________________________");
            Console.WriteLine("*****************************");
            
            Console.ReadKey();

        }
    }
}
