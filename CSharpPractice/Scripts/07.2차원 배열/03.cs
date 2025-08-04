public class VerticalReading
{
    public void solution()
    {
        char[,] arr = new char[5,15];
        for(int i=0;i<5;i++)
        {
            string str = Console.ReadLine()!;
            for(int j=0;j<str.Length;j++)
                arr[i,j] = str[j];
        }

        for (int i = 0; i < 15; i++)
        { 
            for (int j = 0; j < 5; j++)
            {
                if (arr[j,i]!=0)
                {
                    Console.Write(arr[j, i]);
                }
            }    
        }
    }
}