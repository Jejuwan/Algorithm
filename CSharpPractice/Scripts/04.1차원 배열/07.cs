public class WhoDoesntDoHomework
{
    public void solution()
    {
        int[] arr = new int[30];
        for (int x = 0; x < 28; x++)
        {
            int n = int.Parse(Console.ReadLine()!);
            arr[n-1] = 1;
        }
        for(int i=0;i<30;i++)
        {
            if (arr[i] != 1)
                Console.WriteLine(i + 1);
        }
       
    }
}