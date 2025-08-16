using System.Xml.Linq;

class AlignCoordinate
{
    public void solution()
    {
        int n = int.Parse(Console.ReadLine()!);
        (int, int)[] arr = new (int, int)[n];
        for (int i = 0; i < n; i++)
        {
            int[] xy = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            arr[i] = (xy[0], xy[1]);
        }
        Array.Sort(arr, (a, b) =>
        {
            if(a.Item1!=b.Item1)
                return a.Item1.CompareTo(b.Item1);
            return a.Item2.CompareTo(b.Item2);
        });

        foreach (var elem in arr)
        {
            Console.WriteLine($"{elem.Item1} {elem.Item2}");
        }
    }
}

