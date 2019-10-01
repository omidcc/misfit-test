using System;
using System.Collections.Generic;
using Misfit.Data;
using Misfit.Model;
using System.Linq;

namespace Misfit.Manager
{
    public class UserManager : IUserManager
    {
        private UserRepository _UserRepository;
        private UserResultRepository _UserResultRepository;
        public UserManager(UserRepository userRepository, UserResultRepository userResultRepository)
        {
            _UserRepository = userRepository;
            _UserResultRepository = userResultRepository;
        }

        public IList<UserResult> GetAllUserResults()
        {
            var results = (from result in _UserResultRepository.GetAll()
                           join user in _UserRepository.GetAll()
                           on result.UserId equals user.Id
                           select new UserResult
                           {
                               Id = result.Id,
                               FirstNumber = result.FirstNumber,
                               SecondNumber = result.SecondNumber,
                               Sum = result.Sum,
                               DateOfCalculation = result.DateOfCalculation,
                               UserId = user.Id,
                               User = user
                           }).ToList();
            return results;
        }

        public IList<User> GetAllUsers()
        {
            return _UserRepository.GetAll().ToList();
        }

        public User GetUserByName(string username)
        {
            return GetAllUsers().SingleOrDefault(x => x.UserName == username);
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

    }
}
