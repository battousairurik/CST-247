using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrationAndLogin.Models
{
    public class GameBoard
    {
        //private GameCell[,] gameCells;
        public GameCell[,] GameCells { get; set; }
        public GameBoard(int boardsize)
        {
            GameCells = new GameCell[boardsize, boardsize];
        }

        
    }
}