using System.Runtime.InteropServices;

public class PrintStar7
{
    public void solution()
    {
        int n = int.Parse(Console.ReadLine()!);
        for(int i=0;i<n-1;i++)
        {
            for(int j=0;j<n-(i+1);j++)
            {
                Console.Write(' ');
            }

            for(int j=0;j<i*2+1;j++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }

        for (int i = 0; i < n * 2 - 1; i++)
        {
            Console.Write('*');
        }
        Console.WriteLine();

        for (int i = n - 2; i >= 0; i--)
        {
            for (int j = 0; j < n - (i + 1); j++)
            {
                Console.Write(' ');
            }

            for (int j = 0; j < i * 2 + 1; j++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }
    }
}