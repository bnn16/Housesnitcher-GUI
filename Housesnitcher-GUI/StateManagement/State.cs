using Housesnitcher_GUI.Models;

namespace Housesnitcher_GUI.StateManagement
{
    public static class State
    {
        // localized state
        public static User User { get; set; }

        // server-side state
        public static List<string> complaintTypes = new();
        public static List<string> TaskTypes = new();
    }
}
