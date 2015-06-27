using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_Bank_of_Kurtovo_Konare
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            Customer neno = new IndividualCustomer("Memi", "Zoiski", "9876546783");
            Customer XSSoftware = new Entity("XSSoftware", "1234565408");
            Customer VMWare = new Entity("VMWare", "1345687609");

            DepositAccount depositeXS = new DepositAccount(XSSoftware, 150000, 2.5, new DateTime(2012, 02, 05));
            LoanAccounts peshevLoanAccount = new LoanAccounts(neno, 1000, 3.6, new DateTime(2010, 2, 4));
            MortgageAccount nichevMortgageAccount = new MortgageAccount(VMWare, 567000000, 2.09, new DateTime(2008, 02, 04));

            Account[] accounts = { depositeXS, peshevLoanAccount, nichevMortgageAccount };

            foreach (var account in accounts)
            {
                Console.WriteLine("Name: {0}   Interest Rate: {1}", account.GetCustomer.Name, account.GetInterest);
            }




        }
    }
}
