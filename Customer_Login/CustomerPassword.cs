using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Login
{
    public class CustomerPassword
    {
        private string userName;
        private string password;
        private int incorrectPasswordCount;

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public int IncorrectPasswordCount { get => incorrectPasswordCount; set => incorrectPasswordCount = value; }
    }
}
