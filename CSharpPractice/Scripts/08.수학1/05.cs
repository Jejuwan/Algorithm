using System.ComponentModel;

public class Hive
{
    public void solution()
    {
        //1,6,12,18,24
        int n = int.Parse(Console.ReadLine()!);

        int cur = 1;
        int answer = 0;
        for (int i = 0; ;i++)
        {
            cur += 6 * i;
            if (n <= cur)
            {
                answer = i + 1; 
                break;
            }
        }
        Console.Write(answer);
    }
}   