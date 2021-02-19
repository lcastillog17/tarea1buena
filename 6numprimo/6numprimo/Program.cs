using System;

namespace _6numprimo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,contador=0;
            Console.WriteLine("Ingrese un número: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num <= 1)
            {
                Console.WriteLine("no es primo ");
            }
            else
            {
                for (int i = 1; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        contador++;
                    }
                }
                    if (contador <= 2)
                    {
                        Console.WriteLine("no es primo ");
                    }
                    else
                    {
                        Console.WriteLine("es primo ");
                    }
        
            }
            
        }
    }
}
