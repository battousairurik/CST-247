// Author: Michael Weaver
// Grand Canyon University
// CST - 227

// Description: Display form to show the user the high scores at the end of each game.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MineSweeper.Models;

namespace MineSweeper.Views.Forms
{
    public partial class PlayerStatsForm : Form
    {
        
        private List<PlayerStats> list;
        private int rowSize = 0;
        private int columnSize = 0;

        public PlayerStatsForm()
        {
            InitializeComponent();
        }

        public void SetHighScoreList(List<PlayerStats> list) => this.list = list;

        public void SetDefaultRowColumnSize()
        {
            rowSize = 5;
            columnSize = 2;
        }

        public void DisplayHighScores()
        {

            highScoresLayoutPanel.Controls.Clear();
            highScoresLayoutPanel.ColumnStyles.Clear();
            highScoresLayoutPanel.RowStyles.Clear();

            highScoresLayoutPanel.RowCount = this.rowSize;
            highScoresLayoutPanel.ColumnCount = this.columnSize;

            for (int row = 0; row < rowSize; row++)
            {
                // Difficulty determining the flow for this portion                
                highScoresLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                for (int column = 0; column < columnSize; column++)
                {
                    // 
                    if (row == 0)
                    {
                        highScoresLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

                    }
                    // Create the label to store the Player Name and High Score based on difficulty
                    Label label = new Label();

                    label.Text = DisplayHighScoresHelper(row, column);

                    // Difficulty because the row / column layout for this is reversed
                    highScoresLayoutPanel.Controls.Add(label, column, row);
                }
            }
            
        }
        
        private String DisplayHighScoresHelper(int row, int column)
        {
            switch (column)
            {
                case 0:
                    return list[row].PlayerName;
                case 1:
                    return list[row].Score.ToString();
                default:
                    return null;
            }
        }
    }
}
