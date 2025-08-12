public class ThreeSticks
{
    public void solution()
    {
        string[] tokens = Console.ReadLine()!.Split();
        int[] sides = new int[3];
        for(int i=0;i<3;i++)
            sides[i] = int.Parse(tokens[i]);
        Array.Sort(sides);
        if (sides[2] >= sides[0] + sides[1])
            sides[2] = sides[0] + sides[1] - 1;
        Console.WriteLine(sides[0] + sides[1] + sides[2]);
    }
}
