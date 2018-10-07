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
            // Step 1
            BisectionAlgorithm algorithm = new BisectionAlgorithm();
            algorithm.FindValue(algorithm.GetArr());

            // Step 2
            GuessMyNumber game = new GuessMyNumber();
            game.HumanPlay(game.GetArr(), true);
            
            // Step 3
            int number = game.GetNumber(1, 1000);
            game.ComputerPlay(game.GetArr(), number);
        }
    }
}
