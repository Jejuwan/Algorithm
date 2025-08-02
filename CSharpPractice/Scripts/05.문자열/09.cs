public class Const
{
    public void solution()
    {
        string[] tokens = Console.ReadLine()!.Split();
        int[] nums = new int[2];
        for (int i = 0; i < tokens.Length; i++)
        {
            char[] charArr = tokens[i].ToCharArray();
            char temp = charArr[0];
            charArr[0] = charArr[2];
            charArr[2] = temp;
            string s = "";
            for (int j = 0; j < 3; j++)
                s += charArr[j];
            nums[i] = int.Parse(s);
        }

        int answer = nums[0] > nums[1] ? nums[0] : nums[1];
        Console.WriteLine(answer);
    }
}