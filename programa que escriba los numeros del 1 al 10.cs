using System;

namespace programa_que_escriba_los_numeros_del_1_al_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1; 
            do
            { 
               
                Console.WriteLine("numero: " + num);
                num++;

            } while (num != 11);

            Console.ReadKey();
        }
    }
}
