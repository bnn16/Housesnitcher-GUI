namespace Housesnitcher_GUI.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public ScopeLevel AuthLevel { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Password = BCrypt.Net.BCrypt.HashPassword(password);
            AuthLevel = ScopeLevel.User;
        }
        // use this only when you already have created a user
        public User(string username, string password, int authLevel)
        {
            Username = username;
            Password = password;
            AuthLevel = (ScopeLevel)authLevel;
        }

        // do not delete this
        public User() { }

        public override string ToString()
        {
            return $$"""
                    Username: {{Username}}
                    Permission: {{AuthLevel}}
                    """;
        }
    }
}