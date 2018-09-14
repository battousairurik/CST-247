using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper.Models
{
    class RegisteredUser
    {
        public string UserFirstName { get; set; }

        public string UserLastName { get; set; }

        public string UserGender { get; set; }

        public int UserAge { get; set; }

        public string UserState { get; set; }

        public string UserEmail { get; set; }

        //[Key]
        public string UserUsername { get; set; }

        public string UserPassword { get; set; }
    }
}
