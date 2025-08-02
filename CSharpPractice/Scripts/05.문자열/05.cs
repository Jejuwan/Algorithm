using System.Data;

public class NumberSum
{
    public void solution()
    {
        int n = int.Parse(Console.ReadLine());
        string str = Console.ReadLine()!;
        int answer = 0;
        for(int i=0;i<n;i++)
        {
            answer += int.Parse(str[i].ToString());
        }
        Console.WriteLine(answer);
    }
}