public class ColoredPaper
{
    public void solution()
    {
        int[,] arr = new int[100,100];
        int n = int.Parse(Console.ReadLine()!);
        for(int i=0;i<n;i++)
        {
            string[] tokens = Console.ReadLine()!.Split();
            int x = int.Parse(tokens[0]);
            int y = int.Parse(tokens[1]);
            for(int j=y;j<y+10;j++)
            {
                for(int k=x;k<x+10;k++)
                {
                    arr[j, k] = 1;
                }
            }
        }

        int answer = 0;
        for (int j = 0; j < 100; j++)
        {
            for (int k = 0; k < 100; k++)
            {
                if (arr[j, k] == 1)
                    answer++;
            }
        }
        Console.WriteLine(answer);
    }
}