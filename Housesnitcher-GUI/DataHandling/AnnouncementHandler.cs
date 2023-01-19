using Housesnitcher_GUI.Models;
using System.Data.SqlClient;

namespace Housesnitcher_GUI.DataHandling
{
    public static class AnnouncementHandler
    {

        private static readonly string _connection = $"data source = {StateManagement.State.DataSource}; database={StateManagement.State.ConnectionString}; integrated security=SSPI";
        public static Announcement? CreateAnnouncement(Announcement announcement)
        {
            // check if there is an announcement
            // if there is an announcement, return null
            try
            {
                string query = "Insert into announcements (title, descr, announcer, announced, referred_date) values (@title, @descr, @announcer, @announced, @referredDate)";
                using SqlConnection connection = new SqlConnection(_connection);

                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@title", announcement.Title);
                    command.Parameters.AddWithValue("@descr", announcement.Description);
                    command.Parameters.AddWithValue("@announcer", announcement.Announcer);
                    command.Parameters.AddWithValue("@announced", announcement.Announced);
                    command.Parameters.AddWithValue("@referredDate", announcement.ReferredDate);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            catch (Exception) { return null; }
            return announcement;
        }

        public static List<Announcement> GetAnnouncements()
        {
            // get all the announcements
            // put them in a list
            // and return them
            List<Announcement> announcements = new();
            string query = "Select * from announcements";
            using SqlConnection connection = new SqlConnection(_connection);
            connection.Open();
            using SqlCommand command = new SqlCommand(query, connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                announcements.Add(
                    new Announcement(
                        reader["title"].ToString(),
                        reader["descr"].ToString(),
                        reader["announcer"].ToString(),
                        DateTime.Parse(reader["announced"].ToString()),
                        DateTime.Parse(reader["referred_date"].ToString())
                    ));
            }
            announcements.Reverse();
            return announcements;
        }
    }
}
