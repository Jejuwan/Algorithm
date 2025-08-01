using System.Text;
public class AplusB4
{
    public void solution()
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        string? line;
        while((line = sr.ReadLine()) != null)
        {
            string[] tokens = line!.Split();
            int a = int.Parse(tokens[0]);
            int b = int.Parse(tokens[1]);
            sw.WriteLine(a+b); 
        }
    }
}