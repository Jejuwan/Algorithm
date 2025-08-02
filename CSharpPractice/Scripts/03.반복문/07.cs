public class AplusB7
{
    public void solution()
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        int t = int.Parse(sr.ReadLine()!);

        for (int i = 0; i < t; i++)
        {
            string[] tokens = sr.ReadLine()!.Split();
            sw.WriteLine($"Case #{i + 1}: {int.Parse(tokens[0]) + int.Parse(tokens[1])}");
        }
    }
}