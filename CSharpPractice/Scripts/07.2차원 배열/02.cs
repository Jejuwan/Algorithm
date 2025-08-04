public class Maximum
{
    public void solution()
    {
        int max = -1;
        int row = -1; int column = -1;
        for (int i = 0; i < 9; i++)
        {
            string[] tokens = Console.ReadLine()!.Split();
            for (int j = 0; j < 9; j++)
            {
                int n = int.Parse(tokens[j]);
                if(n> max)
                {
                    max = n;
                    row = j + 1; column = i + 1;
                }
            }
        }
        Console.WriteLine(max);
        Console.WriteLine($"{column} {row}");
    }
}