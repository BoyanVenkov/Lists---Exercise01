using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        List<string> arrays = input.Split('|', StringSplitOptions.RemoveEmptyEntries)
                                   .ToList();

        List<int> result = new List<int>();

        for (int i = arrays.Count - 1; i >= 0; i--)
        {
            int[] numbers = arrays[i]
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            result.AddRange(numbers);
        }

        Console.WriteLine(string.Join(" ", result));
    }
}