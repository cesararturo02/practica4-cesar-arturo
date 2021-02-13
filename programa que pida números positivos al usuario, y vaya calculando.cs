using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int suma = 0;
            
            do
            { 
                
                    Console.WriteLine("introduce un numero entero ");
                    num = Int32.Parse(Console.ReadLine());
                    suma = suma + num;
                

            } while(num != 0);

            Console.WriteLine("la suma de todos sus numeros da un total de: " + suma);
            Console.ReadKey();
        }
    }
}
