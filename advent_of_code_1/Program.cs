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
            var inputPath = @"../../../input.txt";
            string inputString = File.ReadAllText(inputPath);
            List<int> FrequencyList = inputString.Split('\n').Select(x => int.Parse(x)).ToList();
            int resultingFrequency = 0;
            foreach (int f in FrequencyList)
            {
                resultingFrequency += f;
            }
            Console.ReadKey();
        }
    }
}
