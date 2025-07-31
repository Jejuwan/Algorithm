public class BoyJeongmin
{
    public void solution()
    {
        string? input = Console.ReadLine();
        string[] tokens = input!.Split();
        long answer = 0;
        foreach (string token in tokens)
        {
            answer += long.Parse(token);
        }
        Console.WriteLine(answer);
    }
}