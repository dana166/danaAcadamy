using Domain.DTOs;
using Domain.Entite;
using Domain.interfaces;
using infrastrcure;
using Mapster;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class UserSarvices : IUser
    {

        private List<User> _users;

        public UserSarvices()
        {
            if (_users == null)
            {
                _users = new List<User>();
            }
            
        }

        public void Add(AddUserRequst requst)
            
        {

            var userData = requst.Adapt<User>();

            userData.id = Guid.NewGuid();
            userData.CreatedDate = DateTime.Now;
            userData.UserType =Domain.Enum.UserTypeEnum.User;
            userData.Password = EncryptionHelp.Encryption(requst.Password);
            _users.Add(userData);
        }

        public bool Login(string emailAddress, string password)
        {
            var user = _users.Where(q => q.EmailAddress == emailAddress).FirstOrDefault();
            if (user != null) {
                var isCorrectPassword = EncryptionHelp.Verify(password, user.Password);
                if (isCorrectPassword)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
