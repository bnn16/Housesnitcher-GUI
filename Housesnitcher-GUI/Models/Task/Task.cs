namespace Housesnitcher_GUI.Models
{
    public class Task
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Username { get; private set; }
        public string Type { get; private set; }
        public TaskStatus Status { get; set; }
        public DateTime DateDue { get; private set; }
        public DateTime DateCreated { get; private set; }
        public Models.TaskStatus status { get; private set; }
    }
}
