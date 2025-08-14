 class SumOfDigits
{
    public void solution()
    {
        int n = int.Parse(Console.ReadLine()!);
        for (int i = 1; i <= n; i++)
        {
            string s = i.ToString();
            int sum = 0;
            for (int j = 0; j < s.Length; j++)
                sum += int.Parse(s[j].ToString());
            if (i+sum == n)
            {
                Console.WriteLine(i);
                return;
            }
        }
        Console.WriteLine(0);
    }
}
