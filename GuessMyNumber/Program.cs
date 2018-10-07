using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        static void Run()
        {
            int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int number = -1;
            // Step 1
            number = GetNumber(1, 10);
            BisectionAlgorithm algorithm = new BisectionAlgorithm(list, number);
            algorithm.FindValue(list);
            // Step 2
            Random rnd = new Random();
            number = rnd.Next(1000);
            Console.WriteLine("\nThe computer has randomly picked an integer between 1 and 1000. Try to guess the number.");
            int[] arr = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                arr[i] = i + 1;
            }
            GuessMyNumber game = new GuessMyNumber(arr);
            game.HumanPlay(arr, number);
            // Step 3
            number = GetNumber(1, 1000);
            game.ComputerPlay(arr, number);
        }

        static int GetNumber(int min, int max)
        {
            int number = -1;
            bool isValid = false;
            do
            {
                try
                {
                    Console.Write($"\nEnter an integer between {min} and {max}\n\n>>> ");
                    number = int.Parse(Console.ReadLine().Trim());
                    if (number < min || number > max)
                    {
                        throw new Exception("\nInvalid Entry!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (isValid);
            return number;
        }
    }
}
