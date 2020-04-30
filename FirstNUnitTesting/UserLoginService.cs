using System;
using System.Collections.Generic;
using System.Text;

namespace FirstNUnitTesting
{
    public class UserLoginService : IUserLoginService
    {
        public string GreetUser(string userName)
        {
            if (string.IsNullOrEmpty(userName))
                throw new ArgumentNullException("username");

            if (userName.Length == 0)
                throw new ArgumentException("user name cannot be empty");

            return string.Format("Hello {0}!", userName);
        }
    }
}
