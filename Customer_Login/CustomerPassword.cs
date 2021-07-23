using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Login
{
    public class CustomerPassword
    {
        public string surname { get; set; }
        public string password { get; set; }
        public int incorrectPasswordCount { get; set; }
    }
}
