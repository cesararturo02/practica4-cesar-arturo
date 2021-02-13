using System;

namespace que_muestre_de_la_Z_a_la_A
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra = 'Z';

            do
            {
                
                Console.WriteLine("letra: " + letra);
                letra--;

            } while (letra >= 'A');

            Console.ReadKey();
            
        }
    }
}
