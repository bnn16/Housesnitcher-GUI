using Housesnitcher_GUI.DataHandling;
using Housesnitcher_GUI.DataStorageAbstractions;
using Housesnitcher_GUI.GUI.Forms;
using Housesnitcher_GUI.Models;
using Housesnitcher_GUI.StateManagement;

namespace Housesnitcher_GUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // put some dummy data here if you want to test out the app.

            var root = Directory.GetCurrentDirectory();
            var dotenv = Path.Combine(root, "..\\..\\..\\..\\");
            dotenv = Path.GetFullPath(Path.Combine(dotenv, ".env"));
            DotEnv.Load(dotenv);
            State.ConnectionString = Environment.GetEnvironmentVariable("DATABASES__SQLSERVER__CONNECTIONSTRING");
            State.DataSource = Environment.GetEnvironmentVariable("DATABASES__SQLSERVER__DATASOURCE");

            var user = new User("Admin", "admin");
            user.AuthLevel = ScopeLevel.Admin;
            UserStore.Users.Add(user);
            State.complaintTypes.Add("Laundry");
            State.complaintTypes.Add("Noise");
            State.complaintTypes.Add("Trash");
            State.complaintTypes.Add("Toilet");
            State.complaintTypes.Add("Maintenance");
            State.complaintTypes.Add("Temperature");
            State.complaintTypes.Add("Kitchen");
            UserHandler.CreateUser("Admin", "admin");

            //ComplaintStore.Complaints.Add(new Complaint("testComplaint2", "test description #2", "Test", "Laundry", null, DateTime.UnixEpoch));
            //ComplaintStore.Complaints.Add(new Complaint("testComplaint3", "test description #3", "Test", "Laundry", null, DateTime.UnixEpoch));
            //ComplaintStore.Complaints.Add(new Complaint("testComplaint4", "test description #4", "Test", "Laundry", null, DateTime.UnixEpoch));
            //ComplaintStore.Complaints.Add(new Complaint("testComplaint5", "test description #5", "Test", "Laundry", ComplaintStatus.Resolved, null, DateTime.UnixEpoch));
            //ComplaintStore.Complaints.Add(new Complaint("testComplaint6", "test description #6", "Test", "Laundry", ComplaintStatus.Failed, null, DateTime.UnixEpoch));
            //ComplaintStore.Complaints.Add(new Complaint("testComplaint7", "test description #7", "Test", "Laundry", ComplaintStatus.Acknowledged, null, DateTime.UnixEpoch));
            //ComplaintStore.Complaints.Add(new Complaint("testComplaint8", "test description #8", "Test", "Laundry", ComplaintStatus.Reviewed, null, DateTime.UnixEpoch));
            //ComplaintStore.Complaints.Add(new Complaint("testComplaint9", "test description #9", "Test", "Laundry", ComplaintStatus.Failed, null, DateTime.UnixEpoch));
            //ComplaintStore.Complaints.Add(new Complaint("testComplaint10", "test description #10", "Test", "Laundry", ComplaintStatus.Resolved, "Some test feedback.", DateTime.UnixEpoch));
            //ComplaintStore.Complaints.Add(new Complaint("testComplaint11", "test description #11", "Test", "Laundry", ComplaintStatus.Reviewed, null, DateTime.UnixEpoch));
            Application.Run(new MainForm(user));
        }
    }
}