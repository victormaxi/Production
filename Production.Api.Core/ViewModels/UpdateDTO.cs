using System;
using System.Collections.Generic;
using System.Text;

namespace Production.Api.Core.ViewModels
{
   public class UpdateDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
