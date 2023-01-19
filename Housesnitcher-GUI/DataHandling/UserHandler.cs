using Housesnitcher_GUI.Models;
using System.Data.SqlClient;

namespace Housesnitcher_GUI.DataHandling
{
    public static class UserHandler
    {
        private static readonly string _connection = $"data source = {StateManagement.State.DataSource}; database={StateManagement.State.ConnectionString}; integrated security=SSPI";
        public static User? CreateUser(string username, string unhashedPassword)
        {
            var user = new User(username, unhashedPassword);
            return _createUser(user);
        }
        public static User? CreateUser(User user)
        {
            return _createUser(user);
        }
        private static User? _createUser(User user)
        {
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("select count(*) from users where username = @username", connection))
                {
                    command.Parameters.AddWithValue("@username", user.Username);
                    command.Parameters.AddWithValue("@pass", user.Password);

                    int UserExist = (int)command.ExecuteScalar();

                    if (UserExist > 0)
                    {
                        return null;

                    }
                }
                connection.Close();
            }

            try
            {
                string query = "Insert into users (username, pass, permission) values (@username, @pass, @perm)";
                using (SqlConnection connection = new SqlConnection(_connection))
                {

                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", user.Username);
                        command.Parameters.AddWithValue("@pass", user.Password);
                        command.Parameters.AddWithValue("@perm", (int)user.AuthLevel);
                        command.ExecuteNonQuery();

                    }
                    connection.Close();
                }
            }
            catch (Exception) { return null; }
            return user;
        }

        public static List<string> UsernamesList()
        {
            List<string> usernames = new List<string>();
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT username FROM users", connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string username = (string)reader["username"];
                        usernames.Add(username);
                    }
                }
                connection.Close();
            }
            return usernames;
        }
        public static User? LogIn(string username, string password)
        {
            try
            {
                string query = "Select * from users where username = @username";

                using SqlConnection connection = new SqlConnection(_connection);
                connection.Open();
                using SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@username", username);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    if (BCrypt.Net.BCrypt.Verify(password, reader["pass"].ToString()))
                    {
                        var user = new User(reader["username"].ToString(), reader["pass"].ToString(), Convert.ToInt32(reader["permission"].ToString()));
                        return user;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return null;
        }
    }
}
