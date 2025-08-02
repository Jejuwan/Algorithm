public class FlipBasket
{
    public void solution()
    {
        string[] tokens = Console.ReadLine()!.Split();
        int N = int.Parse(tokens[0]);
        int M = int.Parse(tokens[1]);

        int[] arr = new int[N+1];
        for (int i = 0; i < N+1; i++) arr[i] = i;

        for (int x = 0; x < M; x++)
        {
            string[] line = Console.ReadLine()!.Split();
            int a = int.Parse(line[0]);
            int b = int.Parse(line[1]);
            
            for(int i=0;i<(b-a+1)/2;i++)
            {
                int temp = arr[b - i];
                arr[b - i] = arr[a + i];
                arr[a + i] = temp;
            }
        }
        string s = "";
       for(int i=1;i<=N;i++)
        {
      
            s += $"{arr[i]} ";
        }
        Console.WriteLine(s);
    }
}