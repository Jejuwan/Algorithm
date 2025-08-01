public class AplusB3
{
    public void solution()
    {
       int t = int.Parse(Console.ReadLine()!);

        for(int i=0; i <t;i++)
        {
            string[] tokens = Console.ReadLine()!.Split();
            Console.WriteLine(int.Parse(tokens[0]) + int.Parse(tokens[1]));
        }
    }
}