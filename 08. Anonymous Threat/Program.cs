using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
             List<string> data = new List<string>(Console.ReadLine().Split(' '));

        while (true)
        {
            string command = Console.ReadLine();
            if (command == "3:1")
            {
                break;
            }

            string[] parts = command.Split(' ');

            if (parts[0] == "merge")
            {
                int startIndex = int.Parse(parts[1]);
                int endIndex = int.Parse(parts[2]);

                if (startIndex < 0)
                {
                    startIndex = 0;
                }
                if (endIndex > data.Count - 1)
                {
                    endIndex = data.Count - 1;
                }

                if (startIndex < endIndex)
                {
                    string merged = "";
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        merged += data[i];
                    }
                    data.RemoveRange(startIndex, endIndex - startIndex + 1);
                    data.Insert(startIndex, merged);
                }
            }
            else if (parts[0] == "divide")
            {
                int index = int.Parse(parts[1]);
                int partitions = int.Parse(parts[2]);

                string element = data[index];
                List<string> newParts = new List<string>();

                int partSize = element.Length / partitions;
                int extra = element.Length % partitions;

                int currentIndex = 0;
                for (int i = 0; i < partitions; i++)
                {
                    string part;

                    if (i == partitions - 1)
                    {
                        part = element.Substring(currentIndex);
                    }
                    else
                    {
                        part = element.Substring(currentIndex, partSize);
                        currentIndex += partSize;
                    }

                    newParts.Add(part);
                }
                data.RemoveAt(index);
                data.InsertRange(index, newParts);
            }
        }

        Console.WriteLine(string.Join(" ", data));
    }
}
