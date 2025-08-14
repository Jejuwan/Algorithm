 class MathisCorona
{
    public void solution()
    {
        int[] nums = Array.ConvertAll(Console.ReadLine()!.Split(),int.Parse);
        for(int x=-999;x<=999;x++)
        {
            for(int y=-999;y<=999;y++)
            {
                if (nums[0] * x + nums[1]*y == nums[2] &&
                    nums[3]*x + nums[4]*y == nums[5])
                {
                    Console.WriteLine($"{x} {y}");
                    break;
                }
            }
        }
    }
}
