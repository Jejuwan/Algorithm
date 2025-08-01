public class Sum
{
    public void solution()
    {
       int t = int.Parse(Console.ReadLine()!);

        int answer = 0;
        for(int i=1; i <=t;i++)
        {
            answer += i;
        }
        Console.WriteLine(answer);
    }
}