using Housesnitcher_GUI.DataStorageAbstractions;
using Housesnitcher_GUI.Models;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Housesnitcher_GUI.DataHandling
{


    public static class ComplaintHandler
    {
        private static readonly string _connection = "data source = MSI\\SQLEXPRESS; database=Group Project; integrated security=True";

        public static Complaint? LodgeComplaint(Complaint complaint)
        {
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("select count(*) from complaints where title = @title and complaint_description = @comp_desc and username = @username and complaint_type = @complaint_type", connection))
                {
                    command.Parameters.AddWithValue("@title", complaint.Title);
                    command.Parameters.AddWithValue("@comp_desc", complaint.Description);
                    command.Parameters.AddWithValue("@username", complaint.Username);
                    command.Parameters.AddWithValue("@complaint_type", complaint.Type);
                    int ComplaintExists = (int)command.ExecuteScalar();

                    if (ComplaintExists > 0)
                    {
                        MessageBox.Show("Complaint Already Exists");
                        return null;

                    }
                }
                connection.Close();
            }


            try
            {
                string query = "Insert into complaints (title, complaint_description, username, complaint_type, date_happened, date_created, complaint_status) values (@title, @complaint_descr, @username, @complaint_type, @date_happened, @date_created, @status)";
                using (SqlConnection connection = new SqlConnection(_connection))
                {

                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@title", complaint.Title);
                        command.Parameters.AddWithValue("@complaint_descr", complaint.Description);
                        command.Parameters.AddWithValue("@username", complaint.Username);
                        command.Parameters.AddWithValue("@complaint_type", complaint.Type);
                        command.Parameters.AddWithValue("@date_happened", complaint.DateHappened);
                        command.Parameters.AddWithValue("@date_created", complaint.DateCreated);
                        command.Parameters.AddWithValue("@status", complaint.Status);
                        command.ExecuteNonQuery();

                    }
                    connection.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return complaint;
        }
        public static Complaint? AcknowledgeComplaint(Complaint complaint)
        {
            if (complaint.Status != ComplaintStatus.Created)
            {
                return null;
            }
            return BumpStatus(complaint);
        }
        // you want to definitely update the form after using this method.
        public static Complaint? ReviewComplaint(Complaint complaint, string feedback)
        {
            if (complaint.Status != ComplaintStatus.Acknowledged)
            {
                return null;
            }
            complaint.ComplaintFeedback = feedback;
            return BumpStatus(complaint);
        }
        public static Complaint? ResolveComplaint(Complaint complaint)
        {
            if (complaint.Status != ComplaintStatus.Reviewed)
            {
                return null;
            }
            return BumpStatus(complaint);
        }
        // complaint is trash, spam, doesn't conform to the guidelines, or whatever.
            public static Complaint? FailComplaint(Complaint complaint)
            {
                using (var connection = new SqlConnection(_connection))
                {
                    connection.Open();

                    var command = new SqlCommand("UPDATE complaints SET complaint_status = @status WHERE title = @title AND complaint_description = @description AND username = @username", connection);
                    command.Parameters.AddWithValue("@status", ComplaintStatus.Failed);
                    command.Parameters.AddWithValue("@title", complaint.Title);
                    command.Parameters.AddWithValue("@description", complaint.Description);
                    command.Parameters.AddWithValue("@username", complaint.Username);

                    var rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        var updatedCommand = new SqlCommand("SELECT * FROM complaints WHERE title = @title AND complaint_description = @description AND username = @username", connection);
                        updatedCommand.Parameters.AddWithValue("@title", complaint.Title);
                        updatedCommand.Parameters.AddWithValue("@description", complaint.Description);
                        updatedCommand.Parameters.AddWithValue("@username", complaint.Username);

                        using (var reader = updatedCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                            string Title = reader["title"].ToString();
                            string ComplaintDescription = reader["complaint_description"].ToString();
                            string Username = reader["username"].ToString();
                            string ComplaintType = reader["complaint_type"].ToString();
                            ComplaintStatus Status = (ComplaintStatus)reader["complaint_status"];
                            string Feedback = reader["complaint_feedback"].ToString();
                            DateTime DateHappened = (DateTime)reader["date_happened"];
                            return new Complaint(Title, ComplaintDescription, Username, ComplaintType, Status, Feedback, DateHappened);
                            }
                        }
                    }
                

                return null;
            }

        }
        //private static Complaint? BumpStatus(Complaint complaint)
        //{
        //    var idx = ComplaintStore.Complaints.FindIndex(x => x == complaint);
        //    ComplaintStore.Complaints[idx].Status++;
        //    return ComplaintStore.Complaints[idx];
        //}

        public static Complaint? BumpStatus(Complaint complaint)
        {
            using (var connection = new SqlConnection(_connection))
            using (var command = connection.CreateCommand())
            {
                connection.Open();
                command.CommandText = "Update complaints set complaint_status = complaint_status + 1 where title = @Title and complaint_description = @Description and username = @Username and complaint_type = @Type";
                command.Parameters.AddWithValue("@Title", complaint.Title);
                command.Parameters.AddWithValue("@Description", complaint.Description);
                command.Parameters.AddWithValue("@Username", complaint.Username);
                command.Parameters.AddWithValue("@Type", complaint.Type);
                var rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected == 1)
                {
                    command.CommandText = "SELECT * FROM complaints WHERE title = @Title AND complaint_description = @Description " +
                                          "AND username = @Username AND complaint_type = @Type";
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                             string Title = reader["title"].ToString();
                            string ComplaintDescription = reader["complaint_description"].ToString();
                            string Username = reader["username"].ToString();
                            string ComplaintType = reader["complaint_type"].ToString();
                            ComplaintStatus Status;
                            if (reader.IsDBNull(reader.GetOrdinal("complaint_status")))
                            {
                                Status = ComplaintStatus.Created;
                            }
                            else if ((int)reader["complaint_status"] == 0)
                            {
                                Status = ComplaintStatus.Created;
                            }
                            else if ((int)reader["complaint_status"] == 1)
                            {
                                Status = ComplaintStatus.Acknowledged;
                            }
                            else if ((int)reader["complaint_status"] == 2)
                            {
                                Status = ComplaintStatus.Reviewed;
                            }
                            else if ((int)reader["complaint_status"] == 3)
                            {
                                Status = ComplaintStatus.Resolved;
                            }
                            else if ((int)reader["complaint_status"] == 4)
                            {
                                Status = ComplaintStatus.Failed;
                            }
                            else {
                                Status = ComplaintStatus.Failed;
                            }
                            DateTime DateHappened = (DateTime)reader["date_happened"];
                            return new Complaint(Title, ComplaintDescription, Username, ComplaintType, Status, complaint.ComplaintFeedback, DateHappened);
                            }
                        }
                    }
                }
                return null;
            }




       public static List<Complaint> AllComplaints()
{
    List<Complaint> allComp = new List<Complaint>();
    using (SqlConnection connection = new SqlConnection(_connection)) { 
        connection.Open();
        using (SqlCommand command = new SqlCommand("select * from complaints", connection)) {
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) {
                string title = (string)reader["title"];
                string comp_desc = (string)reader["complaint_description"];
                string user = (string)reader["username"];
                string complaint_type = (string)reader["complaint_type"];
                string comp_feedback = reader["complaint_feedback"] is DBNull ? null : reader["complaint_feedback"].ToString();
                DateTime date_happened = (DateTime)reader["date_happened"];
                Complaint c = new Complaint(title, comp_desc , user, complaint_type, comp_feedback  ,date_happened);
                ComplaintStatus Status;

                        if (reader.IsDBNull(reader.GetOrdinal("complaint_status")))
                        {
                            Status = ComplaintStatus.Created;
                        }
                        else if (reader.GetInt32(reader.GetOrdinal("complaint_status")) == 0){
                            Status = ComplaintStatus.Created;
                        }
                        else if (reader.GetInt32(reader.GetOrdinal("complaint_status")) == 1)
                        {
                            Status = ComplaintStatus.Acknowledged;
                        }
                        else if (reader.GetInt32(reader.GetOrdinal("complaint_status")) == 2)
                        {
                            Status = ComplaintStatus.Reviewed;
                        }
                        else if (reader.GetInt32(reader.GetOrdinal("complaint_status")) == 3)
                        {
                            Status = ComplaintStatus.Resolved;
                        }
                        else if (reader.GetInt32(reader.GetOrdinal("complaint_status")) == 4)
                        {
                            Status = ComplaintStatus.Failed;
                        }
                        else
                        {
                            Status = ComplaintStatus.Failed;
                        }
                c.Status = Status;
                allComp.Add(c);
            }
        }
    }
    return allComp;
}


        public static List<Complaint> SpecificUserComplaints(User user)
        {
            return Filter(user.Username);
        }
        public static List<Complaint> SpecificUserComplaints(string username)
        {
            return Filter(username);
        }
        private static List<Complaint> Filter(string username)
        {
            return AllComplaints().FindAll(x => x.Username == username);
        }
    }
}
