public class GooGooDan
{
    public void solution()
    {
       int A = int.Parse(Console.ReadLine()!);

        for(int i=1; i <=9;i++)
        {
            Console.WriteLine($"{A} * {i} = {A * i}");
        }
    }
}