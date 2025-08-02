public class FindAlphabet
{
    public void solution()
    {
        string str = Console.ReadLine()!;

        int[] arr = new int[26];
        for (int i = 0; i < 26; i++) arr[i] = -1;
        for (int i = 0; i < str.Length; i++)
        {
            if (arr[str[i]-'a'] == -1)
            {
                arr[str[i] - 'a'] = i;
            }
        }

        foreach(var elem in arr)
        {
            Console.Write($"{elem} ");
        }
    }
}