using Housesnitcher_GUI.DataStorageAbstractions;
using Housesnitcher_GUI.Models;
using System.Data.SqlClient;

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
                using (SqlCommand command = new SqlCommand("select count(*) from complaints where title like @title and complaint_description like @comp_desc and username like @username and complaint_type like @complaint_type", connection))
                {
                    command.Parameters.AddWithValue("@title", complaint.Title);
                    command.Parameters.AddWithValue("@comp_desc", complaint.Description);
                    command.Parameters.AddWithValue("@username", complaint.Username);
                    command.Parameters.AddWithValue("@complaint_type", complaint.Type);
                    SqlDataReader reader = command.ExecuteReader(); ;
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Complaint Already Exists");
                        return null;

                    }
                    reader.Close();
                    reader.DisposeAsync();

                }
                connection.Close();
            }
            try
            {
                string query = "Insert into complaints (title, complaint_description, username, complaint_type, date_happened, date_created) values (@title, @complaint_descr, @username, @complaint_type, @date_happened, @date_created)";
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
                        command.ExecuteNonQuery();

                    }
                    connection.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            //    // membership check, we dont like duplicates
            //    if (ComplaintStore.Complaints.Contains(complaint))
            //    {
            //        return null;
            //    }
            //ComplaintStore.Complaints.Add(complaint);
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
            var idx = ComplaintStore.Complaints.FindIndex(x => x == complaint);
            ComplaintStore.Complaints[idx].Status = ComplaintStatus.Failed;
            return ComplaintStore.Complaints[idx];
        }
        private static Complaint? BumpStatus(Complaint complaint)
        {
            var idx = ComplaintStore.Complaints.FindIndex(x => x == complaint);
            ComplaintStore.Complaints[idx].Status++;
            return ComplaintStore.Complaints[idx];
        }

        public static List<Complaint> AllComplaints()
        {
            List<Complaint> allComplaints = new List<Complaint>();


            using(SqlConnection )


                //https://stackoverflow.com/questions/16856687/getting-data-from-sql-and-putting-in-a-list
                return allComplaints;
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
