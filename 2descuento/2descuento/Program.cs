using System;

namespace _2descuento
{
    class Program
    {
        static void Main(string[] args)
        {
           double compra,descuento;
            Console.WriteLine("¿cuánto gastó en su compra? ");
            compra = Convert.ToDouble(Console.ReadLine());
            if (compra>300) {
                descuento = compra-(compra * 0.20);
                Console.WriteLine("su compra con descuento es de :" + descuento);
            }
            else
            {
                Console.WriteLine("No tiene descuento, debe pagar: " + compra);
            }

        }
    }
}
