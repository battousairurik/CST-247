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
     
        [Authorize]
        [HttpGet]
        public ActionResult DifficultySelection()
        {

            return View();
        }

        public ActionResult GameDisplay(Difficulty difficulty)
        {
            GameLogicController logicController = new GameLogicController(difficulty.GameDifficulty * 10);

            return View();
        }
    }
}