namespace Housesnitcher_GUI.Models
{
    public class LoginData
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public LoginData(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public LoginData() { }
    }
}