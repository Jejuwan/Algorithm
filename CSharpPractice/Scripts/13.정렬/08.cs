using System.Xml.Linq;

class AlignCoordinate2
{
    public void solution()
    {
        var sr = new StreamReader(Console.OpenStandardInput());
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int n = int.Parse(sr.ReadLine()!);
        (int, int)[] arr = new (int, int)[n];
        for (int i = 0; i < n; i++)
        {
            int[] xy = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);
            arr[i] = (xy[0], xy[1]);
        }
        Array.Sort(arr, (a, b) =>
        {
            if (a.Item2 != b.Item2)
                return a.Item2.CompareTo(b.Item2);
            return a.Item1.CompareTo(b.Item1);
        });

        foreach (var elem in arr)
        {
            sw.WriteLine($"{elem.Item1} {elem.Item2}");
        }
        sw.Flush();
    }
}

