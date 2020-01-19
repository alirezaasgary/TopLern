using System;
using System.Collections.Generic;
using System.Text;

namespace TopLearn.Core.Services.Interface
{
   public interface IUserService
    {
        bool IsExistUserName(string userName);
        bool IsExistEmail(string email);
    }
}
