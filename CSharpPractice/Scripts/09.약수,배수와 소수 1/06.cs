public class PrimeFactorization
{
    public void solution()
    {
        int n = int.Parse(Console.ReadLine()!);

        for (int i = 2; i <= n; i++)
        {
            if (n % i != 0)
                continue;

            int count = 0;
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0) { count++; }
            }
            if (count == 2)
            {
                Console.WriteLine(i);
            }
            n /= i;
            i = 1;
        }
    }
}