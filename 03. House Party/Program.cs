int n = int.Parse(Console.ReadLine());
List<string> guests = new List<string>();

for (int i = 0; i < n; i++)
{
    string[] commandParts = Console.ReadLine().Split().ToArray();
    string name = commandParts[0];

    if (commandParts.Length == 3)
    {
        if (guests.Contains(name))
        {
            Console.WriteLine($"{name} is already in the list!");
        }
        else
        {
            guests.Add(name);
        }
    }
    else if (commandParts.Length == 4)
    {
        if (guests.Contains(name))
        {
            guests.Remove(name);
        }
        else
        {
            Console.WriteLine($"{name} is not in the list!");
        }
    }
}

foreach (string guest in guests)
{
    Console.WriteLine(guest);
}