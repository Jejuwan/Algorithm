using System.Linq.Expressions;

public class Remain2
{
    public void solution()
    {
        int[] arr = new int[42];
        for (int i = 0; i < 10; i++)
        {
            int num = int.Parse(Console.ReadLine()!);
            arr[num % 42]++;
        }

        int answer = 0;
        foreach(var elem in arr)
        {
            if (elem != 0)
                answer++;
        }
        Console.WriteLine(answer);
    }
}