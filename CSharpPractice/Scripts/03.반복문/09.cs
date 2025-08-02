using System.Text;
public class PrintStar1
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
            for (int j=0;j<=i;j++)
            {
                s += '*';
            }
            Console.WriteLine(s);
        }
    }
}