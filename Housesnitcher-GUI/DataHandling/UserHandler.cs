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
            UserStore.Users.Add(new User(username, unhashedPassword));
            return true;
        }

        public static User? LogIn(string username, string password)
        {
            var user = UserStore.Users.Find(x => x.Username == username);
            if (user == null)
            {
                return null;
            }

            if (BCrypt.Net.BCrypt.Verify(password, user.Password))
            {
                return user;
            }
            return null;
        }
    }
}
