using System;
using System.Collections.Generic;
using System.Text;

namespace Production.Api.Core.Models
{
   public class UpdateUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
