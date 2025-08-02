using System.Text;
public class AplusB5
{
    public void solution()
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        for(;;)
        {
            string[] tokens = sr.ReadLine()!.Split();
            int a = int.Parse(tokens[0]);
            int b = int.Parse(tokens[1]);
            if (a == 0 && b == 0)
                break;
            sw.WriteLine(a+b); 
        }
    }
}