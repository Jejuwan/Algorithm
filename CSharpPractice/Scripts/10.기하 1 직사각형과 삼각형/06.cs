public class MemoryTriangle
{
    public void solution()
    {
        int[] angles = new int[3];
        for (int i = 0; i < 3; i++)
        {
            angles[i] = int.Parse(Console.ReadLine()!);
        }

        string answer = "";
        if (angles[0] + angles[1] + angles[2] == 180)
        {
            if (angles[0] == 60 && angles[1] == 60)
                answer = "Equilateral";
            else if (angles[0] == angles[1] ||
                angles[1] == angles[2] ||
                angles[0] == angles[2])
                answer = "Isosceles";
            else
                answer = "Scalene";
        }
        else
            answer = "Error";

        Console.WriteLine(answer);
    }
}
