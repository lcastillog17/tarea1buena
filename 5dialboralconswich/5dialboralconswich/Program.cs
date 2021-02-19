using System;

namespace _5dialboralconswich
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia;
            Console.WriteLine("eliga el dia:\n " +
               "1. Lunes\n" +
               "2. Martes\n" +
               "3. Miercoles\n" +
               "4. Jueves\n" +
               "5. Viernes\n" +
               "6. Sabado\n" +
               "7. Domingo\n");
            dia = Convert.ToInt32(Console.ReadLine());
            int dias=dia;

            switch (dias)
            {
                case 1:
                    Console.WriteLine("Día laboral");
                     break;
                case 2:
                    Console.WriteLine("Día laboral");
                       break;
                case 3:
                    Console.WriteLine("Día laboral");
                     break;
                case 4:
                    Console.WriteLine("Día laboral");
                     break;
                case 5:
                    Console.WriteLine("Día laboral");
                     break;
                case 6:
                    Console.WriteLine("No es día laboral");
                     break;
                case 7:
                    Console.WriteLine("No es día laboral");
                      break;
            }
            
        }
    }
}
