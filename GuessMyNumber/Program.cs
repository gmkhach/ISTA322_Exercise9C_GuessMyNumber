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
            NumberGame game = new NumberGame(list, number);
            game.FindValue(list);
        }

    }
}
