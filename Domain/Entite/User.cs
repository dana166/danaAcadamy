using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entite
{
    public class User: BaseEntite
    {
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public UserTypeEnum UserType { get; set; }
    }
}
