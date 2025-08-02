public class Dial
{
    public void solution()
    {
        char[] arr = new char[26];
        string s = Console.ReadLine()!;

        int answer = 0;
        for(int i=0;i<s.Length;i++)
        {
            if (s[i] <= 'C')
                answer += 3;
            else if (s[i] <= 'F')
                answer += 4;
            else if (s[i] <= 'I')
                answer += 5;
            else if (s[i] <= 'L')
                answer += 6;
            else if (s[i] <= 'O')
                answer += 7;
            else if (s[i] <= 'S')
                answer += 8;
            else if (s[i] <= 'V')
                answer += 9;
            else if (s[i] <= 'Z')
                answer += 10;
        }
        Console.WriteLine(answer);
    }
}