using System;
using System.Collections.Generic;
using System.Text;

namespace S_Single_Responsibility_Principle
{
    class User : IUserAuthentication
    {
        public bool LoginUser(string userName, string password)
        {
            try
            {
                if (userName != "" && password != "")
                {
                    return true;
                }
                else
                    return false;
            }
            catch(Exception exp)
            {
                throw exp;
            }
        }

        public bool RegisterNewUser(string userName, string password, string email)
        {
            try
            {
                if (userName != "" && password != "" && email != "")
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception exp)
            {
                throw exp;
            }
        }
    }
}
