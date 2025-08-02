using System.Text;
public class LessThanX
{
    public void solution()
    {
        string[] tokens = Console.ReadLine()!.Split();
        int N = int.Parse(tokens[0]);
        int X = int.Parse(tokens[1]);

        string[] arr = Console.ReadLine()!.Split();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < N; i++)
        {
            if (int.Parse(arr[i]) < X)
                sb.Append($"{arr[i]} ");
        }
        Console.WriteLine(sb);
    }
}