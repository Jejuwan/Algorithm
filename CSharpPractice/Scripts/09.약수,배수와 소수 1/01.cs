public class MultipleAndFactor
{
    public void solution()
    {
        int a = -1;
        int b = -1;
        while (true)
        {
            string[] tokens = Console.ReadLine()!.Split();
            a = int.Parse(tokens[0]);
            b = int.Parse(tokens[1]);
            if (a == 0 && b == 0)
                break;
            if (b % a == 0)
                Console.WriteLine("factor");
            else if (a % b == 0)
                Console.WriteLine("multiple");
            else
                Console.WriteLine("neither");
        }
    }
}