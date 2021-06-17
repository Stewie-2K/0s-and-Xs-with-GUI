using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0s_and_Xs_with_GUI
{
    class Human_Player : Player
    {
        private int boardPos;
        private int[] Coordinates = new int[2];
        public Human_Player()
        {

        }
        public override int[] Move()
        {
            Console.WriteLine("Enter Board Position 1-9");
            boardPos = Convert.ToInt32(Console.ReadLine());
            Coordinates[0] = (boardPos - 1) / 3;
            Coordinates[1] = (boardPos - 1) % 3;
            return Coordinates;
        }       
    }
}
