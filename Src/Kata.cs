using System;
using System.Linq;

namespace Src
{
    public static class Kata
    {
        public static int IsSolved(int[,] board)
        {
            // Check win on rows
            for(int i = 0; i < board.GetLength(0); i++)
            {
                if(((board[i, 0] == board[i, 1]) && (board[i, 0] == board[i, 2])) && board[i, 0] != 0)
                {
                    return board[i, 0];
                }
            }

            // Check win on columns
            for(int i = 0; i < board.GetLength(1); i++)
            {
                if(((board[0, i] == board[1, i]) && (board[0, i] == board[2, i])) && board[0, i] != 0)
                {
                    return board[0, i];
                }
            }

            // Check win on down diagonal
            if(((board[0, 0] == board[1, 1]) && (board[0, 0] == board[2, 2])) && board[0, 0] != 0)
            {
                return board[0, 0];
            }

            // Check win on up diagonal
            if(((board[0, 2] == board[1, 1]) && (board[0, 2] == board[2, 0])) && board[0, 2] != 0)
            {
                return board[0, 2];
            }

            // Check incomplete board
            for(int i = 0; i < board.GetLength(0); i++)
            {
                for(int j = 0; j < board.GetLength(1); j++)
                {
                    if(board[i, j] == 0)
                    {
                        return -1;
                    };
                }
            }

            // Game's a draw
            return 0;
        }
    }
}
