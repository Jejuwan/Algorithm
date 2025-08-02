public class InsertBall
{
    public void solution()
    {
        string[] tokens = Console.ReadLine()!.Split();
        int N = int.Parse(tokens[0]);
        int M = int.Parse(tokens[1]);

        int[] arr = new int[N];
        for (int x = 0; x < M; x++)
        {
            string[] line = Console.ReadLine()!.Split();
            int i = int.Parse(line[0]);
            int j = int.Parse(line[1]);
            int k = int.Parse(line[2]);
            for(int l = i-1; l<= j-1; l++)
            {
                arr[l] = k;
            }
        }
        String s = "";
        foreach(var elem in arr)
        {
            s += $"{elem} ";
        }
        Console.WriteLine(s);
    }
}