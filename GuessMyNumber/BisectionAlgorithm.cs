using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    class BisectionAlgorithm
    {
        public BisectionAlgorithm(int[] list, int number)
        {
            this.list = list;
            this.number = number;
        }

        private int[] list;
        private int number;

        public void FindValue(int[] list)
        {
            int midValue = list.Length % 2 == 0 ? list[list.Length / 2 - 1] : list[list.Length / 2];
            if (number == midValue)
            {
                Console.WriteLine($"\nValue is {midValue}");
            }
            else
            {
                Console.WriteLine($"\nValue is " + (number > midValue ? "greater" : "less") + $" than {midValue}");
                List<int> newList = new List<int>();
                int startIndex = number > midValue ? Array.IndexOf(list, midValue) + 1 : 0;
                int endIndex = number < midValue ? Array.IndexOf(list, midValue) - 1 : list.Length - 1;
                for (int i = startIndex; i <= endIndex; i++)
                {
                    newList.Add(list[i]);
                }
                FindValue(newList.ToArray());
            }
        }
    }
}
