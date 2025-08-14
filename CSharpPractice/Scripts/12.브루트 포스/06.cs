class SugarDelivery
{
    public void solution()
    {
        int n = int.Parse(Console.ReadLine()!);

        int answer = 5001;
        for(int i=0;i*3 <=n;i++)
        {
            int three = 3 * i;
            if((n-three)%5==0)
            {
                int cur =(n - three) / 5 + i;
                if(cur < answer)
                {
                    answer = cur;
                }
            }
        }
        if (answer == 5001)
            answer = -1;
        Console.WriteLine(answer);
    }
}
