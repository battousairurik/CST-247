// Author: Michael Weaver
// Grand Canyon University
// CST - 227

// Description: This class contains all of the logic to run the mine sweeper game itself. 

using MineSweeper.ObjectModels;
using MineSweeper.UserInterfaces;
using System;

namespace MineSweeper.ExecutionLogic
{
    class MineSweeperConsoleGame: IPlayable
    {
        //Default min and max size part of this minesweeper game
        private static int defaultMinSize = 1;
        private static int defaultMaxSize = 50;

        private bool activeGame = true;
        public void SetActiveGame (bool value) { activeGame = value; }
        private bool validInput = false;
        private bool gameWinner = false;
        private int validSelectionTally;
        private int nodeTotal;
        private int rowSelection;
        private int columnSelection;
        private int boardSize;

        private MineSweeperConsole sweeperConsole = new MineSweeperConsole();

        private MineSweeperGameBoard mineSweeperGameBoard;

        public MineSweeperConsoleGame()
        {
            InitializeGame();
        }
        /*
        public MineSweeperConsoleGame(int boardSize)
        {
            this.boardSize = boardSize;
            mineSweeperGameBoard = new MineSweeperGameBoard(boardSize);
            activeGame = false;
            DisplayBoard();
        }
        */
        private void InitializeGame()
        {

            sweeperConsole.DisplayConsoleMessage("Enter board size between " + defaultMinSize + " and "
                + defaultMaxSize);
            boardSize = sweeperConsole.GetConsoleInt();
            mineSweeperGameBoard = new MineSweeperGameBoard(boardSize, defaultMinSize, defaultMaxSize);

            int x = mineSweeperGameBoard.GetCells.GetLength(0);
            nodeTotal = x * x;
        }

        public void PlayGame()
        {
            //Logic to allow user to play until they hit a mine
            while (activeGame)
            {
                validInput = false;
                sweeperConsole.ClearTheConsole();
                DisplayBoard();
                while (!validInput)
                    TakeTurn();
                validInput = false;
                CheckSelectionCell(rowSelection, columnSelection);
                DetermineSelectionTally();
            }
            //Code for when user looses the game
            if (!gameWinner)
            {
                Console.Clear();
                DisplayBoard();
                Console.WriteLine("Good try, better luck next time.");
            }
            //Code for when the user wins the game
            else
            {
                Console.Clear();
                DisplayBoard();
                Console.WriteLine("Congratulations, You've won!");
            }
        }

        public void TakeTurn()
        {
            try
            {
                UserTurnInput();
            }
            catch (Exception ex)
            {
                sweeperConsole.DisplayConsoleMessage(ex.Message);
                validInput = false;
            }
            validInput = true;
        }
        // Method to retrieve user input. Note: Will be moved to console class in the future
        public void UserTurnInput()
        {
            sweeperConsole.DisplayConsoleMessage("Row Selection: ");
            rowSelection = sweeperConsole.GetConsoleInt();
            sweeperConsole.DisplayConsoleMessage("Col Selection: ");
            columnSelection = sweeperConsole.GetConsoleInt();
        }

        public void SetRowColumnInput(int row, int column)
        {
            this.rowSelection = row;
            this.columnSelection = column;
        }
        // Method to display the board to console. Note: Will be moved to console class in the future and replaced
        // with a retrieve cell method.
        public void DisplayBoard()
        {
            for (int row = 0; row < mineSweeperGameBoard.GetCells.GetLength(0); row++)
            {
                for (int col = 0; col < mineSweeperGameBoard.GetCells.GetLength(1); col++)
                {
                    if (activeGame && !mineSweeperGameBoard.GetCells[row, col].IsVisited)
                    {
                        Console.Write("? ");
                    }
                    else if (mineSweeperGameBoard.GetCells[row, col].Neighbors == 0)
                    {
                        Console.Write("~ ");
                    }
                    else if (mineSweeperGameBoard.GetCells[row, col].IsLive)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write(mineSweeperGameBoard.GetCells[row, col].Neighbors + " ");
                    }
                }
                Console.Write("\n");
            }
        }

        //Method tally to determine when the game has been won
        private void DetermineSelectionTally()
        {
            if (validSelectionTally >= (nodeTotal - mineSweeperGameBoard.GetLiveNodes))
            {
                gameWinner = true;
                activeGame = false;
            }
        }
        // Method used to check the players selection and respond accordingly
        private void CheckSelectionCell(int row, int col)
        {
            //If cell is a mine, end the game
            if (mineSweeperGameBoard.GetCells[row, col].IsLive)
            {
                activeGame = false;
                //Break out of reveal board loop
                validInput = true;
                return;
            }
            //Prevent any cell from being selected more than once
            if (mineSweeperGameBoard.GetCells[row, col].IsVisited)
            {
                return;
            }
            mineSweeperGameBoard.GetCells[row, col].IsVisited = true;
            validSelectionTally++;
            validInput = true;
            //If selection has no live neighbors, call recursive method to mark 
            if (mineSweeperGameBoard.GetCells[row, col].Neighbors == 0)
            {
                UpdateNeighbors(row, col);
            }
        }
        // Recursive method to update all neighboring cells with no neighbors
        private void UpdateNeighbors(int row, int col)
        {
            mineSweeperGameBoard.GetCells[row, col].IsVisited = true;
            validSelectionTally++;
            // Make sure recursive method is only called on cells with no live neighbors
            if (mineSweeperGameBoard.GetCells[row, col].Neighbors == 0)
            {
                // Ensure the change does not cause index out of bounds exception
                if (row + 1 < boardSize)
                {
                    // Note: May not be necessary, investigate further for next milestone
                    if (!mineSweeperGameBoard.GetCells[row + 1, col].IsVisited)
                    {
                        UpdateNeighbors(row + 1, col);
                    }
                }

                if (row - 1 >= 0)
                {
                    if (!mineSweeperGameBoard.GetCells[row - 1, col].IsVisited)
                    {
                        UpdateNeighbors(row - 1, col);
                    }
                }

                if (col + 1 < boardSize)
                {
                    if (!mineSweeperGameBoard.GetCells[row, col + 1].IsVisited)
                    {
                        UpdateNeighbors(row, col + 1);
                    }
                }

                if (col - 1 >= 0)
                {
                    if (!mineSweeperGameBoard.GetCells[row, col - 1].IsVisited)
                    {
                        UpdateNeighbors(row, col - 1);
                    }
                }
            }
        }
    }
}
