// Author: Michael Weaver
// Grand Canyon University
// CST - 227

// Description: Contais all logic to generate a form containing clickable cells and allow the user to 
//      interact with those cells to play the game.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MineSweeper.FormControls;
using MineSweeper.ObjectModels;

namespace MineSweeper.Forms
{
    public partial class BoardDisplayForm : Form
    {
        private int boardSize;
        private ClickableCellGameBoard gameBoard;
        private ClickableCell[,] clickableCells;
        private String difficulty;
        
        // Constructor used to create a board size based on the users selection
        public BoardDisplayForm(int size)
        {
            InitializeComponent();
            boardSize = size;
            gameBoard = new ClickableCellGameBoard(boardSize);
            clickableCells = gameBoard.GetClickableCells();
            AddCellsToBoard();
        }

        public BoardDisplayForm(int size, String difficulty)
        {
            InitializeComponent();
            boardSize = size;
            this.difficulty = difficulty;
            gameBoard = new ClickableCellGameBoard(boardSize, this.difficulty);
            clickableCells = gameBoard.GetClickableCells();
            AddCellsToBoard();
            
        }

        // Method used to place cells on screen
        private void AddCellsToBoard()
        {
            this.Controls.Clear();
            for (int x = 0; x < boardSize; x++)
            {
                for (int y = 0; y < boardSize; y++)
                {
                    //Logic to create and position cells on the form
                    clickableCells[x,y].Location = new Point((x * 20), (y * 20));
                    this.Controls.Add(clickableCells[x,y]);
                }
            }
        }

        private void BoardDisplayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //gameBoard.timer.Stop();
            //MessageBox.Show("Time Elapsed in game: " + gameBoard.TimeElapsed.ToString()
            //    + " sec");
        }
    }
}
