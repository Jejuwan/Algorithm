public class Remain
{
    public void solution()
    {
        string? input = Console.ReadLine();
        string[] tokens = input!.Split();
        int A = int.Parse(tokens[0]);
        int B = int.Parse(tokens[1]);
        int C = int.Parse(tokens[2]);
        Console.WriteLine((A + B) % C);
        Console.WriteLine(((A % C) + (B % C)) % C);
        Console.WriteLine((A * B) % C);
        Console.WriteLine(((A % C) * (B % C)) % C);
    }
}