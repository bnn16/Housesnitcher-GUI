using Housesnitcher_GUI.DataStorageAbstractions;
using Housesnitcher_GUI.Models;
using BCrypt.Net;

namespace Housesnitcher_GUI.DataHandling
{
    public static class UserHandler
    {
        public static User? CreateUser(string username, string unhashedPassword)
        {
            if (UserStore.Users.Find(x => x.Username == username) == null)
            {
                return null;
            }
            var user = new User(username, unhashedPassword);
            UserStore.Users.Add(user);
            return user;
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
