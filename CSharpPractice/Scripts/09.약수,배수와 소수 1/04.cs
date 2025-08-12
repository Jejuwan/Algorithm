public class FindPrime
{
    public void solution()
    {
        int n = int.Parse(Console.ReadLine()!);

        string[] tokens = Console.ReadLine()!.Split();
        int answer = n;
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(tokens[i]);
            if (num == 1) answer--;
            for (int j = 2; j < num; j++)
            {
                if (num % j == 0) { answer--;break; }
            }
        }
        Console.WriteLine(answer);
    }
}