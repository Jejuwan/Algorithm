public class Count
{
    public void solution()
    {
        int n = int.Parse(Console.ReadLine()!);

        string[] tokens = Console.ReadLine()!.Split();

        int v = int.Parse(Console.ReadLine()!);

        int answer = 0;
        for (int i = 0; i < n; i++)
        {
            if (int.Parse(tokens[i]) == v)
                answer++;
        }
        Console.WriteLine(answer);
    }
}