using System;

namespace _3salarioobrero
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas,total,total2,suma;
            Console.WriteLine("¿Cuántas horas trabajó? ");
            horas = Convert.ToInt16(Console.ReadLine());
            if (horas<=40)
            {
                total = 16 * horas;
                Console.WriteLine("su salario semanal por trabajar" + horas + "horas es: Q." + total + ".00");
            }
            else if (horas>40){
                total2= 20*(horas-40);
                total = 16 * 40;
                suma = total + total2;
                Console.WriteLine("su salario semanal por trabajar" + horas + "horas es: Q." + suma + ".00");

            }
        }
    }
}
