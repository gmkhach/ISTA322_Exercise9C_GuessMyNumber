﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    class GuessMyNumber
    {
        public GuessMyNumber()
        {
            for (int i = 0; i < 1000; i++)
            {
                arr[i] = i + 1;
            }
            Random rnd = new Random();
            number = rnd.Next(1000);
        }
        private int[] arr = new int[1000];
        private int number;

        public int[] GetArr() => arr;

        public void HumanPlay(int[] list, bool showMsg)
        {
            if (showMsg)
            {
                Console.Write("\n----------------------------------------------------------------------------------------" +
                         "\n\nThe computer has randomly picked an integer between 1 and 1000.\n");
            }
            int guess = GetNumber(0, 1000, false);
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
                HumanPlay(newList.ToArray(), false);
            }
        }

        public void ComputerPlay(int[] list, int number)
        {
            int midValue = list.Length % 2 == 0 ? list[list.Length / 2 - 1] : list[list.Length / 2];
            if (number == midValue)
            {
                Console.WriteLine($"\nThe number is {midValue}\n");
            }
            else
            {
                Console.WriteLine($"\nThe number is " + (number > midValue ? "greater" : "less") + $" than {midValue}");
                List<int> newList = new List<int>();
                int startIndex = number > midValue ? Array.IndexOf(list, midValue) + 1 : 0;
                int endIndex = number < midValue ? Array.IndexOf(list, midValue) - 1 : list.Length - 1;
                for (int i = startIndex; i <= endIndex; i++)
                {
                    newList.Add(list[i]);
                }
                ComputerPlay(newList.ToArray(), number);
            }
        }

        public int GetNumber(int min, int max, bool line)
        {
            int number = -1;
            bool isValid = false;
            do
            {
                try
                {
                    Console.Write( (line? "\n----------------------------------------------------------------------------------------\n" : "" ) 
                                       + $"\nEnter an integer between {min} and {max}\n\n>>> ");
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
