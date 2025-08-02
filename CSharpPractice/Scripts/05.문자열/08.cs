public class WordCount
{
    public void solution()
    {
        string str = Console.ReadLine()!;

        if (str.Length == 0 || str==null)
        {
            Console.WriteLine(0);
            return;
        }
        if (str[0] == ' ')
            str = str.Remove(0, 1);
        if (str.Length == 0 || str == null)
        {
            Console.WriteLine(0);
            return;
        }
        if (str[str.Length - 1] == ' ')
            str = str.Remove(str.Length - 1, 1);
        if (str.Length == 0 || str == null)
        {
            Console.WriteLine(0);
            return;
        }
        string[] tokens = str.Split();
        Console.WriteLine(tokens.Length);
    }
}