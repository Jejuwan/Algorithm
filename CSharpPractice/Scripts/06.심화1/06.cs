public class CroatiaAlphabet
{
    public void solution()
    {
        string[] cr = new string[8] { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };
        string s = Console.ReadLine()!;

        int answer = 0;
        foreach (string c in cr)
        {
            while (s.Contains(c))
            {
                s = s.Replace(c, " ");
            }
        }
        
        answer += s.Length;
        Console.WriteLine(answer);
    }
}