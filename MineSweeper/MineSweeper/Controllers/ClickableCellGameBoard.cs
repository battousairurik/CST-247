// Author: Michael Weaver
// Grand Canyon University
// CST - 227

// Description: Controller to handle generation of Custom Buttons which are displayed
//      for the user to the play the minesweeper game.

// Note: Clickable Cell board and exeution logic should be broken into different classes

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using MineSweeper.Models;
using MineSweeper.Views.Forms;

namespace MineSweeper.Controllers
{
    class ClickableCellGameBoard
    {
        private ClickableCell[,] cellsGameBoard;
        private MineSweeperGameBoard minesBoard;
        private int boardSize;
        public Timer timer;
        public int TimeElapsed { get; set; }
        private int playerTotal;
        private String difficulty;
        private PlayerStatsController statsController;
        private Boolean activeGame = true;

        public ClickableCell[,] GetClickableCells ()
        {
            return cellsGameBoard;
        }

        public ClickableCellGameBoard(int boardSize)
        {
            SetUpTimer();
            this.boardSize = boardSize;
            minesBoard = new MineSweeperGameBoard(boardSize);
            cellsGameBoard = new ClickableCell[boardSize, boardSize];
            CreateBoardCells();
        }

        public ClickableCellGameBoard(int boardSize, String difficulty)
        {
            SetUpTimer();
            this.boardSize = boardSize;
            this.difficulty = difficulty;
            minesBoard = new MineSweeperGameBoard(boardSize);
            cellsGameBoard = new ClickableCell[boardSize, boardSize];
            CreateBoardCells();
            
        }

        private void SetUpTimer()
        {
            timer = new Timer();
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeElapsed++;
        }
        // Should be in separate class
        public void CreateBoardCells()
        {
            for (int x = 0; x < boardSize; x++)
            {
                for (int y = 0; y < boardSize; y++)
                {
                    ClickableCell cell = new ClickableCell();
                    cell.Text = "?";
                    cell.Height = 20;
                    cell.Width = 20;
                    cell.SetTileCell(minesBoard.GetCells[x, y]);
                    cell.Row = x;
                    cell.Column = y;
                    // Needed to determine player right or left click
                    cell.MouseDown += (s, e) =>
                    {
                        //This doesnt work, right click doesnt register at all
                        if (e.Button == MouseButtons.Right)
                        {
                            HandleRightClick(cell);
                        }
                        else
                        {
                            SetCellActions(cell);
                        }
                    };
                    // Needed for the recursive click call
                    cell.Click += (s, e) =>
                    {
                        SetCellActions(cell);
                    };
                    cellsGameBoard[x, y] = cell;
                }
            }
        }
        // Should be in separate cells board class
        private void HandleRightClick(ClickableCell cell)
        {
            if (!cell.GetIsClicked())
            {
                if (cell.RightClicked)
                {
                    cell.Text = "?";
                    cell.BackgroundImage = null;
                    cell.RightClicked = false;
                }
                else
                {
                    cell.Text = "";
                    cell.BackgroundImage = Properties.Resources.Flag;
                    cell.RightClicked = true;
                }
            }
        }
        // Should be in separate cells board class
        private void SetCellActions (ClickableCell cell)
        {
            ClearRightClick(cell);
            cell.SetIsClicked(true);
            SetCellText(cell);
            //cell.BackColor = Color.Red;
            CheckForMine(cell);
            CheckCellNeighbors(cell);
            CheckForWin();
        }
        // Should be in separate cells board class
        private void ClearRightClick (ClickableCell cell)
        {
            if (cell.RightClicked)
            {
                cell.BackgroundImage = null;
            }
        }
        // Should be in separate cells board class
        private void SetCellText (ClickableCell cell)
        {
            if (cell.GetTileCell().IsLive)
            {
                cell.BackgroundImage = Properties.Resources.Bomb;
            }
            else
            {
                cell.Text = cell.GetTileCell().Neighbors.ToString();
            }
        }

        private void CheckForMine(ClickableCell cell)
        {
            if (cell.GetTileCell().IsLive)
            {
                timer.Stop();
                cell.BackColor = Color.Red;
                DeterminePlayerTotal();
                DisplayAllCells();
                MessageBox.Show("Game Over.\n"
                    + "Time Elapsed: " + TimeElapsed + " sec\n"
                    + "Total Score: " + playerTotal
                    );
                // For right now just exit the minesweeper game
                Application.Exit();
                
            }
        }

        private void DeterminePlayerTotal()
        {
            foreach (var cell in cellsGameBoard)
            {
                if (cell.RightClicked)
                {
                    if (cell.GetTileCell().IsLive)
                    {
                        playerTotal += 20;
                    }
                }
            }
        }

        private void DisplayAllCells()
        {
            foreach (var cell in cellsGameBoard)
            {
                SetCellText(cell);
            }
        }
        // Recursive method to open up cells with no live neighbors
        private void CheckCellNeighbors(ClickableCell cell)
        {
            if (cell.GetTileCell().Neighbors == 0)
            {
                if (cell.Row + 1 < boardSize && !cellsGameBoard[cell.Row + 1, cell.Column].GetIsClicked())
                {
                    cellsGameBoard[cell.Row + 1, cell.Column].PerformClick();
                }
                if (cell.Row - 1 >= 0 && !cellsGameBoard[cell.Row - 1, cell.Column].GetIsClicked())
                {
                    cellsGameBoard[cell.Row - 1, cell.Column].PerformClick();
                }
                if (cell.Column + 1 < boardSize && !cellsGameBoard[cell.Row, cell.Column + 1].GetIsClicked())
                {
                    cellsGameBoard[cell.Row, cell.Column + 1].PerformClick();
                }
                if (cell.Column - 1 >= 0 && !cellsGameBoard[cell.Row, cell.Column - 1].GetIsClicked())
                {
                    cellsGameBoard[cell.Row, cell.Column - 1].PerformClick();
                }
            }
        }

        private void CheckForWin()
        {
            int mines = 0;
            int correctFlags = 0;
            int clickedCells = 0;
            int total = boardSize * boardSize;
            foreach (var cell in cellsGameBoard)
            {
                if (cell.GetTileCell().IsLive)
                {
                    mines++;
                    if (cell.RightClicked)
                    {
                        correctFlags++;
                    }
                }
                if (cell.GetIsClicked())
                {
                    clickedCells++;
                }
            }
            if (mines == correctFlags || total - clickedCells == mines)
            {
                if (activeGame)
                {
                    DisplayAllCellsWinner();
                    Form.ActiveForm.Close();
                    AddWinnerToHighScores();
                    Application.Exit();
                    Environment.Exit(0);
                    activeGame = false;
                }
                
            }
        }

        private void DisplayAllCellsWinner()
        {
            timer.Stop();
            FlagAllMines();
            DeterminePlayerTotal();
            
            MessageBox.Show("You win!\n"
                + "Time Elapsed: " + TimeElapsed + " sec\n"
                + "Total Score based on mines: " + playerTotal
                + "\nProceed to enter your score"
                );
            
        }

        private void FlagAllMines()
        {
            foreach (var cell in cellsGameBoard)
            {
                if (cell.GetTileCell().IsLive)
                {
                    // Ensure that player gets credit for win even if they did not flag the mine
                    cell.RightClicked = true;
                    cell.BackgroundImage = Properties.Resources.Flag;
                }
                else
                {
                    cell.Text = cell.GetTileCell().Neighbors.ToString();
                }
            }
        }

        public void AddWinnerToHighScores()
        {
            String playerName = GetPlayerName();

            // Create new player object for person who just won the game
            PlayerStats newPlayer = new PlayerStats(playerName, TimeElapsed, difficulty);

            statsController = new PlayerStatsController();
            PlayerStatsForm highScores = new PlayerStatsForm();
            // Update list with new player object
            statsController.UpdateList(newPlayer, difficulty);
            // Set proper list to display form
            highScores.SetHighScoreList(statsController.GetDifficultyScores(difficulty));
            // Display high scores form
            CreateNewHighScoresDisplay(highScores);
            // Finally write new list to file
            statsController.WriteListToFile();
        }
        
        public void CreateNewHighScoresDisplay(PlayerStatsForm highScores)
        {
            
            highScores.SetDefaultRowColumnSize();
            // Call only after setting row and column sizes
            highScores.DisplayHighScores();
            // Had difficulty determineing that these two lines of code were needed
            // over just the form.Show() method
            highScores.BringToFront();
            highScores.ShowDialog();
        }

        public String GetPlayerName()
        {
            InputBoxForm form = new InputBoxForm();

            form.BringToFront();
            form.ShowDialog();
            
            return form.GetPlayerName();
        }
    }
}
