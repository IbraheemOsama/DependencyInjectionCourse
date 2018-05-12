using System.Collections.Generic;
using AutofacWebMvcFive.Utilities;

namespace AutofacWebMvcFive.Repositories
{
    public interface IUserRepository
    {
        List<string> GetUsers();
    }

    public class UserRepository : IUserRepository
    {
        private readonly IUserProvider _userProvider;
        public UserRepository(IUserProvider userProvider)
        {
            _userProvider = userProvider;
        }
        public List<string> GetUsers()
        {
            var user = _userProvider.UserName;
            return new List<string> { "User 1", "User 2", "User 3" };
        }
    }
}