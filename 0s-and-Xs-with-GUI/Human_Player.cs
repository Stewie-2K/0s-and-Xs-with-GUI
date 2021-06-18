using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0s_and_Xs_with_GUI
{
    class Human_Player : Player
    {
       
        public Human_Player()
        {

        }
        public override int[] Move(int boardPos)
        {
            int[] Coordinates = new int[2];
            Coordinates[0] = (boardPos - 1) / 3;
            Coordinates[1] = (boardPos - 1) % 3;
            return Coordinates;
        }       
    }
}
