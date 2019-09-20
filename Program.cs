using System;

namespace Vektorer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namn = new string[5];
            string userInput;

            bool game = true;

            Console.WriteLine("Skriv i fem namn");

            try
            {
                for (int i = 0; i < namn.Length; i++)
                {
                    Console.Write("Namn " + (i + 1) + ": ");
                    userInput = Console.ReadLine();

                    namn[i] = userInput;
                }
                while (game)
                {

                    Console.WriteLine("\n\nDina namn var:");
                    for (int i = 0; i < namn.Length; i++)
                    {
                        Console.Write("Dina namn var " + (i + 1) + ": ");
                    }

                    Console.WriteLine("Nu får du byta namn!");
                    Console.WriteLine("Eller avsluta programet med q|Q");
                    Console.WriteLine("Välj platsen du vill ändra (1-5)");
                    string answer = Console.ReadLine();
                    answer = answer.ToUpper();

                    if (answer == "Q")
                    {
                        return;
                    }
                    else
                    {
                        int number = Convert.ToInt32(answer);
                        number--;
                        Console.WriteLine("Skriv nu namnet");
                        string nyttNamn = Console.ReadLine();
                        namn[number] = nyttNamn;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Något gick fel :(");
                Console.WriteLine(e);
            }

        }
    }
}
