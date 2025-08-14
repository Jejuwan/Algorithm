class ChessBoardRepaint
{
    (int, int)[] dir = { (-1, 0), (1, 0), (0, -1), (0, 1) };

    public void solution()
    {
        int[] nm = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        int row = nm[1];
        int col = nm[0];
        char[,] board = new char[row, col];
        for (int i = 0; i < col; i++)
        {
            string s = Console.ReadLine()!;
            for (int j = 0; j < s.Length; j++)
                board[j, i] = s[j];

        }
        int answer = 10000;

        for(int y = 0; y <= row-8; y++)
        {
            for(int x = 0;x<=col-8;x++)
            {
                int a = check('W', 'B', x, y, board);
                int b = check('B', 'W', x, y, board);
                int temp = a > b ? b : a;
                if (temp < answer) answer = temp;
            }
        }
 
        Console.WriteLine(answer);
    }

    public static int check(char c1, char c2,int sx, int sy, char[,] board)
    {
        int cnt = 0;
        //W,B
        for (int i = sy; i < sy+8; i++)
        {
            for (int j = sx; j < sx+8; j++)
            {

                int cur = board[i,j];
                //홀수행일때
                if (j % 2 == 1)
                {
                    //홀수 열일떄
                    if (i % 2 == 1)
                    {
                        if (cur != c1)
                            cnt++;
                    }
                    //짝수 열일때
                    else
                    {
                        if (cur != c2)
                            cnt++;
                    }
                }
                //짝수행일때
                else
                {
                    //홀수 열일떄
                    if (i % 2 == 1)
                    {
                        if (cur != c2)
                            cnt++;
                    }
                    //짝수 열일때
                    else
                    {
                        if (cur != c1)
                            cnt++;
                    }


                }
            }
        }
        return cnt;
    }




}
