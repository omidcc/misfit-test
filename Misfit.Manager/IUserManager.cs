using System;
using System.Collections.Generic;
using Misfit.Model;

namespace Misfit.Manager
{
    public interface IUserManager
    {
        IList<User> GetAllUsers();
        IList<UserResult> GetAllUserResults();
        User GetUserByName(string username);
        User SaveUser(User user);
        UserResult SaveUserResult(UserResult userResult);
    }
}
