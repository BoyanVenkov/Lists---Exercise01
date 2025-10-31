List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
string[] command = Console.ReadLine().Split().ToArray();

while (command[0] != "End")
{
    if (command[0] == "Add")
    {
        input.Add(int.Parse(command[1]));
    }
    if (command[0] == "Insert")
    {
        if (int.Parse(command[2]) < 0 || int.Parse(command[2]) >= input.Count)
        {
            Console.WriteLine("Invalid index");
            command = Console.ReadLine().Split().ToArray();
            continue;
        }
        input.Insert(int.Parse(command[2]), int.Parse(command[1]));
    }
    if (command[0] == "Remove")
    {
        if (int.Parse(command[1]) < 0 || int.Parse(command[1]) >= input.Count)
        {
            Console.WriteLine("Invalid index");
            command = Console.ReadLine().Split().ToArray();
            continue;
        }
        input.RemoveAt(int.Parse(command[1]));
    }
    if (command[1] == "left")
    {
        for (int i = 1; i <= int.Parse(command[2]); i++)
        {
            int firstNumber = input[0];
            input.Add(firstNumber);
            input.RemoveAt(0);
        }
    
    }
    if (command[1] == "right")
    {
        for (int i = 1; i <= int.Parse(command[2]); i++)
        {
            int lastNumber = input[input.Count - 1];
            input.Insert(0, lastNumber);
            input.RemoveAt(input.Count - 1);
        }
    }
    command = Console.ReadLine().Split().ToArray();
}
Console.WriteLine(string.Join(" ", input));