﻿using System;
using System.Collections.Generic;
using System.Text;
using TopLearn.Core.DTOs;
using TopLearn.DataLayer.Entities.User;

namespace TopLearn.Core.Services.Interfaces
{
   public interface IUserService
   {
       bool IsExistUserName(string userName);
       bool IsExistEmail(string email);
       int AddUser(User user);
       User LoginUser(LoginViewModel login);
       User GetUserByEmail(string email);
       User GetUserByUserName(string username);
       User GetUserByActiveCode(string activeCode);
       void UpdateUser(User user);
       bool ActiveAccount(string activeCode);

        #region User Panel

        InformationUserViewModel GetUserInformation(string username);
        SideBarUserPanelViewModel GetSideBarUserPanelData(string username);

        #endregion

    }
}
