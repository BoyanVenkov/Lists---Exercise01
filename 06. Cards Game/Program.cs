using System.Collections.Generic;
using System.Numerics;

List<int> player1 = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> player2 = Console.ReadLine().Split().Select(int.Parse).ToList();

while (player1.Count != 0 && player2.Count != 0)
{
    if (player1[0] > player2[0])
    {
        player1.Add(player1[0]);
        player1.Add(player2[0]);
        player1.RemoveAt(0);
        player2.RemoveAt(0);
        continue;
    }
    if (player2[0] > player1[0])
    {
        player2.Add(player2[0]);
        player2.Add(player1[0]);
        player1.RemoveAt(0);
        player2.RemoveAt(0);
        continue;
    }
    if (player1[0] == player2[0])
    {
        player1.RemoveAt(0);
        player2.RemoveAt(0);
        continue;
    }
}
if (player2.Count == 0)
{
    int sum = 0;
    foreach (int n in player1)
    {
        sum += n;
    }
    Console.WriteLine($"First player wins! Sum: {sum}");
    return;
}
if (player1.Count == 0)
{
    int sum = 0;
    foreach (int n in player2)
    {
        sum += n;
    }
    Console.WriteLine($"Second player wins! Sum: {sum}");
    return;
}