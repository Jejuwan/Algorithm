public class EscapeFromRectangle
{
    public void solution()
    {
        string[] tokens = Console.ReadLine()!.Split();
        int x = int.Parse(tokens[0]);
        int y = int.Parse(tokens[1]);
        int w = int.Parse(tokens[2]);
        int h = int.Parse(tokens[3]);

        int minX = x < w - x ? x : w-x;
        int minY = y < h - y ? y : h-y;
        int answer = minX < minY? minX : minY;
        Console.WriteLine(answer);
    }
}
