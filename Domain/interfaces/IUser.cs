using Domain.DTOs;
using Domain.Entite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.interfaces
{
    public interface IUser
    {
        void Add(AddUserRequst requst);
        bool Login(string emailAddress, string password);
    }
}
