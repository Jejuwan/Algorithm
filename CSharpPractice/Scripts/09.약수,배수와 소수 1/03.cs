public class FactorSum
{
    public void solution()
    {
        int n = int.Parse(Console.ReadLine()!);

        while(n!=-1)
        {
            List<int> factors = new();

            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                { 
                    factors.Add(i);
                    sum += i;
                }
            }
            if (sum == n)
            {
                Console.Write($"{n} = ");
                for (int i = 0; i < factors.Count; i++)
                {
                    Console.Write(factors[i]);
                    if (i != factors.Count - 1)
                        Console.Write(" + ");
                }
                Console.WriteLine();
            }
            else
                Console.WriteLine($"{n} is NOT perfect.");

            n = int.Parse(Console.ReadLine()!);
        }
    }
}