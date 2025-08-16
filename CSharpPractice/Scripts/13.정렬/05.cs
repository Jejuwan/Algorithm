using System.Text;
class AlignNumber3
{
    public void solution()
    {
        var sr = new StreamReader(Console.OpenStandardInput());
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int n = int.Parse(sr.ReadLine()!);
        int[] arr = new int[10001];
        for (int i = 0; i < n; i++)
        {
            arr[int.Parse(sr.ReadLine()!)]++;
        }

        for(int i=1;i<=10000;i++)
        {
            for(int j = 0; j < arr[i];j++)
                sw.WriteLine(i.ToString());
        }
        sw.Flush();
    }
}

