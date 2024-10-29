using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcount
{
    internal class CardDetails
    {
        public void DebitCard(String Name)
        {
            Console.WriteLine("Enter your Debit Card Number: ");
            int cardNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Hello " + Name + ".........this is your last 3 transaction");

        }
        public void CreditCard(String Name, int limit)
        {
            Console.WriteLine("Enter your Credit Card Number: ");
            int cardNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Hello " + Name + " your Credit Card limt is " + limit);
        }
    }
}
