using System;

namespace caractermayus
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;

            Console.WriteLine("Ingrese un caracter: ");
            letra = Convert.ToChar(Console.ReadLine());
            if (letra >= 'A' && letra <= 'Z')
            {
                Console.WriteLine("La letra es mayuscula ");

            }
            else {
                Console.WriteLine("La letra es minuscula ");
            }

        }
    }
}
