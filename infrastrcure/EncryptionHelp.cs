using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace infrastrcure
{
    public class EncryptionHelp
    {
        public static string Encryption(string text)
        {

            var hash = BCrypt.Net.BCrypt.HashPassword(text);
            return hash;
        }
        public static bool Verify(string password , string hashPassword)
        {
            
            var isCorrect = BCrypt.Net.BCrypt.Verify(password, hashPassword);
            return isCorrect;
        }
    }
}
