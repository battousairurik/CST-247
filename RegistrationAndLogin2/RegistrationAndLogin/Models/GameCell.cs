using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrationAndLogin.Models
{
    public class GameCell
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public int Neighbors { get; set; }
        public string Display { get; set; }
        public Boolean IsVisited { get; set; }
        public Boolean IsLive { get; set; }
        public Boolean Flagged { get; set; }
    }
}