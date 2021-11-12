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

        public bool IsRegistered(string username)
        {
            return userRepository.IsRegistered(username);
        }

        public bool Login(string username, string password)
        {
            return userRepository.Login(username, password);
        }
    }
}
