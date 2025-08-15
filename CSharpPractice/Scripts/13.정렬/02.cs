class RepresentativeNumber
{
    public void solution()
    {
        int[] arr = new int[5];
        for (int i = 0; i < 5; i++)
        {
            arr[i] = int.Parse(Console.ReadLine()!);
        }
        Array.Sort(arr);
        int sum = 0;
        foreach (int i in arr)
        {
            sum += i;
        }
        Console.WriteLine(sum / 5);
        Console.WriteLine(arr[2]);
    }
}
