using System;

namespace Vektorer
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] namn = new string[5];

           string userInput;

           Console.WriteLine("Skriv i fem namn");

           for (int i = 0; i < namn.Length; i++)
           {
               Console.Write("Namn " + (i + 1) + ": ");
               userInput = Console.ReadLine();

               namn[i] = userInput;
           }

            Console.WriteLine("\n\nDina namn var:");
           for (int i = 0; i < namn.Length; i++)
           {
               Console.WriteLine(namn[i]);
           }
        }
    }
}
