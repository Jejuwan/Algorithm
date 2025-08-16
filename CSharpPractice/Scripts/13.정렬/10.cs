using System.Xml.Linq;

class AlignAge
{
    public void solution()
    {
        var sr = new StreamReader(Console.OpenStandardInput());
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int n = int.Parse(sr.ReadLine()!);
        (int, int, string)[] strArr = new (int, int, string)[n];
        for (int i = 0; i < n; i++)
        {
            string[] tokens = sr.ReadLine()!.Split();
            strArr[i] = (i, int.Parse(tokens[0]), tokens[1]);
        }

        Array.Sort(strArr, (a, b) =>
        {
            if (a.Item2 != b.Item2)
                return a.Item2.CompareTo(b.Item2);
            return a.Item1.CompareTo(b.Item1);
        });
        for (int i = 0; i < strArr.Length; i++)
        {

            sw.WriteLine($"{strArr[i].Item2} {strArr[i].Item3}");
        }
        sw.Flush();
    }
}

