public class String
{
    public void solution()
    {
        int t = int.Parse(Console.ReadLine()!);
        for (int i = 0; i < t; i++)
        {
            string str = Console.ReadLine()!;
            string s = "";
            s += str[0];
            s += str[str.Length - 1];
            Console.WriteLine(s);
        }
    }
}