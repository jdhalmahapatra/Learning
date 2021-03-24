using System;
using System.Collections.Generic;
using System.Text;

/*This Use case demonstatres how to use multi cast delegate.
 * Here in this sceanrio created a very basic Bank class, in which all the Loan Deparment method is being defined. 
 * Based on the branch code we can identify what all the department available in a particular Bank branch 
 * By adding and removing the function pointer to the delegate Chain.
 * This is an example of Multi Cast Delegate*/

namespace Delegate
{
    class MultiCastDelegateWithUseCase
    {
        static void Main(string[] args)
        {
            Bank[] bank = new Bank[3];
            bank[0] = new Bank {
                BankCode = 100,
                BankName = "HDFC Ltd"
            };
            bank[1] = new Bank
            {
                BankCode = 102,
                BankName = "HDFC Ltd"
            };
            bank[2] = new Bank
            {
                BankCode = 112,
                BankName = "HDFC Ltd"
            };
            BankDeptDelegate bankDel = new BankDeptDelegate(Bank.PersonalLoanDepartMent);

            if(bank[0].BankCode == 100)
            {
                Console.WriteLine("1. {0}, BankCode = {1} below are the available department", bank[0].BankName, bank[0].BankCode);
                bankDel += Bank.HomeLoanDept;
                bankDel += Bank.StudyLoanDept;
                bankDel += Bank.MortgageLoanDept;
                bankDel();
            }
            if (bank[1].BankCode == 102)
            {
                Console.WriteLine("2. {0}, BankCode = {1} below are the available department", bank[1].BankName, bank[1].BankCode);
                bankDel -= Bank.HomeLoanDept;
                bankDel();
            }
            if (bank[2].BankCode == 112)
            {
                Console.WriteLine("3. {0}, BankCode = {1} below are the available department", bank[2].BankName, bank[2].BankCode);
                bankDel -= Bank.HomeLoanDept;
                bankDel -= Bank.MortgageLoanDept;
                bankDel();
            }

        }
        
    }


    delegate void BankDeptDelegate(); //Declare Deleaget
    class Bank
    {
        public int BankCode { get; set; }
        public string BankName { get; set; }

        public static void PersonalLoanDepartMent()
        {
            Console.WriteLine("Personal Loan Dept Available");
        }
        public static void HomeLoanDept()
        {
            Console.WriteLine("Home Loan Dept Available");
        }
        public static void StudyLoanDept()
        {
            Console.WriteLine("Study Loan Dept Available");
        }
        public static void MortgageLoanDept()
        {
            Console.WriteLine("Mortgage Loan Dept Available");
        }
    }
}
