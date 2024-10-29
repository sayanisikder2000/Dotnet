using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcount
{
  class Bank: CardDetails,InterfaceClass2,InterfaceClass1
    {
        int AccountBalance;
        const String CustomerName= "Sayani Sikder";
        String CustromerAddress = "Kolkata";
        const int CustomerIdNumber = 456223565;
        const int CustomerDOB =20082000;

      static Bank() 
        {
            Console.WriteLine("Welcome to ABC Bank");
        }

       public Bank()
        {
            System.Console.WriteLine("HELLO..... "+ CustomerName ); 
        }
       public Bank(int Balance)
        {
            this.AccountBalance = Balance;
            System.Console.WriteLine(CustomerName + ", your balance is " + AccountBalance);
        }

       public Bank(Bank b)
        {

        }
        public int Interest(int Balance)
        {
           int totalInterest = (Balance*10)/100;
            return totalInterest;
        }
        public void calculateAge(int todayDate)
        {
            int age = todayDate - CustomerDOB;
            System.Console.WriteLine("Your age is: "+ age);
        }
        public void fixedDeposite(int fixedDepositeAmount)
        {
            int monthlyInterest =(fixedDepositeAmount*10)/(100*12);
         System.Console.WriteLine("Fixed Deposite Amount is: "+  fixedDepositeAmount); 
            Console.WriteLine("Fixed Deposite monthly Interest is: "+monthlyInterest);
        }



       public void NewInsurance(String Name)
        {
            Console.WriteLine("HELLO "+ Name);
        }


        public void CalculateTotalBalance(int AvailableBal, int DepositeBal)
        {
            int totalBal = AvailableBal + DepositeBal;
            System.Console.WriteLine("Total Balance is = "+totalBal);
        }
        public void getCustomerDetails(String name)
        {
            Console.WriteLine("Customer name is " + name);
        }

    }
}
