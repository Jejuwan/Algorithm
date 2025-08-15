using System.Text;
class AlignNumber3
{
    public static void Main(string[] args)
    {
        var sr = new StreamReader(Console.OpenStandardInput());
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int n = int.Parse(sr.ReadLine()!);
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(sr.ReadLine()!);
        }
        Array.Sort(arr);

        var sb = new StringBuilder();

        foreach (int i in arr)
            sb.AppendLine(i.ToString());

        sw.Write(sb.ToString());
        sw.Flush();
    }
}

