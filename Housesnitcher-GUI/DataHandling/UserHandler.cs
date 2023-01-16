using Housesnitcher_GUI.Models;
using System.Data.SqlClient;

namespace Housesnitcher_GUI.DataHandling
{
    public static class UserHandler
    {
        private static readonly string _connection = "data source = MSI\\SQLEXPRESS; database=Group Project; integrated security=True";
        public static User? CreateUser(string username, string unhashedPassword)
        {
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("select count(*) from users where username = @username and pass = @pass", connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@pass", unhashedPassword);

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
                        command.Parameters.AddWithValue("@pass", unhashedPassword);
                        command.ExecuteNonQuery();

                    }
                    connection.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            var user = new User(username, unhashedPassword);
            if (username == "Admin" && unhashedPassword == "admin")
            {
                user.AuthLevel = ScopeLevel.Admin;
            }
            return user;
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
                        else {
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
