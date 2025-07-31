public class AlarmClock
{
    public void solution()
    {
        string? input = Console.ReadLine();
        string[] tokens = input!.Split();
        int h = int.Parse(tokens[0]!);
        int m = int.Parse(tokens[1]!);

        if (m < 45)
        {
            h--;
            if (h < 0)
                h = 23;
            m = 60 - (45 - m);
        }
        else
        {
            m -= 45;
        }
        Console.WriteLine(h.ToString() + ' ' + m.ToString());
    }
}