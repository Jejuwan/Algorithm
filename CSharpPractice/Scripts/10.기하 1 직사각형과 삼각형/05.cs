public class Site
{
    public void solution()
    {
        var min = (10001, 10001);
        var max = (-10001, -10001);
        int t = int.Parse(Console.ReadLine()!);
        for (int i = 0; i < t; i++)
        {
            string[] tokens = Console.ReadLine()!.Split();
            int x = int.Parse(tokens[0]);
            int y = int.Parse(tokens[1]);
            if (x < min.Item1)
                min.Item1 = x;
            if (y < min.Item2)
                min.Item2 = y;

            if (x > max.Item1)
                max.Item1 = x;
            if (y > max.Item2)
                max.Item2 = y;

        }
        int answer = (max.Item1 - min.Item1) * (max.Item2 - min.Item2);
        Console.WriteLine(answer);
    }
}
