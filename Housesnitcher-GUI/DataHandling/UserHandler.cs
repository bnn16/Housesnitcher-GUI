using Housesnitcher_GUI.DataStorageAbstractions;
using Housesnitcher_GUI.Models;
using BCrypt.Net;

namespace Housesnitcher_GUI.DataHandling
{
    public static class UserHandler
    {
        public static bool CreateUser(string username, string unhashedPassword)
        {
            if (UserStore.Users.Find(x => x.Username == username) == null)
            {
                return false;
            }
            UserStore.Users.Add(new User
            {
                Username = username,
                Password = BCrypt.Net.BCrypt.HashPassword(unhashedPassword)
            });
            return true;
        }

        public static bool LogIn(string username, string password)
        {
            var user = UserStore.Users.Find(x => x.Username == username);
            if (user == null)
            {
                return false;
            }

            if (BCrypt.Net.BCrypt.Verify(password, user.Password))
            {
                return true;
            }
            return false;
        }
    }
}
