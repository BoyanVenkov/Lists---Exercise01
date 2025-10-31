using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        int[] bombInfo = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int bombNumber = bombInfo[0];
        int power = bombInfo[1];

        while (numbers.Contains(bombNumber))
        {
            int index = numbers.IndexOf(bombNumber);

            int leftIndex = Math.Max(index - power, 0);
            int rightIndex = Math.Min(index + power, numbers.Count - 1);
            numbers.RemoveRange(leftIndex, rightIndex - leftIndex + 1);
        }

        Console.WriteLine(numbers.Sum());
    }
}