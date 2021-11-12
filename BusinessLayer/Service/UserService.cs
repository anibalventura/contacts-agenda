using Database.Model;
using Database.Repository;
using System.Data.SqlClient;

namespace BusinessLayer.Service
{
    public class UserService
    {
        private UserRepository userRepository;

        public UserService(SqlConnection connection)
        {
            userRepository = new UserRepository(connection);
        }

        public bool Add(User user)
        {
            return userRepository.Add(user);
        }

        public bool CheckUsername(string username)
        {
            return userRepository.CheckUsername(username);
        }

        public User GetLogin(string username, string password)
        {
            return userRepository.GetLogin(username, password);
        }
    }
}
