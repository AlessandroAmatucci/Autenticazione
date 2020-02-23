using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Autenticazione.Models
{
    public class SignupModel : BaseModel
    {
        public string LabelButtonUsername { get; set; }
        public string LabelButtonEmail { get; set; }
        public string LabelButtonPassword { get; set; }
        public string LabelButtonConfirmPassword { get; set; }
        public string LabelButtonSubmit { get; set; }
    }
}