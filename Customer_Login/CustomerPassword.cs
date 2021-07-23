using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Login
{
    public class CustomerPassword
    {
        private string surname;
        private string password;
        private int incorrectPasswordCount;

        public string Surname { get => surname; set => surname = value; }
        public string Password { get => password; set => password = value; }
        public int IncorrectPasswordCount { get => incorrectPasswordCount; set => incorrectPasswordCount = value; }
    }
}
