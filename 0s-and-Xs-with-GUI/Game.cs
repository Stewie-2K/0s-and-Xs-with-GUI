using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0s_and_Xs_with_GUI
{
    class Game
    {
        private Player[] Players = new Player[2];
        private Board b = new Board();
        private int who = 0;

        public void choosePlayers(int Choice)
        {
            if (Choice == 0)
            {
                Players[0] = new Human_Player();
                Players[1] = new Human_Player();
            }
            if (Choice == 1)
            {
                Players[0] = new AI_Player(b, Choice);
                Players[1] = new Human_Player();
            }
            if (Choice == 2)
            {
                Players[0] = new Human_Player();
                Players[1] = new AI_Player(b, Choice);
            }
        }
        public void reset()
        {
            b.clearBoard();
            who = 0;
        }

        public char[,] getBoard()
        {
            return b.GetBoard();
        }

        public int Update(int boardPos)
        {
            bool Placed;
            
            if(b.checkwin() == 0)
            {
                Placed = b.addCounter((who % 2) + 1, Players[who % 2].Move(boardPos));
                if(Placed == true)
                {
                    who++;
                }               
            }
            return b.checkwin();
        }
    }


}
