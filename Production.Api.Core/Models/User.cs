using System;
using System.Collections.Generic;
using System.Text;

namespace Production.Api.Core.Models 
{
   public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string  UserName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PassWordSalt { get; set; }
        
    }
}
