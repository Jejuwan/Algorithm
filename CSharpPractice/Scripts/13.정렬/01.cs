 class AlignNumber
{
    public void solution()
    { 
        int[] arr = new int[5];
        for(int i=0;i<5;i++)
        {
            arr[i] = int.Parse(Console.ReadLine()!);
        }
        Array.Sort(arr);
        foreach (int i in arr)
            Console.WriteLine(i);
    }
}

