using System;
using System.Data.SqlClient;
using Database.Model;

namespace Database.Repository
{
    public class UserRepository
    {
        private SqlConnection _connection;

        public UserRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public bool Add(User user)
        {
            SqlCommand command = new SqlCommand("insert into Users(Name,LastName,Username,Password) values(@name,@lastname,@username,@password)", _connection);

            command.Parameters.AddWithValue("@name", user.Name);
            command.Parameters.AddWithValue("@lastname", user.LastName);
            command.Parameters.AddWithValue("@username", user.Username);
            command.Parameters.AddWithValue("@password", user.Password);

            return ExecuteDml(command);
        }

        public bool IsRegistered(string username)
        {
            SqlCommand command = new SqlCommand("select u.Username from Users u where u.Username = @username", _connection);

            command.Parameters.AddWithValue("@username", username);

            return ExecuteDml(command);
        }

        public bool Login(string username, string password)
        {
            SqlCommand command = new SqlCommand("select u.Username,u.Password from Users u where u.Username = @username and u.Password = @password", _connection);

            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            return ExecuteDml(command);
        }

        private bool ExecuteDml(SqlCommand query)
        {
            try
            {
                _connection.Open();

                query.ExecuteNonQuery();

                _connection.Close();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
    }
}
