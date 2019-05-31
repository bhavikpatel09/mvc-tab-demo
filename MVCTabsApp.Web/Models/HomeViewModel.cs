using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTabsApp.Web.Models
{
    public class HomeViewModel
    {
        public Personal Personal { get; set; }
        public Login Login { get; set; }
        public Contact Contact { get; set; }
    }
    public class Personal
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    public class Login
    {
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string SecurityQuestion { get; set; }

    }
    public class Contact
    {
        public string ContactPerson { get; set; }
        public string ContactEmail { get; set; }
        public string ContactNumber { get; set; }

    }
}