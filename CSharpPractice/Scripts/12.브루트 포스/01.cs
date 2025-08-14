 class Blackjack
{
    public void solution()
    {
        string[] tokens = Console.ReadLine()!.Split();
        int n = int.Parse(tokens[0]);
        int m = int.Parse(tokens[1]);
        int[] cards = new int[n];
        int answer = -1;
        int minDiff = 300001;
        string[] elems = Console.ReadLine()!.Split();
        for(int i=0;i<elems.Length; i++)
            cards[i] = int.Parse(elems[i]);
        for (int i = 0; i < n; i++)
        {
            for(int j=i+1;j < n; j++)
            {
                for(int k=j+1;k < n; k++)
                {
                    int diff = m - (cards[i] + cards[j] + cards[k])
                        ;
                    if (diff <minDiff && diff>=0)
                    {
                        minDiff = diff;
                        answer = cards[i] + cards[j] + cards[k];
                    }
                }
            }
        }
        Console.WriteLine(answer);
    }
}
