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
            BisectionAlgorithm algorithm = new BisectionAlgorithm();
            algorithm.FindValue(algorithm.GetArr());    // step 1
            GuessMyNumber game = new GuessMyNumber();
            game.HumanPlay(game.GetArr(), true);        // step 2
            int number = game.GetNumber(1, 1000, true);
            game.ComputerPlay(game.GetArr(), number);   // step 3
        }
    }
}
