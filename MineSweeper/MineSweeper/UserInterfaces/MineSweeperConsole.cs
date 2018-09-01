// Author: Michael Weaver
// Grand Canyon University
// CST - 227

// Description: This class is mean to represent the game's interaction with the console. At current it's implementation
//      is unfinished. The logic to properly implement it had escaped me until recently. I plan to implement this
//      properly in a future update.

using System;
using MineSweeper.ExecutionLogic;

namespace MineSweeper.UserInterfaces
{
    class MineSweeperConsole
    {
        MineSweeperConsoleGame game;

        public MineSweeperConsole()
        {
            game = new MineSweeperConsoleGame();
        }
        // MEthod marked for deletion
        public void DisplayConsoleMessage(String message)
        {
            Console.WriteLine(message);
        }
        // Method marked for deletion
        public int GetConsoleInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        //MEthod marked for deletion
        public void ClearTheConsole()
        {
            Console.Clear();
        }

        public void StartGame()
        {

        }
        public void GetTurnSelection()
        {
            int x, y;
            try
            {
                Console.Write("/nRow Selection: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("/nColumn Selection: ");
                y = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

        public void InitializeBoard()
        {
            Console.WriteLine("Enter Boardsize (Between 1 and 50): ");
            Console.ReadLine();
        }
    }
}
