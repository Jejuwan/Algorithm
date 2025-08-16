using System.Text;
class SortInside
{
    public void solution()
    {
        string str = Console.ReadLine()!;
        List<int> list = new List<int>();
        foreach(char c in str)
        {
            list.Add(c - '0');
        }
        list.Sort((a,b)=>b.CompareTo(a));
        string answer = "";
        foreach (int i in list)
            answer += (char)(i + '0');

        Console.WriteLine(answer);
    }
}

