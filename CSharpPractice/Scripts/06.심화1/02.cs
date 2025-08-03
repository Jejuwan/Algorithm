public class KingQueenRookBishopKnightPawn
{
    public void solution()
    {
        int[] chess = new int[6] { 1, 1, 2, 2, 2, 8 };
        string[] tokens = Console.ReadLine()!.Split();
        for(int i=0; i<chess.Length;i++)
        {
            Console.Write($"{chess[i] - int.Parse(tokens[i])} ");
        }
    }
}