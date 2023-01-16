using Housesnitcher_GUI.Models;
using System.Configuration;

namespace Housesnitcher_GUI.StateManagement
{
    public static class State
    {
        // localized state
        public static User User { get; set; }

        // server-side state
        public static List<string> complaintTypes = new();
        public static List<string> TaskTypes = new();
        public static string ConnectionString = Environment.GetEnvironmentVariable("DATABASES__SQLSERVER__CONNECTIONSTRING");
        public static string DataSource = Environment.GetEnvironmentVariable("DATABASES__SQLSERVER__DATASOURCE");
    }
}
