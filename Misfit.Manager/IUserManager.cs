using System;
using System.Collections.Generic;
using Misfit.Model;

namespace Misfit.Manager
{
    public interface IUserManager
    {
        IList<User> GetAllUsers();
        IList<UserResult> GetAllUserResults();
        User GetUserById(int id);
        User GetUserByName(string username);
        UserResult GetUserResultById(int id);
        IList<UserResult> FindUserResultByUser(int userId);
        User SaveUser(User user);
        UserResult SaveUserResult(UserResult userResult);
        User UpdateUser(User user);
    }
}
