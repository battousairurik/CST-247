using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RegistrationAndLogin.Models;

namespace RegistrationAndLogin.Controllers
{
    // To change to be an official controller extend class with ": Controller" and 
    // add namespace "System.Web.Mvc;"
    public class GameLogicController
    {
        GameCellButton[,] gameButtons;
        GameBoard gameBoard;

        public GameLogicController(int boardSize)
        {
            gameBoard = new GameBoard(boardSize);
            GameBoardController gBController = new GameBoardController(gameBoard);

            gameButtons = new GameCellButton[boardSize, boardSize];

        }

        private void LinkGameBoardToButtons()
        {
            for (int i = 0; i < gameButtons.GetLength(0); i++)
            {
                for (int j = 0; j < gameButtons.GetLength(0); j++)
                {
                    gameButtons[i, j] = new GameCellButton
                    {
                        //Cell = gameBoard.GetGameCell[i, j]

                    };

                }
            }
        }


    }
}