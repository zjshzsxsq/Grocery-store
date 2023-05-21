using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace practice6
{
    class Program
    {
        public static List<int> GetRandomNumbers(int min, int max)
        {
            Random random = new Random();
            List<int> numbers = Enumerable.Range(min, max - min + 1).ToList();
            for (int i = 0; i < numbers.Count; i++)
            {
                int j = random.Next(i, numbers.Count);
                int temp = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = temp;
            }
            return numbers;
        }
    }
}
