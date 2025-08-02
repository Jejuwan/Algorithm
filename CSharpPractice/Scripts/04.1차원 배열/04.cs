public class Max
{
    public void solution()
    {
        int[] arr = new int[9];
        int max = -1;
        int idx = -1;
        for(int i=0;i<9;i++)
        {
            int n = int.Parse(Console.ReadLine()!);
            if(n > max)
            {
                max = n;
                idx = i+1;
            }
        }
        Console.WriteLine(max);
        Console.WriteLine(idx);
    }
}