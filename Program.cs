using System;

namespace Vektorer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tal = new int[5];

            Console.WriteLine("Skriv in fem heltal");

            for (int i = 0; i < tal.Length; i++)
            {
                Console.Write("Skriv ett tal: ");
                tal[i] = Convert.ToInt32(Console.ReadLine());

            }

            int samman = 0;

            for (int i = 0; i < tal.Length; i++)
            {
                Console.WriteLine(tal[i]);

                samman += tal[i];

            }
            
            Console.WriteLine(samman);

        }
    }
}
