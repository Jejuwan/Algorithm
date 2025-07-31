public class TwoNumCompare
{
    public void solution()
    {
        string? input = Console.ReadLine();
        string[] token = input!.Split();
        int A = int.Parse(token[0]);
        int B = int.Parse(token[1]);

        string answer = "";
        if (A > B)
            answer = ">";
        else if (A < B)
            answer = "<";
        else if (A == B)
            answer = "==";

        Console.WriteLine(answer);
    }
}