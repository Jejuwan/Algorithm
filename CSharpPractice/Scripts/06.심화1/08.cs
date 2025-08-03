public class YourScore
{
    public void solution()
    {
        double answer = 0;
        double hakjeomSum = 0;
        for (int i = 0; i < 20; i++)
        {
            string[] tokens = Console.ReadLine()!.Split();
            double pyeongjeom = 0;
            switch (tokens[2])
            {
                case "A+":
                    pyeongjeom = 4.5;
                    break;
                case "A0":
                    pyeongjeom = 4;
                    break;
                case "B+":
                    pyeongjeom = 3.5;
                    break;
                case "B0":
                    pyeongjeom = 3;
                    break;
                case "C+":
                    pyeongjeom = 2.5;
                    break;
                case "C0":
                    pyeongjeom = 2;
                    break;
                case "D+":
                    pyeongjeom = 1.5;
                    break;
                case "D0":
                    pyeongjeom = 1;
                    break;
                case "F":
                    pyeongjeom = 0;
                    break;
            }
            if (tokens[2] != "P")
            {
                answer += double.Parse(tokens[1]) * pyeongjeom;
                hakjeomSum += double.Parse(tokens[1]);
            }
        }
        answer /= hakjeomSum;
        Console.Write(answer);
    }
}