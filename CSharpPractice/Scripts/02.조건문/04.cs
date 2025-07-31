public class Quadrant
{
    public void solution()
    {
        string? input = Console.ReadLine();
        string? input2 = Console.ReadLine();
        int x = int.Parse(input!);
        int y = int.Parse(input2!);

        int quadrant = 0;
        if (x > 0 && y > 0)
            quadrant = 1;
        else if (x < 0 && y > 0)
            quadrant = 2;
        else if (x < 0 && y < 0)
            quadrant = 3;
        else if (x > 0 && y < 0)
            quadrant = 4;

        Console.WriteLine(quadrant);
    }
}