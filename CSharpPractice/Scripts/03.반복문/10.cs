using System.Text;
public class PrintStar2
{
    public void solution()
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        int t = int.Parse(sr.ReadLine()!);

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < t; i++)
        {
            string s = "";
            for(int j=0;j<t-i - 1;j++)
            {
                s += ' ';
            }
            for (int k=0;k<=i;k++)
            {
                s += '*';
            }
            Console.WriteLine(s);
        }
    }
}