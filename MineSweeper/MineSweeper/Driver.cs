// Author: Michael Weaver
// Grand Canyon University
// CST - 227

// Description: This is the main access point to the project which contains logic to execute different versions of the 
//      mine sweeper game.

using System;
using MineSweeper.ExecutionLogic;
using System.Windows.Forms;
using MineSweeper.Forms;

namespace MineSweeper
{
    class Driver
    {
        //Method to run the game on console
        private static void RunGameOnConsole()
        {
            try
            {
                MineSweeperConsoleGame game1 = new MineSweeperConsoleGame();
                game1.PlayGame();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }

        // Method to run the MineSweeper GUI
        private static void RunGameOnGUI ()
        {
            Application.Run(new DifficultySelectionForm());
        }
        
        //Main method to run the program
        static void Main(string[] args)
        {
            RunGameOnGUI();
            
        }

        
    }
}
    
