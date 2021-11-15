using System;
using System.Data.SqlClient;
using Database.Model;
using System.Data;

namespace Database.Repository
{
    public class ContactRepository : IContactCrud
    {
        private SqlConnection _connection;

        public ContactRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public bool Add(Contact user)
        {
            SqlCommand command = new SqlCommand("insert into Contacts(Name,LastName,Address,PhoneNumber,WorkNumber,IdUser) values(@name,@lastname,@address,@phonenumber,@worknumber,@iduser)", _connection);

            command.Parameters.AddWithValue("@name", user.Name);
            command.Parameters.AddWithValue("@lastname", user.LastName);
            command.Parameters.AddWithValue("@address", user.Address);
            command.Parameters.AddWithValue("@phonenumber", user.PhoneNumber);
            command.Parameters.AddWithValue("@worknumber", user.WorkNumber);
            command.Parameters.AddWithValue("@iduser", user.IdUser);

            return ExecuteDml(command);
        }

        public bool Edit(Contact user)
        {
            SqlCommand command = new SqlCommand("update Contacts set Name=@name,LastName=@lastname,Address=@address,PhoneNumber=@phonenumber,WorkNumber=@worknumber,IdUser=@iduser where Id = @id", _connection);

            command.Parameters.AddWithValue("@name", user.Name);
            command.Parameters.AddWithValue("@lastname", user.LastName);
            command.Parameters.AddWithValue("@address", user.Address);
            command.Parameters.AddWithValue("@phonenumber", user.PhoneNumber);
            command.Parameters.AddWithValue("@worknumber", user.WorkNumber);
            command.Parameters.AddWithValue("@iduser", user.IdUser);
            command.Parameters.AddWithValue("@id", user.Id);

            return ExecuteDml(command);
        }

        public bool Delete(int id)
        {
            SqlCommand command = new SqlCommand("delete Contacts where Id = @id", _connection);

            command.Parameters.AddWithValue("@id", id);

            return ExecuteDml(command);
        }

        public Contact GetById(int id)
        {
            try
            {
                _connection.Open();

                SqlCommand command = new SqlCommand("select c.Id,c.Name,c.LastName,c.Address,c.PhoneNumber,c.WorkNumber,c.IdUser from Contacts c where c.Id = @id", _connection);

                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                Contact data = new Contact();

                while (reader.Read())
                {
                    data.Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    data.Name = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    data.LastName = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    data.Address = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    data.PhoneNumber = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    data.WorkNumber = reader.IsDBNull(5) ? "" : reader.GetString(5);
                    data.IdUser = reader.IsDBNull(6) ? 0 : reader.GetInt32(6);
                }

                reader.Close();
                reader.Dispose();
                _connection.Close();

                return data;
            }
            catch (Exception e)
            {
                return null;
            }

        }

        public DataTable GetAll(int idUser)
        {
            SqlDataAdapter query = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("select c.Id as Code,c.Name,c.LastName as \"Last name\",c.Address,c.PhoneNumber as \"Phone Number\",c.WorkNumber as \"Work Number\" from Contacts c where c.IdUser = @iduser", _connection);

            command.Parameters.AddWithValue("@iduser", idUser);
            query.SelectCommand = command;

            return LoadData(query);
        }

        private DataTable LoadData(SqlDataAdapter query)
        {
            try
            {
                DataTable data = new DataTable();

                _connection.Open();

                query.Fill(data);

                _connection.Close();

                return data;
            }
            catch (Exception e)
            {
                return null;
            }
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