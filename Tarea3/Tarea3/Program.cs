using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///programa que del numero de mes te pasa al nombre
            int mes;
            Console.Write("Escriba un numero de mes: ");
            mes = Convert.ToInt32(Console.ReadLine());
            switch(mes) 
            {
                case 1: 
                    Console.WriteLine("ENERO");
                    break;
                case 2: 
                    Console.WriteLine("FEBRERO");
                    break;
                case 3:
                    Console.WriteLine("MARZO");
                    break;
                case 4:
                    Console.WriteLine("ABRIL");
                    break;
                case 5:
                    Console.WriteLine("MAYO");
                    break;
                case 6:
                    Console.WriteLine("JUNIO");
                    break;
                case 7:
                    Console.WriteLine("JULIO");
                    break;
                case 8:
                    Console.WriteLine("AGOSTO");
                    break;
                case 9:
                    Console.WriteLine("SEPTIEMBE");
                    break;
                case 10:
                    Console.WriteLine("OCTUBRE");
                    break;
                case 11:
                    Console.WriteLine("NOVIEMBRE");
                    break;
                case 12:
                    Console.WriteLine("DICIEMBRE");
                    break;
                default:
                    Console.WriteLine("No existe ese mes");
                    break;
            }
            ///programa que te dice si es impar o par
            int n;
            Console.Write("Digite un numero para saber si es par o impar: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n%2 == 0)
            {
                Console.WriteLine("Es par");
            }
            else 
            {
                Console.WriteLine("Es impar");
            }
            ///precio del estacionamiento
            double min;
            Console.Write("Marque el tiempo de estancia (minutos): ");
            min = Convert.ToDouble(Console.ReadLine());
            if (min <= 60)
            {
                Console.WriteLine("Debe $5.00 pesos");
            }
            else if (min <=120)
            {
                Console.WriteLine("Debe $15.00 pesos");
            }
            else
                Console.WriteLine("Debe $40.00 pesos");

        }
    }
}
