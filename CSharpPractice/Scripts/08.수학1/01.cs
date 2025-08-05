public class ArithmeticConversion
{
    public void solution()
    {
        string[] tokens = Console.ReadLine()!.Split();
        int answer = 0;
        int arithmetic = int.Parse(tokens[1]);

        for (int i = 0; i < tokens[0].Length; i++)
        {

            int val = tokens[0][i];

            if (val < 'A')
                val -= '0';
            else
                val -= 'A' - 10;
            answer += val * (int)Math.Pow(arithmetic, tokens[0].Length - i - 1);
        }
        Console.WriteLine(answer);
    }
}