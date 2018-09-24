using RegistrationAndLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrationAndLogin.Controllers
{
    public class GameBoardController
    {
        public int LiveNodes { get; set; }
        private Random random = new Random();
        private GameBoard gameCells;

        public GameBoardController(GameBoard _gameCells)
        {
            gameCells = _gameCells;
            FillGameBoard();
        }

        private void FillGameBoard()
        {
            for (int i = 0; i < gameCells.GameCells.GetLength(0); i++)
            {
                for (int j = 0; j < gameCells.GameCells.GetLength(1); j++)
                {
                    GameCell gameCell = new GameCell
                    {
                        Row = i,
                        Column = j,
                        IsLive = DetermineIsLive()
                    };
                    if (gameCell.IsLive)
                        LiveNodes++;
                    gameCells.GameCells[i, j] = gameCell;
                }
            }
            DetermineLiveNeighbors();
        }

        private Boolean DetermineIsLive()
        {
            int x = random.Next(101);
            if (x > 80)
                return true;
            else
                return false;
        }
        //Method to determine number of live neighbors
        private void DetermineLiveNeighbors()
        {
            for (int i = 0; i < gameCells.GameCells.GetLength(0); i++)
            {
                for (int j = 0; j < gameCells.GameCells.GetLength(1); j++)
                {
                    //Method field to determine num neighbors
                    int x = 0;
                    //Clause to check is cell is live
                    if (gameCells.GameCells[i, j].IsLive == true)
                        x = 9;
                    else
                    {
                        x += CheckNeighbors(i - 1, j - 1);
                        x += CheckNeighbors(i - 1, j);
                        x += CheckNeighbors(i - 1, j + 1);
                        x += CheckNeighbors(i, j - 1);
                        x += CheckNeighbors(i, j + 1);
                        x += CheckNeighbors(i + 1, j - 1);
                        x += CheckNeighbors(i + 1, j);
                        x += CheckNeighbors(i + 1, j + 1);
                    }
                    //Set num neighbors
                    gameCells.GameCells[i, j].Neighbors = x;
                }
            }
        }
        //Method to validate each neighbor around cell and ensure that only valid array bounds are considered
        private int CheckNeighbors(int x, int y)
        {
            if (x > -1 && y > -1)
            {
                if (x < this.gameCells.GameCells.GetLength(0) && y < this.gameCells.GameCells.GetLength(0))
                {
                    if (gameCells.GameCells[x, y].IsLive == true)
                        return 1;
                }
            }
            return 0;
        }
    }
}