using Housesnitcher_GUI.DataStorageAbstractions;
using Housesnitcher_GUI.GUI.Forms;
using Housesnitcher_GUI.Models;

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

            var user = new User("Test", "test");
            UserStore.Users.Add(user);

            ComplaintStore.Complaints.Add(new Complaint("testComplaint1", "test description #1", "Test", "Laundry", null, DateTime.UnixEpoch));
            ComplaintStore.Complaints.Add(new Complaint("testComplaint2", "test description #2", "Test", "Laundry", null, DateTime.UnixEpoch));
            ComplaintStore.Complaints.Add(new Complaint("testComplaint3", "test description #3", "Test", "Laundry", null, DateTime.UnixEpoch));
            ComplaintStore.Complaints.Add(new Complaint("testComplaint4", "test description #4", "Test", "Laundry", null, DateTime.UnixEpoch));
            ComplaintStore.Complaints.Add(new Complaint("testComplaint5", "test description #5", "Test", "Laundry", ComplaintStatus.Resolved, null, DateTime.UnixEpoch));
            ComplaintStore.Complaints.Add(new Complaint("testComplaint6", "test description #6", "Test", "Laundry", ComplaintStatus.Failed, null, DateTime.UnixEpoch));
            Application.Run(new MainForm(user));
        }
    }
}