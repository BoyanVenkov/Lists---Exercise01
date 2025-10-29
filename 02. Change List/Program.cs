List<int> changeList = Console.ReadLine().Split().Select(int.Parse).ToList();
string[] input = Console.ReadLine().Split().ToArray();

while (input[0] != "end")
{
    if (input[0] == "Delete")
    {
        changeList.RemoveAll(n => n == int.Parse(input[1]));
    }
    if (input[0] == "Insert")
    {
        changeList.Insert(int.Parse(input[2]), int.Parse(input[1]));
    }
    input = Console.ReadLine().Split().ToArray();
}
Console.WriteLine(string.Join(" ", changeList));