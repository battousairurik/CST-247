using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrationAndLogin.Models
{
    public class GameBoard
    {
        public GameCell[,] GameCells { get; set; }
        public int BoardSize { get; set; }

        public GameBoard(int boardsize)
        {
            BoardSize = boardsize;
            GameCells = new GameCell[boardsize, boardsize];
        }

        
    }
}