using System.Xml.Linq;

class AlignWord
{
    public void solution()
    {
        var sr = new StreamReader(Console.OpenStandardInput());
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int n = int.Parse(sr.ReadLine()!);
        string[] strArr = new string[n];
        for (int i = 0; i < n; i++)
        {
            strArr[i] = sr.ReadLine()!;
        }
  
        Array.Sort(strArr, (a, b) =>
        {
            if (a.Length != b.Length)
                return a.Length.CompareTo(b.Length);
            return a.CompareTo(b);
        });
        sw.WriteLine(strArr[0]);
        for (int i = 1; i < strArr.Length; i++)
        {
            if (strArr[i] != strArr[i-1])
                sw.WriteLine(strArr[i]);
        }
        sw.Flush();
    }
}

