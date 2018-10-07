using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    class GuessMyNumber
    {
       public GuessMyNumber(int[] arr)
        {
            this.arr = arr;
        }
        int[] arr = new int[1000];
        int number;

        public void HumanPlay(int[] list, int number)
        {
            Console.Write("\n>>> ");
            int guess = int.Parse(Console.ReadLine().Trim());
            if (guess == number)
            {
                Console.WriteLine($"\nYour guess is correct. The randomly picked number is {guess}.");
            }
            else
            {
                Console.WriteLine($"\nYour guess was too " + (guess > number ? "high" : "low"));
                List<int> newList = new List<int>();
                int startIndex = number > guess ? Array.IndexOf(list, guess) + 1 : 0;
                int endIndex = number < guess ? Array.IndexOf(list, guess) - 1 : list.Length - 1;
                for (int i = startIndex; i <= endIndex; i++)
                {
                    newList.Add(list[i]);
                }
                HumanPlay(newList.ToArray(), number);
            }
        }
    }
}
