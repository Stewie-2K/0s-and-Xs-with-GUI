using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0s_and_Xs_with_GUI
{
    class Board
    {
        // private string[,] or string[]
        private char[,] board = new char[3, 3];

        public Board()
        {
            // Add " " to each position board
            clearBoard();
        }

        public void clearBoard()
        {
            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    board[y, x] = ' ';
                }
            }
        }

        public char[,] GetBoard()
        {
            return board;
        }
        
        public bool addCounter(int player, int[] Position)
        {
            //Player should be passed as either 1 or 2, not 0 or 1
            //Player 1 is X, Player 2 is O
            bool Placed = false;
            if (board[Position[0], Position[1]] == ' ')
            {
                if (player == 1)
                {
                    board[Position[0], Position[1]] = 'X';
                }
                if (player == 2)
                {
                    board[Position[0], Position[1]] = 'O';
                }
                Placed = true;
            }
            return Placed;
        }

        public int checkwin()
        {
            int Status = 0;
            bool Draw = true;
            // 0 - Not Done
            // 1 - X wins
            // 2 - O wins
            // 3 - Draw

            //Check for draw
            if (Draw == true && Status == 0)
            {
                for (int y = 0; y < 3; y++)
                {
                    for (int x = 0; x < 3; x++)
                    {
                        if (board[y, x] == ' ')
                        {
                            Draw = false;
                        }
                    }
                }
            }

            //Check for win on x Axis
            for (int y = 0; y < 3; y++)
            {
                if (board[y, 0] != ' ')
                {
                    if (board[y, 0] == board[y, 1] && board[y, 1] == board[y, 2])
                    {
                        if (board[y, 0] == 'X')
                        {
                            Status = 1;
                        }
                        if (board[y, 0] == 'O')
                        {
                            Status = 2;
                        }
                    }
                }
            }

            //Check for win on y Axis
            for (int x = 0; x < 3; x++)
            {
                if (board[0, x] != ' ')
                {
                    if (board[0, x] == board[1, x] && board[1, x] == board[2, x])
                    {
                        if (board[x, 0] == 'X')
                        {
                            Status = 1;
                        }
                        if (board[x, 0] == 'O')
                        {
                            Status = 2;
                        }
                    }
                }
            }

            //Check for diagonal wins
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                if (board[1, 1] == 'X')
                {
                    Status = 1;
                }
                if (board[1, 1] == 'O')
                {
                    Status = 2;
                }
            }
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                if (board[1, 1] == 'X')
                {
                    Status = 1;
                }
                if (board[1, 1] == 'O')
                {
                    Status = 2;
                }
            }


            if (Draw == true)
            {
                Status = 3;
            }

            return Status;
        }
    }
}
