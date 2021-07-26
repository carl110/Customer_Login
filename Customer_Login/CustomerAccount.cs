using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Login
{
    public class CustomerAccount
    {
        private double customerAccountBalance;
        private string customerSurname;

        public double CustomerAccountBalance { get => customerAccountBalance; set => customerAccountBalance = value; }
        public string CustomerSurname { get => customerSurname; set => customerSurname = value; }
    }
}
