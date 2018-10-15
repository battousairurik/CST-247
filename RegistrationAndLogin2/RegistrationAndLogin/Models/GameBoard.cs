using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace RegistrationAndLogin.Models
{
    [Serializable]
    //[DataContract]
    public class GameBoard
    {
        //[DataMember]
        public GameCell[,] GameCells { get; set; }
        //[DataMember]
        public int BoardSize { get; set; }
        
        public GameBoard(int boardsize)
        {
            BoardSize = boardsize;
            GameCells = new GameCell[boardsize, boardsize];
        }

        
    }
}