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
            Console.Write("\nEnter an integer between 1 and 10\n\n>>> ");
            int number = int.Parse(Console.ReadLine().Trim());
            // Step 1
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
            Console.Write("\nEnter an integer between 1 and 1000\n\n>>> ");
            number = int.Parse(Console.ReadLine().Trim());
            game.ComputerPlay(arr, number);
        }

    }
}
