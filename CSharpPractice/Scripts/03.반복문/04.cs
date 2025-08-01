public class Receipt
{
    public void solution()
    {
       int total = int.Parse(Console.ReadLine()!);
       int t = int.Parse(Console.ReadLine()!);

        int answer = 0;
        for(int i=0; i <t;i++)
        {
            string[] tokens = Console.ReadLine()!.Split();
            answer += int.Parse(tokens[0])*int.Parse(tokens[1]);
        }
        if (answer == total)
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
    }
}