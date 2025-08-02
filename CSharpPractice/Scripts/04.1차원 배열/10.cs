public class Average
{
    public void solution()
    {
        int N = int.Parse(Console.ReadLine()!);
        double[] score = new double[N];
        double[] newScore = new double[N];
        double max = -1;

        string[] tokens = Console.ReadLine()!.Split();
        for(int i=0;i<N;i++)
        {
            score[i] = double.Parse(tokens[i]);
            if (max < score[i])
                max = score[i];
        }

        double answer = 0;
        for (int i = 0; i < N; i++)
        {           
            answer += score[i] / max * 100;
        }
        answer /= N;
        Console.WriteLine(answer);
    }
}