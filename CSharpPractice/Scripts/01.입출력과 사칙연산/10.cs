public class Multiply
{
    public void solution()
    {
        string? input = Console.ReadLine();
        string? input2= Console.ReadLine();
        int A = int.Parse(input!);
        int B = int.Parse(input2!);
        int Bhun= int.Parse(input2![0].ToString());
        int Bten = int.Parse(input2![1].ToString());
        int Bone = int.Parse(input2![2].ToString());

        Console.WriteLine(A*Bone);
        Console.WriteLine(A*Bten);
        Console.WriteLine(A*Bhun);
        Console.WriteLine(A * B);
    }
}