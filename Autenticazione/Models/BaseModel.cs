using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Autenticazione.Models
{
    public class BaseModel
    {
        public string Title { get; set; } //Titolo sito
        public string PageTitle { get; set; } //Titolo Pagina
        public string Description { get; set; }
        public string SigninButton { get; set; }
        public string SignupButton { get; set; }
        public string LogoutButton { get; set; }
    }
}