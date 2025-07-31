using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

public class ThreeDice
{
    public void solution()
    {
        string[] tokens = Console.ReadLine()!.Split();
        int[] dices = new int[tokens.Length];
        for (int i = 0; i < tokens.Length; i++)
        {
            dices[i] = int.Parse(tokens[i]);
        }

        int prize;
        if (dices[0] == dices[1] && dices[1] == dices[2])
        {
            prize = 10000 + dices[0] * 1000;
        }
        else if (dices[0] == dices[1] || dices[1] == dices[2]
            || dices[0] == dices[2])
        {
            int n;
            if (dices[0] == dices[1] || dices[0] == dices[2])
                n = dices[0];
            else
                n = dices[1];
            prize = 1000 + n * 100;
        }
        else
        {
            int max = Math.Max(dices[0], Math.Max(dices[1], dices[2]));
            prize = 100 * max;
        }

        Console.WriteLine(prize);
    }
}