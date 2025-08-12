public class TriangleAndThreeSide
{
    public void solution()
    {
        string answer = "";
        string[] tokens = Console.ReadLine()!.Split();
        while (tokens[0] != "0")
        {
            int[] angles = new int[3];
            int maxSide = 0;
            int maxValue = 0;
            for (int i = 0; i < 3; i++)
            {
                angles[i] = int.Parse(tokens[i]);
                if (maxValue < angles[i])
                {
                    maxValue = angles[i];
                    maxSide = i;
                }
            }

            if (angles[maxSide] < angles[0] + angles[1] + angles[2] - maxValue)
            {
                if (angles[0] == angles[1] && angles[1] == angles[2])
                    answer = "Equilateral";
                else if (angles[0] == angles[1] || angles[1] == angles[2] || angles[0] == angles[2])
                    answer = "Isosceles ";
                else
                    answer = "Scalene";
            }
            else
                answer = "Invalid";
            Console.WriteLine(answer);
            tokens = Console.ReadLine()!.Split();
        }

    }
}
