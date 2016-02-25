using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace JustigeLeague
{
    class UserService
    {
        public bool IsUserLoggedIn()
        {
            throw new InvalidOperationException("Should not be call from unit test");
        }
    }
}
