public class Prime
{
    public void solution()
    {
        int m = int.Parse(Console.ReadLine()!);
        int n = int.Parse(Console.ReadLine()!);

        int primeSum = 0;
        int primeMin = -1;
        for (int i = m; i <= n; i++)
        {
            int count = 0;
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0) { count++; }
            }
            if (count == 2)
            {
                if (primeMin < 0)
                    primeMin = i;
                primeSum += i;
            }
        }
        if (primeSum != 0)
        {
            Console.WriteLine(primeSum);
            Console.WriteLine(primeMin);
        }
        else
            Console.WriteLine(-1);
    }
}