public class TestScore
{
    public void solution()
    {
        string? input = Console.ReadLine();
        int score = int.Parse(input!);

        char answer = ' ';
        if (score >= 90)
            answer = 'A';
        else if (score >= 80)
            answer = 'B';
        else if (score >= 70)
            answer = 'C';
        else if (score >= 60)
            answer = 'D';
        else
            answer = 'F';

        Console.WriteLine(answer);
    }
}