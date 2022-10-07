using System;

namespace Uppgift4_1
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Vilket är världens folkrikaste land?");
            string svar = Console.ReadLine();

            while(svar != "Kina")
            {
                Console.WriteLine("Du svarade fel, försök igen");
                svar = Console.ReadLine(); 
            }
            Console.WriteLine("Du svarade rätt");
        }
    }
}