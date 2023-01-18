namespace Housesnitcher_GUI.Models
{
    public class TennantTask
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Username { get; set; }
        public string Type { get; set; }
        public TennantTaskStatus Status { get; set; }
        public DateTime DateDue { get; set; }
        public DateTime DateCreated { get; set; }

        public TennantTask(string title, string description, string username, string type, DateTime dateDue)
        {
            Title = title;
            Description = description;
            Username = username;
            Type = type;
            Status = TennantTaskStatus.Assigned;
            DateDue = dateDue;
            DateCreated = DateTime.Now;
        }
        public TennantTask(string title, string description, string username, string type, TennantTaskStatus status, DateTime dateDue, DateTime dateCreated)
        {
            Title = title;
            Description = description;
            Username = username;
            Type = type;
            Status = status;
            DateDue = dateDue;
            DateCreated = dateCreated;
        }
    }
}
