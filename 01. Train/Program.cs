List<int> train = Console.ReadLine().Split().Select(int.Parse).ToList();
int passengers = int.Parse(Console.ReadLine());
string[] input = Console.ReadLine().Split().ToArray();

while (input[0] != "end")
{
    if (input[0] == "Add")
    {
        train.Add(int.Parse(input[1]));
    }
    else
    {
        for (int i = 0; i < train.Count; i++)
        {
            if (train[i] + int.Parse(input[0]) <= passengers)
            {
                train[i] += int.Parse(input[0]);
                break;
            }
        }
    }
    input = Console.ReadLine().Split().ToArray();
}
Console.WriteLine(string.Join(" ", train));