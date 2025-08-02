using System.Text;
public class MinMax
{
    public void solution()
    {
        int N = int.Parse(Console.ReadLine()!);
        string[] arr = Console.ReadLine()!.Split();
        int min = 1000001;
        int max = -1000001;

        for (int i = 0; i < N; i++)
        {
            int n = int.Parse(arr[i]);
            if (n<min)
            {
                min = n;
            }
            if (n > max)
            {
                max = n;
            }
        }
        Console.WriteLine($"{min} {max}");
    }
}