public class ChangeBall
{
    public void solution()
    {
        string[] tokens = Console.ReadLine()!.Split();
        int N = int.Parse(tokens[0]);
        int M = int.Parse(tokens[1]);

        int[] arr = new int[N];
        for (int i = 0; i < N; i++) arr[i] = i + 1;
        for (int x = 0; x < M; x++)
        {
            string[] line = Console.ReadLine()!.Split();
            int a = int.Parse(line[0]);
            int b = int.Parse(line[1]);

            int temp = arr[a-1];
            arr[a-1] = arr[b-1];
            arr[b - 1] = temp;
        }
        String s = "";
        foreach(var elem in arr)
        {
            s += $"{elem} ";
        }
        Console.WriteLine(s);
    }
}