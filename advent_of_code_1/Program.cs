using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace advent_of_code_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input Data
            var inputPath = @"../../../input.txt";
            string inputString = File.ReadAllText(inputPath);
            List<int> FrequencyList = inputString.Split('\n').Select(x => int.Parse(x)).ToList();
            List<int> FrequencyCount = new List<int>();
            int firstTwiceFrequency = 0;
            int resultingFrequency = 0;

            //Part 1
            CalculateFrequency();
            Console.WriteLine(resultingFrequency);
            
            //Part 2
            resultingFrequency = 0;
            FirstTwiceOccurence();
            Console.WriteLine(firstTwiceFrequency);
            Console.ReadKey();

            //Calculate the total frequence after going through the FrequencyList once.
            void CalculateFrequency()
            {
                foreach (int f in FrequencyList)
                {
                    resultingFrequency += f;
                }
            }

            //Loop through all frequencies in the FrequencyList, until the same frequence is reached twice for the first time.
            void FirstTwiceOccurence()
            {
                while (firstTwiceFrequency == 0)
                {
                    foreach (int f in FrequencyList)
                    {
                        resultingFrequency += f;
                        FrequencyCount.Add(resultingFrequency);
                        if (CheckFrequency(resultingFrequency))
                        {
                            break;
                        }
                    }
                }
            }

            //Check if that frequency has been reached before.
            bool CheckFrequency(int frequency)
            {
                if (FrequencyCount != null && FrequencyCount.Contains(frequency))
                {
                    firstTwiceFrequency = frequency;
                    return true;
                }
                return false;
            }
        }
    }
}
