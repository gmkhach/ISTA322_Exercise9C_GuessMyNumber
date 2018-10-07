using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    class BisectionAlgorithm
    {
        public BisectionAlgorithm()
        {
            for (int i = 0; i < 10; i++)
            {
                arr[i] = i + 1;
            }
            this.number = GetNumber(1, 10);
        }

        private int[] arr = new int[10];
        private int number;

        public int[] GetArr() => arr;

        public void FindValue(int[] arr)
        {
            int midValue = arr.Length % 2 == 0 ? arr[arr.Length / 2 - 1] : arr[arr.Length / 2];
            if (number == midValue)
            {
                Console.WriteLine($"\nValue is {midValue}");
            }
            else
            {
                Console.WriteLine($"\nValue is " + (number > midValue ? "greater" : "less") + $" than {midValue}");
                List<int> newList = new List<int>();
                int startIndex = number > midValue ? Array.IndexOf(arr, midValue) + 1 : 0;
                int endIndex = number < midValue ? Array.IndexOf(arr, midValue) - 1 : arr.Length - 1;
                for (int i = startIndex; i <= endIndex; i++)
                {
                    newList.Add(arr[i]);
                }
                FindValue(newList.ToArray());
            }
        }

        public int GetNumber(int min, int max)
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
                        throw new Exception("Invalid Entry!");
                    }
                    isValid = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n" + ex.Message);
                }
            } while (!isValid);
            return number;
        }
    }
}
