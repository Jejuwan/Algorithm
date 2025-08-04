public class MatrixAddition
{
    public void solution()
    {
        string[] yx = Console.ReadLine()!.Split();
        int x = int.Parse(yx[1]);
        int y = int.Parse(yx[0]);
        int[,] arr = new int[y,x];
        for(int i=0;i<y;i++)
        {
            string[] tokens = Console.ReadLine()!.Split();
            for (int j=0;j<x;j++)
            {
                arr[i, j] = int.Parse(tokens[j]);
            }
        }
        for (int i = 0; i < y; i++)
        {
            string[] tokens = Console.ReadLine()!.Split();
            for (int j = 0; j < x; j++)
            {
                Console.Write($"{arr[i, j] + int.Parse(tokens[j])} ");
            }
            Console.WriteLine();
        }
    }
}