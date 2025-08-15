class Cutline
{
    public void solution()
    {
        int[] arr = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        int[] scores = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

        Array.Sort(scores, (a, b) => b.CompareTo(a));

        Console.WriteLine(scores[arr[1] - 1]);
    }
}
