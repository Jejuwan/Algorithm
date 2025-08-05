public class LaundryDonghyuk
{
    public void solution()
    {
        int[] coin = new int[4] { 25, 10, 5, 1 };
        int n = int.Parse(Console.ReadLine()!);
        for (int i = 0; i < n; i++)
        {
            int[] result = new int[4];
            int money = int.Parse(Console.ReadLine()!);
            for (int j = 0; j < 4; j++)
            {
                result[j] = money / coin[j];
                money = money % coin[j];
            }
            for(int j=0;j<4;j++)
                Console.Write($"{result[j]} ");
            Console.WriteLine();
        }
    }
}   