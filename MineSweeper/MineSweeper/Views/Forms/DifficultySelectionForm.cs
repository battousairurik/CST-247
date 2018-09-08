// Author: Michael Weaver
// Grand Canyon University
// CST - 227

// Description: Form used to generate a board size based on the users chosen difficulty. Contains logic
//      to create a game board of vaeying sizes based on the radio button selected.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper.Views.Forms
{
    public partial class DifficultySelectionForm : Form
    {
        public DifficultySelectionForm()
        {
            InitializeComponent();
        }

        private void playGameBTN_Click(object sender, EventArgs e)
        {
            // Logic to create an easy game
            if (radioBtnEasy.Checked)
            {
                BoardDisplayForm form = new BoardDisplayForm(10, "easy");
                form.Show();
            }
            // Logic to create a medium difficulty game
            else if (radioBtnMedium.Checked)
            {
                BoardDisplayForm form = new BoardDisplayForm(20, "medium");
                form.Show();
            }
            //Logic to create a hard difficulty game
            else
            {
                BoardDisplayForm form = new BoardDisplayForm(30, "hard");
                form.Show();
            }
            
        }

                
    }
}
