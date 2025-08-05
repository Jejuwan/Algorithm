public class CenterMoveAlgorithm
{
    public void solution()
    {
        int n = int.Parse(Console.ReadLine()!);
        int side = (int)Math.Pow(2, n) + 1;
        Console.WriteLine((int)Math.Pow(side, 2));
    }
}   