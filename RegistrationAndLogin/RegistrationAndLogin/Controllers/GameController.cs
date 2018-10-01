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

        public ActionResult DifficultySelection()
        {

            return View();
        }

        public GameBoard GameBoard;
        
        public ActionResult GameDisplay(Difficulty difficulty)
        {
            InitializeGameBoard(difficulty.GameDifficulty);
            
            return View(GameBoard);
        }

        private void InitializeGameBoard(int difficulty)
        {
            GameBoard = new GameBoard(difficulty * 10);
            GameBoardController gBController = new GameBoardController(GameBoard);
        }
    }
}