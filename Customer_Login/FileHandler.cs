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
                newCustAccount.customerSurname = myArray[0].ToLower();
                newCustAccount.customerAccountBalance = Convert.ToDouble(myArray[1]);
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
                newCustPassword.surname = myArray[0].ToLower();
                newCustPassword.password = myArray[1];
                newCustPassword.incorrectPasswordCount = Convert.ToInt32(myArray[2]);
                passwordList.Add(newCustPassword);
            }
        }
        public static void savePassworList(List<CustomerPassword> passwordList)
        {
            using (TextWriter tw = new StreamWriter(passwordFileLocation))
            {
                foreach (var account in passwordList)
                {
                    tw.WriteLine(account.surname + "," + account.password + "," + account.incorrectPasswordCount);
                }
            }
        }
    }
}
