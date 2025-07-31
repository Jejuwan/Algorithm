public class OvenClock
{
    public void solution()
    {
        string? input = Console.ReadLine();
        string[] tokens = input!.Split();
        int h = int.Parse(tokens[0]!);
        int m = int.Parse(tokens[1]!);
        int duration = int.Parse(Console.ReadLine()!);

        int plusH = duration / 60;
        int plusM = duration % 60;

        m += plusM;
        if (m >= 60)
        {
            h++;
            m -= 60;
        }
        h += plusH;
        if (h >= 24)
            h -= 24;
        Console.WriteLine(h.ToString() + ' ' + m.ToString());
    }
}