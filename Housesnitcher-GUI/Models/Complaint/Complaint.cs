namespace Housesnitcher_GUI.Models
{
    public class Complaint
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Username { get; private set; }
        public string Type { get; private set; }
        public ComplaintStatus Status { get; set; }
        public string? ComplaintFeedback { get; set; }
        public DateTime DateHappened { get; private set; }
        public DateTime DateCreated { get; private set; }
    }
}
