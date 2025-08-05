public class SnailWantsToClimb
{
    public void solution()
    {
        string[] tokens = Console.ReadLine()!.Split();
        int climb = int.Parse(tokens[0]);
        int slide = int.Parse(tokens[1]);
        int height = int.Parse(tokens[2]);

        int answer = 1;
        height -= climb;
        if (height > 0)
            answer += (int)Math.Ceiling((double)height / (climb - slide));
        Console.WriteLine(answer);
    }
}   