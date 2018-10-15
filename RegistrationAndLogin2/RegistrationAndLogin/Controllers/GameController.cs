using Microsoft.Owin.Logging;
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
        public static GameBoard GameBoard = new GameBoard(10);
        GameBoardController gBController = new GameBoardController(GameBoard);

        // GET: Game
        public ActionResult Index()
        {
            try
            {
                if (Request.IsAjaxRequest())
                {
                    return PartialView("GameBoard", GameBoard);
                }
                else
                {
                    return View("Game", GameBoard);
                }
            }
            catch (Exception e)
            {
                
                return RedirectToAction("Index", "Login");
                
            }
            
        }
        
        public PartialViewResult GameBoardView()
        {
            return PartialView();
        }

        public ActionResult Game()
        {
            return View(GameBoard);
        }

        [HttpPost]
        public ActionResult GameDisplay(GameBoard gameBoard)
        {
            //convert gameboard to json string

            //save json string to database


            
            return View(gameBoard);
        }
        
        
    }
}