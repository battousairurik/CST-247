// Author: Michael Weaver
// Grand Canyon University
// CST - 227, CST - 247

// Description: This is the main access point to the project which contains logic to execute different versions of the 
//      mine sweeper game.

using System.Windows.Forms;
using MineSweeper.Views.Forms;

namespace MineSweeper
{
    class Driver
    {
        // Method to run the game as a Form
        private static void RunGameFromForm (Form form)
        {
            Application.Run(form);
        }        
        //Main method to run the program
        static void Main(string[] args)
        {
            RunGameFromForm(new DifficultySelectionForm());            
        }
    }
}
    
