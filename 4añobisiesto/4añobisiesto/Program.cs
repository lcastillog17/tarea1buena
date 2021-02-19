using System;

namespace _4añobisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            int anio;
            Console.WriteLine("ingrese el anio ");
            anio = Convert.ToInt32 (Console.ReadLine());
            if (anio%4==0 && anio%100!=0 || anio%400==0) {
                Console.WriteLine("el año es bisiesto ");
            }
            else{
                Console.WriteLine("el año no es bisiesto ");
            }
        }
    }
}
