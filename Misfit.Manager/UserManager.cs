using System;
using System.Collections.Generic;
using Misfit.Data;
using Misfit.Model;
using System.Linq;

namespace Misfit.Manager
{
    public class UserManager : IUserManager
    {
        private IUserRepository _UserRepository;
        private IUserResultRepository _UserResultRepository;
        public UserManager(IUserRepository userRepository, IUserResultRepository userResultRepository)
        {
            _UserRepository = userRepository;
            _UserResultRepository = userResultRepository;
        }

        public IList<UserResult> FindUserResultByUser(int userId)
        {
            return GetAllUserResults().Where(x => x.User.Id == userId).ToList();
        }

        public IList<UserResult> GetAllUserResults()
        {
            return _UserResultRepository.GetAll().ToList();
        }

        public IList<User> GetAllUsers()
        {
            return _UserRepository.GetAll().ToList();
        }

        public User GetUserById(int id)
        {
            return GetAllUsers().SingleOrDefault(x => x.Id == id);
        }

        public User GetUserByName(string username)
        {
            return GetAllUsers().SingleOrDefault(x => x.UserName == username);
        }

        public UserResult GetUserResultById(int id)
        {
            return GetAllUserResults().Where(x => x.Id == id).SingleOrDefault();
        }

        public User SaveUser(User user)
        {
            var existingUser = GetUserByName(user.UserName);
            User saveduser = new User();
            
            saveduser = existingUser!=null? existingUser : _UserRepository.Add(user);
            
            return saveduser;
        }

        public UserResult SaveUserResult(UserResult userResult)
        {
            return _UserResultRepository.Add(userResult);
        }

        public User UpdateUser(User user)
        {
            return _UserRepository.Update(user);
        }

    }
}
