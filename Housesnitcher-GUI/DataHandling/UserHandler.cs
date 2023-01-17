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
            return _createUser(user.Username, user.Password);
        }
        public static User? CreateUser(User user)
        {
            return _createUser(user.Username, user.Password);
        }
        private static User? _createUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("select count(*) from users where username = @username and pass = @pass", connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@pass", password);

                    int UserExist = (int)command.ExecuteScalar();

                    if (UserExist > 0)
                    {
                        MessageBox.Show("User Already Exists");
                        return null;

                    }
                }
                connection.Close();
            }

            try
            {
                string query = "Insert into users (username, pass) values (@username, @pass)";
                using (SqlConnection connection = new SqlConnection(_connection))
                {

                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@pass", password);
                        command.ExecuteNonQuery();

                    }
                    connection.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            var user = new User(username, password);
            if (username == "Admin" && password == "admin")
            {
                user.AuthLevel = ScopeLevel.Admin;
            }
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
                string query = "Select * from users where username = @username and pass = @pass";

                using (SqlConnection connection = new SqlConnection(_connection))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@pass", password);
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            var user = new User(username, password);
                            return user;
                        }
                        else
                        {
                            return null;
                        }
                    }

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return null;
        }
    }
}
