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

        public Complaint(string title, string description, string username, string type, ComplaintStatus status, string? complaintFeedback, DateTime dateHappened)
        {
            Title = title;
            Description = description;
            Username = username;
            Type = type;
            Status = status;
            ComplaintFeedback = complaintFeedback;
            DateHappened = dateHappened;
            DateCreated = DateTime.Now;
        }
    }
}
