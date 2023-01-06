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

        public override string ToString()
        {
            return $$"""
                    Username: {{Username}}
                    PermissionLevel: {{AuthLevel}}
                    """;
        }
    }
}