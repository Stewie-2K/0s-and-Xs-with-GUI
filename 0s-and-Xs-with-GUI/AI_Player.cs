using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0s_and_Xs_with_GUI
{
    class AI_Player : Player
    {
        private Board b;
        private char[,] board;
        private int[] Coordinates = new int[2];
        private int Which; //Whether AI is X or O. 1 = X, 2 = O
        public AI_Player(Board board, int c)
        {
            b = board;
            this.board = b.GetBoard();
            Which = c;
        }
        public override int[] Move(int x)
        {
            int bestVal = -1000;
            int Current = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == ' ')
                    {
                        if (Which == 1)
                        {
                            board[i, j] = 'X';
                        }
                        if (Which == 2)
                        {
                            board[i, j] = 'O';
                        }
                        Current = minimax(false);
                        if (Current > bestVal)
                        {
                            bestVal = Current;
                            Coordinates[0] = i;
                            Coordinates[1] = j;
                        }
                        board[i, j] = ' ';
                    }
                }
            }
            return Coordinates;

            /*
            Console.WriteLine("Enter Board Position 1-9");
            boardPos = Convert.ToInt32(Console.ReadLine());
            Coordinates[0] = (boardPos - 1) / 3;
            Coordinates[1] = (boardPos - 1) % 3;
            return Coordinates;
            */
        }
        public int evaluate()
        {
            if (b.checkwin() == Which)
            {
                return +10;
            }
            if (b.checkwin() == 3)
            {
                return 0;
            }
            if (b.checkwin() != 0)
            {
                return -10;
            }
            return -1;
        }
        public int minimax(bool isMax)
        {
            int score = -1;
            score = evaluate();
            if (score == 10)
            {
                return score;
            }
            if (score == -10)
            {
                return score;
            }
            if (score == 0)
            {
                return 0;
            }
            if (isMax)
            {
                int best = -1000;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (board[i, j] == ' ')
                        {
                            if (Which == 1)
                            {
                                board[i, j] = 'X';
                            }
                            if (Which == 2)
                            {
                                board[i, j] = 'O';
                            }
                            best = Math.Max(best, minimax(!isMax));
                            board[i, j] = ' ';
                        }
                    }
                }
                return best;
            }
            else
            {
                int best = 1000;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (board[i, j] == ' ')
                        {
                            if (Which == 1)
                            {
                                board[i, j] = 'O';
                            }
                            if (Which == 2)
                            {
                                board[i, j] = 'X';
                            }
                            best = Math.Min(best, minimax(!isMax));
                            board[i, j] = ' ';
                        }
                    }
                }
                return best;
            }

            //https://www.geeksforgeeks.org/minimax-algorithm-in-game-theory-set-3-tic-tac-toe-ai-finding-optimal-move/
            //Website with assistance ^
        }
    }
}
