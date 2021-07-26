using System;
using System.Collections.Generic;
using System.IO;

namespace Customer_Login
{
    class FileHandler
    {
        static string accountBalanceFileLocation = @"AccountInfo.txt";
        static string passwordFileLocation = @"AccountPasswords.txt";

        public static void getBalanceList(List<CustomerAccount> balanceList)
        {
            string[] myArray = { "Surname", "Account Balance" };
            foreach (var line in File.ReadAllLines(accountBalanceFileLocation))
            {
                myArray = line.Trim().Split(',');
                CustomerAccount newCustAccount = new CustomerAccount();
                newCustAccount.CustomerSurname = myArray[0].ToLower();
                newCustAccount.CustomerAccountBalance = Convert.ToDouble(myArray[1]);
                balanceList.Add(newCustAccount);
            }
        }

        public static void getPasswordList(List<CustomerPassword> passwordList)
        {
            string[] myArray = { "Surname", "Account Balance" };
            foreach (var line in File.ReadAllLines(passwordFileLocation))
            {
                myArray = line.Trim().Split(',');
                CustomerPassword newCustPassword = new CustomerPassword();
                newCustPassword.UserName = myArray[0].ToLower();
                newCustPassword.Password = myArray[1];
                newCustPassword.IncorrectPasswordCount = Convert.ToInt32(myArray[2]);
                passwordList.Add(newCustPassword);
            }
        }
        public static void savePassworList(List<CustomerPassword> passwordList)
        {
            using (TextWriter tw = new StreamWriter(passwordFileLocation))
            {
                foreach (var account in passwordList)
                {
                    tw.WriteLine(account.UserName + "," + account.Password + "," + account.IncorrectPasswordCount);
                }
            }
        }
    }
}
