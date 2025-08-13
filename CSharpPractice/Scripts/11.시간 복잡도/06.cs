class AlgorithmClass6
{
    public void solution()
    {
        string[] tokens = Console.ReadLine()!.Split();
        int a1 = int.Parse(tokens[0]);
        int a0 = int.Parse(tokens[1]);
        int c = int.Parse(Console.ReadLine()!);
        int n0 = int.Parse(Console.ReadLine()!);


        int fn = a1 * n0 + a0;
        int ans = (fn <= c * n0 && a1<=c) ? 1 : 0;

        Console.WriteLine(ans);


    }
}
