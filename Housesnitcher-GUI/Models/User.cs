namespace Housesnitcher_GUI.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public ScopeLevel AuthLevel { get; set; }
    }
}