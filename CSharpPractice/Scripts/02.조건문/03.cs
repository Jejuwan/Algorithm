public class YoonYear
{
    public void solution()
    {
        string? input = Console.ReadLine();
        int year = int.Parse(input!);

        int yoon;
        if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            yoon = 1;
        else
            yoon = 0;

        Console.WriteLine(yoon);
    }
}