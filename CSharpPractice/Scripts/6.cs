using System;
public class Sachikyeonsan
{
    public static void Main(string[] args)
    {
        string? input = Console.ReadLine();
        string[] tokens = input!.Split();
        int A = int.Parse(tokens[0]);
        int B = int.Parse(tokens[1]);
        Console.WriteLine(A + B);
        Console.WriteLine(A - B);
        Console.WriteLine(A * B);
        Console.WriteLine(A / B);
        Console.WriteLine(A % B);
    }
}