public class GetFactor
{
    public void solution()
    {
        string[] tokens = Console.ReadLine()!.Split();
        int a = int.Parse(tokens[0]);
        int b = int.Parse(tokens[1]);

        int count = 0;
        int answer = 0;
        for (int i = 1; i <= a; i++)
        {
            if (a % i == 0) count++;
            if (count == b)
            {
                answer = i;
                break;
            };
        }
        Console.WriteLine(answer);
    }
}