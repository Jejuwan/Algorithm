using System.ComponentModel;

public class FindFountain
{
    public void solution()
    {
        int n = int.Parse(Console.ReadLine()!);

        //짝수 : 오른위-> 왼아래 홀수:왼아래->오른위
        int cur = 0;
        int curMax = 0;
        int idx = 0;
        for (int i = 1; ;i++)
        {
            cur +=  i;
            if (n <= cur)
            {
                idx = n - (cur - i);
                curMax = i;
                break;
            }
        }
        if (curMax % 2 == 0)
            Console.Write($"{idx}/{curMax - idx + 1}");
        else
            Console.Write($"{curMax - idx + 1}/{idx}");
    }
}   