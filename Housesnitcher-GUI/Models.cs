using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housesnitcher_GUI
{
    public class LoginData
    {
        public String username { get; set; }
        public String password { get; set; }
    }

    public class Response
    {
        public string status { get; set; }
        public bool auth { get; set; }
        public scopeLevel scope { get; set; }
    }

    public enum scopeLevel
    {
        None = 0,
        User = 1,
        Admin = 2
    }

    public class User
    {
        public String username { get; set; }
        public scopeLevel authLevel { get; set; }
    }

    public class State
    {
        public User user { get; set; }
    }
}
