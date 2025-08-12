public class FourthPoint
{
    public void solution()
    {
        Dictionary<int,int> setX = new Dictionary<int, int>();
        Dictionary<int, int> setY = new Dictionary<int, int>();
        int answerX = 0,answerY = 0;
        for(int i=0;i<3;i++)
        {
            string[] tokens = Console.ReadLine()!.Split();
            int x = int.Parse(tokens[0]);
            int y = int.Parse(tokens[1]);

            if (setX.ContainsKey(x))
                setX[x]++;
            else
                setX.Add(x, 1);
            if (setY.ContainsKey(y))
                setY[y]++;
            else
                setY.Add(y, 1);
        }

        foreach (var x in setX)
        {
            if (x.Value == 1)
                answerX = x.Key;
        }
        foreach (var y in setY)
        {
            if (y.Value == 1)
                answerY = y.Key;
        }
        Console.WriteLine($"{answerX} {answerY}");
    }
}
