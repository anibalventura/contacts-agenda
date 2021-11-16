using System;
using System.Data.SqlClient;
using Database.Model;

namespace Database.Repository
{
    public class UserRepository : RepositoryBase
    {
        public UserRepository(SqlConnection connection) : base(connection) { }

        public bool Add(User user)
        {
            SqlCommand command = new SqlCommand("insert into Users(Name,LastName,Username,Password) values(@name,@lastname,@username,@password)", GetConnection());

            command.Parameters.AddWithValue("@name", user.Name);
            command.Parameters.AddWithValue("@lastname", user.LastName);
            command.Parameters.AddWithValue("@username", user.Username);
            command.Parameters.AddWithValue("@password", user.Password);

            return ExecuteDml(command);
        }

        public bool CheckUsername(string username)
        {
            try
            {
                GetConnection().Open();

                SqlCommand command = new SqlCommand("select u.Username from Users u where u.Username = @username", GetConnection());

                command.Parameters.AddWithValue("@username", username);

                SqlDataReader reader = command.ExecuteReader();

                string usernameDB = "";

                while (reader.Read())
                {
                    usernameDB = reader.IsDBNull(0) ? "" : reader.GetString(0);
                }

                reader.Close();
                reader.Dispose();
                GetConnection().Close();

                if (usernameDB == username)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public User GetLogin(string username, string password)
        {
            try
            {
                GetConnection().Open();

                SqlCommand command = new SqlCommand("select u.Id,u.Name,u.LastName,u.Username,u.Password from Users u where u.Username = @username and u.Password = @password", GetConnection());

                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                SqlDataReader reader = command.ExecuteReader();

                User data = new User();

                while (reader.Read())
                {
                    data.Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    data.Name = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    data.LastName = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    data.Username = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    data.Password = reader.IsDBNull(4) ? "" : reader.GetString(4);
                }

                reader.Close();
                reader.Dispose();
                GetConnection().Close();

                return data;
            }
            catch(Exception e)
            {
                return null;
            }
        }
    }
}
