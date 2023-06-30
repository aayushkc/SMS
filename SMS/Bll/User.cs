using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SMS.Utils;

namespace SMS.Bll
{
    internal class User
    {
        public string UUID { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }
    }
}
