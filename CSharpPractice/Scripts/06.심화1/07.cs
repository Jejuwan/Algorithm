public class GroupWordChecker
{
    public void solution()
    {
        int n = int.Parse(Console.ReadLine()!);
        int answer = n;
        for (int i = 0; i < n; i++)
        {
            char[] arr = new char[26];
            string str = Console.ReadLine()!;

            for(int j=0;j<str.Length;j++)
            {
                if (arr[str[j] - 'a'] != 0 && j>0 && str[j-1] != str[j])
                {
                    answer--;
                    break;
                }
                arr[str[j] - 'a']++;
            }
        }
        Console.WriteLine(answer);
    }
}