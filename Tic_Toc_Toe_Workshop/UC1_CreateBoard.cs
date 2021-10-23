using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Toc_Toe_Workshop
{
   public  class UC1_CreateBoard
    {


       
        public static char[] Create_Board()
        {
            char[] board = new char[10];
                for(int i = 0; i < board.Length; i++)
            {
                board[i] =' ';
            }
            return board;
        }
    }
}
