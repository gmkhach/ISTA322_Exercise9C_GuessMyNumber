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
            int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.Write("\nEnter an integer between 1 and 10\n\n>>> ");
            int value = int.Parse(Console.ReadLine().Trim());
            FindValue(list, value);

        }

        static void FindValue(int[] list, int value)
        {
            int midValue = list.Length % 2 == 0 ? list[list.Length / 2 - 1] : list[list.Length / 2] ;
            if (value == midValue)
            {
                Console.WriteLine($"\nValue is {midValue}");
            }
            else
            {
                Console.WriteLine($"\nValue is " + (value > midValue ? "greater" : "less") + $" than {midValue}");
                List<int> newList = new List<int>();

                int startIndex = value > midValue ? Array.IndexOf(list, midValue) + 1 : 0;
                int endIndex = value < midValue ? Array.IndexOf(list, midValue) - 1 : list.Length - 1;
                for (int i = startIndex; i <= endIndex; i++)
                {
                    newList.Add(list[i]);
                }
                FindValue(newList.ToArray(), value);
            }
        }
    }
}
