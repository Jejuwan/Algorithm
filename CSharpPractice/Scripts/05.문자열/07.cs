using System.Linq.Expressions;

public class RepeatString
{
    public void solution()
    {
        int t = int.Parse(Console.ReadLine()!);
        for(int i=0;i<t;i++)
        {
            string[] tokens = Console.ReadLine()!.Split();
            int r = int.Parse(tokens[0]);
            string s = tokens[1];

            string answer = "";
            foreach(char c in s)
            {
                for (int j = 0; j < r; j++)
                    answer += c;
            }
            Console.WriteLine(answer);
        }
    }
}