namespace Housesnitcher_GUI.Models
{
    public class Announcement
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Announcer { get; set; }
        public DateTime Announced { get; set; }
        public DateTime ReferredDate { get; set; }

        public Announcement(string title, string description, string announcer, DateTime referredDate)
        {
            Title = title;
            Description = description;
            Announcer = announcer;
            Announced = DateTime.Now.Date;
            ReferredDate = referredDate;
        }
        public Announcement(string title, string description, string announcer, DateTime announced, DateTime referredDate)
        {
            Title = title;
            Description = description;
            Announcer = announcer;
            Announced = announced;
            ReferredDate = referredDate;

        }

        public Announcement() { }
    }
}
