// Author: Michael Weaver
// Grand Canyon University
// CST - 227

// Description: This class contains all logic to create a Mine Sweeper game board. An array of cells is used
//      as the boards base, cells generated with a random chance of being live mines. 

using System;
using MineSweeper.GenericsInterfaces;

namespace MineSweeper.Models
{
    class MineSweeperGameBoard: AGameBoard
    {
        private Cell[,] cells;
        public Cell[,] GetCells { get => cells; }
        protected int liveNodes;
        public int GetLiveNodes { get => liveNodes; }
        private Boolean gameBoardInitialize;
        public Boolean BoardState { get => gameBoardInitialize; }

        private Random random = new Random();

        public MineSweeperGameBoard(int gameBoardSize, int minSize, int maxSize):
            base (gameBoardSize, minSize, maxSize)
        {
            DetermineBoardSize(gameBoardSize, minSize, maxSize);
            cells = new Cell[gameBoardSize, gameBoardSize];
            PopulateBoard();
        }

        public MineSweeperGameBoard (int boardSize): base (boardSize)
        {
            cells = new Cell[boardSize, boardSize];
            PopulateBoard();
        }
        //Method to validate board size, min size, and max size
        private void DetermineBoardSize(int boardSize, int minSize, int maxSize)
        {
            if (boardSize < minSize)
            {
                throw new ApplicationException("invalid parameter, board size cannot be less than " + minSize + ".");
            }
            if (boardSize > maxSize)
            {
                throw new ApplicationException("invalid parameter, board size cannot be greater than " + maxSize + ".");
            }
            gameBoardInitialize = true;
        }

        protected override void PopulateBoard()
        {
            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for (int j = 0; j < cells.GetLength(1); j++)
                {
                    Cell gameCell = new Cell(i, j);
                    gameCell.IsLive = DetermineIsLive();
                    if (gameCell.IsLive)
                        liveNodes++;
                    cells[i, j] = gameCell;
                }
            }
            DetermineLiveNeighbors();
        }

        private Boolean DetermineIsLive()
        {
            int x = random.Next(101);
            if (x > 99)
                return true;
            else
                return false;
        }
        //Method to determine number of live neighbors
        private void DetermineLiveNeighbors()
        {
            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for (int j = 0; j < cells.GetLength(1); j++)
                {
                    //Method field to determine num neighbors
                    int x = 0;
                    //Clause to check is cell is live
                    if (cells[i, j].IsLive == true)
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
                    cells[i, j].Neighbors = x;
                }
            }
        }
        //Method to validate each neighbor around cell and ensure that only valid array bounds are considered
        private int CheckNeighbors(int x, int y)
        {
            if (x > -1 && y > -1)
            {
                if (x < this.gameBoardSize && y < this.gameBoardSize)
                {
                    if (cells[x, y].IsLive == true)
                        return 1;
                }
            }
            return 0;
        } 
    }
}
