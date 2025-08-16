using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

class CompressCoordinate
{
    public void solution()
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        int n = int.Parse(sr.ReadLine()!);
        int[] arr = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);

        int[] sorted = arr.Distinct().ToArray();
        Array.Sort(sorted);

        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < sorted.Length; i++)
            dict[sorted[i]] = i;

        var sb = new StringBuilder();
        for (int i = 0; i < arr.Length; i++)
        {
            sb.Append(dict[arr[i]]);
            if (i < arr.Length - 1) sb.Append(' ');
        }

        sw.WriteLine(sb.ToString()); 
    }
}
