using RegistrationAndLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistrationAndLogin.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {
            return View();
        }
        
        public static GameBoard GameBoard = new GameBoard(10);
        GameBoardController gBController = new GameBoardController(GameBoard);

        public ActionResult GameDisplay(GameBoard gameBoard)
        {
            GameBoard = gameBoard;
            GameBoard.GameCells[gameBoard.CellSelection.Column - 1, gameBoard.CellSelection.Row - 1].IsVisited = true;

            return View(GameBoard);
        }

        public ActionResult CellSelection(GameBoard gameBoard)
        {
            GameBoard = gameBoard;
            return View(GameBoard);
        }

        public ActionResult InitialCellSelection()
        {
            
            return View(GameBoard);
        }
    }
}