using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Calcular perimetro poligono regular
            double lado,peri;
            int n;
            Console.Write("Dame el numero de lados: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dame el tamaño del lado: ");
            lado = Convert.ToDouble(Console.ReadLine());
            peri = n*lado; //formula de perimetro de poligonos regulares
            Console.WriteLine("El perimetro es: {0}", peri);

            ///conversor de centigrados a fahrenheit
            double cel, fah;
            Console.Write("Dame los grados Celsius: ");
            cel = Convert.ToDouble(Console.ReadLine());
            fah = (cel * 1.8)+32; //formula de celcius a fahrenheit
            Console.WriteLine("{0}° Celsius son {1}F Fahrenheit",cel,fah);
        }
    }
}
