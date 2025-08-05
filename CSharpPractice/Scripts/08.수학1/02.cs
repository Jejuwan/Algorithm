public class ArithmeticConversion2
{
    public void solution()
    {
        string[] tokens = Console.ReadLine()!.Split();
        int num = int.Parse(tokens[0]);
        int arith = int.Parse(tokens[1]);
        int digit = 0;
        while (Math.Pow(arith, digit) <= num)
            digit++;

        for (int i = digit - 1; i >= 0; i--)
        {
            int div = (int)Math.Pow(arith, i);
            int val = num / div;
            num %= div;

            if (val >= 10)
                Console.Write((char)('A' + (val - 10)));
            else
                Console.Write(val);
        }
    }
}   