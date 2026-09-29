using Domain.Entite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DTOs
{
    public class AddUserRequst
    {
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
    }
}
