using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Activity2Part1.Models
{
    public class UserModel
    {
        public UserModel(string Name, string Email, string PhoneNumber) 
        {
            this.Name = Name;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}