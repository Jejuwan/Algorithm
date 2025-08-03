public class WordStudy
{
    public void solution()
    {
        int[] arr = new int[26];
        string s = Console.ReadLine()!;
        foreach(var c in  s)
        {
            int idx = c;
            if (idx < 'a')
                idx += 'a' - 'A';
            idx -= 'a';
            arr[idx]++;
        }

        int maxVal = -1;
        char maxElem = '.';
        int maxCount = 0;
        for(int i=0;i<26;i++)
        {
            if (arr[i] > maxVal)
            {
                maxVal = arr[i];
                maxCount = 1;
                maxElem = (char)(i + 'A');
            }
            else if(arr[i] == maxVal)
            {
                maxCount++;
            }
        }

        if (maxCount > 1)
            Console.WriteLine('?');
        else
            Console.WriteLine(maxElem);
    }
}