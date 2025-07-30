using System;
public class AplusB
{
    public void solution()
    {
        string? input = Console.ReadLine();
        string[] tokens = input!.Split();
        int A = int.Parse(tokens[0]);
        int B = int.Parse(tokens[1]);
        Console.WriteLine(A + B);
    }
}