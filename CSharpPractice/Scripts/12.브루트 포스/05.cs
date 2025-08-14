class MovieDirectorShom
{
    public void solution()
    {
        int n = int.Parse(Console.ReadLine()!);
        int num = 0;
        for (int i = 1; ; i++)
        {
            string s = i.ToString();
            if (!s.Contains("666"))
                continue;
            num++;

            if (num == n)
            {
                Console.WriteLine(i);
                return;
            }
        }
    }
}
