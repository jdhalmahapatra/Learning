using System;
using System.Collections.Generic;
using System.Text;

namespace S_Single_Responsibility_Principle
{
    interface IUserAuthentication
    {
        bool RegisterNewUser(string userName, string password, string email);
        bool LoginUser(string userName, string password);
    }
    interface ILogError
    {
        void LogError(string error);
    }
    interface ISendEmail
    {
        bool SendEmail(string emailContent);
    }

}
